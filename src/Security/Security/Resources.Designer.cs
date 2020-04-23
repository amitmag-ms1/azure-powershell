﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.SecurityCenter {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.SecurityCenter.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Failed to deserialize SQL inforamtion protection policy..
        /// </summary>
        internal static string SqlInformationProtectionPolicyDeserializationError {
            get {
                return ResourceManager.GetString("SqlInformationProtectionPolicyDeserializationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Display names should be unique. Please eliminate duplication of these names: {0}..
        /// </summary>
        internal static string SqlInformationProtectionPolicyDuplicatedDisplayNamesError {
            get {
                return ResourceManager.GetString("SqlInformationProtectionPolicyDuplicatedDisplayNamesError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ids should be unique. Please eliminate duplication of these ids: {0}..
        /// </summary>
        internal static string SqlInformationProtectionPolicyDuplicatedIdsError {
            get {
                return ResourceManager.GetString("SqlInformationProtectionPolicyDuplicatedIdsError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided policy definition is empty..
        /// </summary>
        internal static string SqlInformationProtectionPolicyEmptyError {
            get {
                return ResourceManager.GetString("SqlInformationProtectionPolicyEmptyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided file {0} does not exist..
        /// </summary>
        internal static string SqlInformationProtectionPolicyFileDoesNotExistError {
            get {
                return ResourceManager.GetString("SqlInformationProtectionPolicyFileDoesNotExistError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to retrieve SQL information protection policy..
        /// </summary>
        internal static string SqlInformationProtectionPolicyNotRetrievedError {
            get {
                return ResourceManager.GetString("SqlInformationProtectionPolicyNotRetrievedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to update SQL information protection policy..
        /// </summary>
        internal static string SqlInformationProtectionPolicyUpdateError {
            get {
                return ResourceManager.GetString("SqlInformationProtectionPolicyUpdateError", resourceCulture);
            }
        }
    }
}
