﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wiki.Resources.Models {
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
    public class StringArticleValidation {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringArticleValidation() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Wiki.Resources.Models.StringArticleValidation", typeof(StringArticleValidation).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The old password is required.
        /// </summary>
        public static string AncienMDP {
            get {
                return ResourceManager.GetString("AncienMDP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The password and the confirmation must match.
        /// </summary>
        public static string ComparaisonMDP {
            get {
                return ResourceManager.GetString("ComparaisonMDP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The email is required.
        /// </summary>
        public static string Courriel {
            get {
                return ResourceManager.GetString("Courriel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The email must be valid.
        /// </summary>
        public static string CourrielValide {
            get {
                return ResourceManager.GetString("CourrielValide", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The password is required.
        /// </summary>
        public static string MDP {
            get {
                return ResourceManager.GetString("MDP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The confirmation is required.
        /// </summary>
        public static string MDPConfirmation {
            get {
                return ResourceManager.GetString("MDPConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The last name is required.
        /// </summary>
        public static string NomFamille {
            get {
                return ResourceManager.GetString("NomFamille", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The first name is required.
        /// </summary>
        public static string Prenom {
            get {
                return ResourceManager.GetString("Prenom", resourceCulture);
            }
        }
    }
}
