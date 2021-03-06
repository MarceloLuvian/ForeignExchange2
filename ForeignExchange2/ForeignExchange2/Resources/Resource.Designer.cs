﻿namespace ForeignExchange2.Resources {
    using System;
    using System.Reflection;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("ForeignExchange2.Resources.Resource", typeof(Resource).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string Title {
            get {
                return ResourceManager.GetString("Title", resourceCulture);
            }
        }
        internal static string Accept
        {
            get
            {
                return ResourceManager.GetString("Accept", resourceCulture);
            }
        }
        internal static string Error
        {
            get
            {
                return ResourceManager.GetString("Error", resourceCulture);
            }
        }
        internal static string AmountValidation
        {
            get
            {
                return ResourceManager.GetString("AmountValidation", resourceCulture);
            }
        }
    }
}
