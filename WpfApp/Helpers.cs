using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using ExternalBLInterfaces;

namespace WpfApp
{
    class Helpers
    {
        private static readonly NameComparer NameComparer = new NameComparer();
        private const string ComponentExtension = ".dll";
        private const string FileComponentSearchPattern = "*" + ComponentExtension;
        
        public static List<IExternalBL> LoadExternalComponents()
        {
            var entryAssembly = Assembly.GetEntryAssembly();
            var referencedComponentFileNames = entryAssembly.GetReferencedAssemblies()
                                                            .Select(referencedAssembly => referencedAssembly.Name + ComponentExtension)
                                                            .ToList();
            
            var plugins = new List<IExternalBL>();

            var fileNames = Directory.GetFiles(".", FileComponentSearchPattern);
            foreach (var fileName in fileNames)
            {
                if (referencedComponentFileNames.Contains(new FileInfo(fileName).Name, NameComparer))
                    continue;
        
                try
                {
                    var externalAssembly = Assembly.LoadFrom(fileName);
                    var exportedTypes = externalAssembly.GetExportedTypes()
                                                        .Where(t => !t.IsInterface && typeof(IExternalBL).IsAssignableFrom(t));
                    plugins.AddRange(exportedTypes.Select(Activator.CreateInstance).OfType<IExternalBL>());
                }
                catch (BadImageFormatException)
                {
                    //skip non-assembly file
                }
            }
            return plugins;
        }

        public static UIElement CreateExternalBLUIElement(IExternalBL externalBL)
        {
            var element = new Button
            {
                Content = externalBL.Description,
                Command = new DoWorkWithExternalBLCommand(externalBL)
            };
            return element;
        }
    }

    internal class NameComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return x.Equals(y, StringComparison.InvariantCultureIgnoreCase);
        }

        public int GetHashCode(string obj)
        {
            return obj == null ? 0: obj.GetHashCode();
        }
    }
}
