﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrozzleApplication {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class WordListErrors {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal WordListErrors() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CrozzleApplication.WordListErrors", typeof(WordListErrors).Assembly);
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
        ///   Looks up a localized string similar to code 10001: non-alphabetic value ({0}) in field &apos;{1}&apos; of the wordlist.
        /// </summary>
        internal static string AlphabeticError {
            get {
                return ResourceManager.GetString("AlphabeticError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to code 10010: total sum of {0} does not match its validated total of {1}.
        /// </summary>
        internal static string IncorrectBatchAsciiSumError {
            get {
                return ResourceManager.GetString("IncorrectBatchAsciiSumError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to code 10011: total hash total of {0} does not match its validated total of {1}.
        /// </summary>
        internal static string IncorrectBatchHashTotalError {
            get {
                return ResourceManager.GetString("IncorrectBatchHashTotalError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to code 10009: total length of {0} does not match its validated total of {1}.
        /// </summary>
        internal static string IncorrectBatchLengthError {
            get {
                return ResourceManager.GetString("IncorrectBatchLengthError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to code 10008: total score of {0} does not match its validated total of {1}.
        /// </summary>
        internal static string IncorrectBatchScoreError {
            get {
                return ResourceManager.GetString("IncorrectBatchScoreError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to code 10004: the wordlist size ({0}) is more than the expected maximum ({1}).
        /// </summary>
        internal static string MaximumSizeError {
            get {
                return ResourceManager.GetString("MaximumSizeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to code 10003: the wordlist size ({0}) is less than the expected minimum ({1}).
        /// </summary>
        internal static string MinimumSizeError {
            get {
                return ResourceManager.GetString("MinimumSizeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to code 10002: missing word in field &apos;{0}&apos; of the wordlist.
        /// </summary>
        internal static string MissingWordError {
            get {
                return ResourceManager.GetString("MissingWordError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to code 10006: ASCII sum does not match its pre-determined sum in field &apos;{0}&apos; of the wordlist.
        /// </summary>
        internal static string NonIdenticalAsciiSumError {
            get {
                return ResourceManager.GetString("NonIdenticalAsciiSumError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to code 10007: hash total does not match its pre-determined total in field &apos;{0}&apos; of the wordlist.
        /// </summary>
        internal static string NonIdenticalHashTotalError {
            get {
                return ResourceManager.GetString("NonIdenticalHashTotalError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to code 10005: word length does not match its pre-determined length in field &apos;{0}&apos; of the wordlist.
        /// </summary>
        internal static string NonIdenticalLengthError {
            get {
                return ResourceManager.GetString("NonIdenticalLengthError", resourceCulture);
            }
        }
    }
}
