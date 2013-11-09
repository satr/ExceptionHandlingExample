using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using ExternalBLInterfaces;

namespace WpfApp
{
    internal class PluginHelper
    {
        private static readonly NameComparer NameComparer = new NameComparer();
        private const string ComponentExtension = ".dll";
        private const string FileComponentSearchPattern = "*" + ComponentExtension;

        public static List<IPlugin> LoadPlugins()
        {
            var plugins = new List<IPlugin>();

            var referencedComponentFileNames = GetReferencedComponentFileNames();
            foreach (var fileName in GetComponentFileNames())
            {
                if (referencedComponentFileNames.Contains(new FileInfo(fileName).Name, NameComparer))
                    continue;
                plugins.AddRange(GetPluginsFrom(fileName));
            }

            return plugins;
        }

        private static IEnumerable<IPlugin> GetPluginsFrom(string fileName)
        {
            Assembly externalAssembly;
            try
            {
                externalAssembly = Assembly.LoadFrom(fileName);
            }
            catch (BadImageFormatException)
            {
                //skip non-assembly filesS
                return new List<IPlugin>();
            }
            var exportedTypes = externalAssembly.GetExportedTypes()
                .Where(t => !t.IsInterface && typeof (IPlugin).IsAssignableFrom(t));
            return exportedTypes.Select(Activator.CreateInstance).OfType<IPlugin>();
        }

        private static IEnumerable<string> GetComponentFileNames()
        {
            return Directory.GetFiles(".", FileComponentSearchPattern);
        }

        private static List<string> GetReferencedComponentFileNames()
        {
            var entryAssembly = Assembly.GetEntryAssembly();
            var referencedComponentFileNames = entryAssembly.GetReferencedAssemblies()
                .Select(referencedAssembly => referencedAssembly.Name + ComponentExtension)
                .ToList();
            return referencedComponentFileNames;
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
