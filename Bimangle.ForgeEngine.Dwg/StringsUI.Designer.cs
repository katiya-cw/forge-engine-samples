﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bimangle.ForgeEngine.Dwg.CLI {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class StringsUI {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringsUI() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Bimangle.ForgeEngine.Dwg.CLI.StringsUI", typeof(StringsUI).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 Command call is blocked, please close security software, or set trust and try again! 的本地化字符串。
        /// </summary>
        internal static string CommandCallIsBlocked {
            get {
                return ResourceManager.GetString("CommandCallIsBlocked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The input file does not exist! 的本地化字符串。
        /// </summary>
        internal static string InputFileNotExist {
            get {
                return ResourceManager.GetString("InputFileNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The input file path valid! 的本地化字符串。
        /// </summary>
        internal static string InputFileValid {
            get {
                return ResourceManager.GetString("InputFileValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Please select the input file first. 的本地化字符串。
        /// </summary>
        internal static string SelectInputFileFirst {
            get {
                return ResourceManager.GetString("SelectInputFileFirst", resourceCulture);
            }
        }
    }
}
