﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WcfService.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Operation cannot be performed..
        /// </summary>
        internal static string Messafe_Operation_cannot_be_performed {
            get {
                return ResourceManager.GetString("Messafe_Operation_cannot_be_performed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access to database denied.
        /// </summary>
        internal static string Message_Access_to_database_denied {
            get {
                return ResourceManager.GetString("Message_Access_to_database_denied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Book storage is not available at this time..
        /// </summary>
        internal static string Message_Book_storage_is_not_available_at_this_time {
            get {
                return ResourceManager.GetString("Message_Book_storage_is_not_available_at_this_time", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Book with such title and amount of pages exists..
        /// </summary>
        internal static string Message_Book_with_such_title_and_amount_of_pages_exists {
            get {
                return ResourceManager.GetString("Message_Book_with_such_title_and_amount_of_pages_exists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This book already exists..
        /// </summary>
        internal static string Message_This_book_already_exists {
            get {
                return ResourceManager.GetString("Message_This_book_already_exists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This operation requires user permits..
        /// </summary>
        internal static string Message_This_operation_requires_user_permits {
            get {
                return ResourceManager.GetString("Message_This_operation_requires_user_permits", resourceCulture);
            }
        }
    }
}
