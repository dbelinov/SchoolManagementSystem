﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagementSystem.Web.Resources {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Views_Student_Dashboard_en {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Views_Student_Dashboard_en() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("SchoolManagementSystem.Web.Resources.Views_Student_Dashboard_en", typeof(Views_Student_Dashboard_en).Assembly);
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
        
        internal static string Dashboard {
            get {
                return ResourceManager.GetString("Dashboard", resourceCulture);
            }
        }
        
        internal static string AverageGrade {
            get {
                return ResourceManager.GetString("AverageGrade", resourceCulture);
            }
        }
        
        internal static string GradeCount {
            get {
                return ResourceManager.GetString("GradeCount", resourceCulture);
            }
        }
        
        internal static string ProjectCount {
            get {
                return ResourceManager.GetString("ProjectCount", resourceCulture);
            }
        }
    }
}
