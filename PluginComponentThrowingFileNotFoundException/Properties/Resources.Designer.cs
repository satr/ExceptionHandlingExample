﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PluginComponent.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PluginComponent.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected file not found in plugin..
        /// </summary>
        internal static string Message_Expected_file_not_found_in_plugin {
            get {
                return ResourceManager.GetString("Message_Expected_file_not_found_in_plugin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Plugin {0} finished.
        /// </summary>
        internal static string Message_Plugin__0__finished {
            get {
                return ResourceManager.GetString("Message_Plugin__0__finished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Plugin {0} is starting.
        /// </summary>
        internal static string Message_Plugin__0__is_starting {
            get {
                return ResourceManager.GetString("Message_Plugin__0__is_starting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected error occured in plugin..
        /// </summary>
        internal static string Message_Unexpected_error_occured_in_plugin {
            get {
                return ResourceManager.GetString("Message_Unexpected_error_occured_in_plugin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Plugin throwing FileNotFoundException.
        /// </summary>
        internal static string Title_Plugin_throwing_FileNotFoundException {
            get {
                return ResourceManager.GetString("Title_Plugin_throwing_FileNotFoundException", resourceCulture);
            }
        }
    }
}
