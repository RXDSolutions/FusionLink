﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RxdSolutions.FusionLink.Client.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RxdSolutions.FusionLink.Client.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The requested curve could not be found.
        /// </summary>
        internal static string CurveNotFoundMessage {
            get {
                return ResourceManager.GetString("CurveNotFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Instrument not found.
        /// </summary>
        internal static string InstrumentNotFoundMessage {
            get {
                return ResourceManager.GetString("InstrumentNotFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested portfolio could not be found.
        /// </summary>
        internal static string PortfolioNotFoundMessage {
            get {
                return ResourceManager.GetString("PortfolioNotFoundMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested positions cannot be found as the portfolio is not loaded..
        /// </summary>
        internal static string PortfolioNotLoadedMessage {
            get {
                return ResourceManager.GetString("PortfolioNotLoadedMessage", resourceCulture);
            }
        }
    }
}
