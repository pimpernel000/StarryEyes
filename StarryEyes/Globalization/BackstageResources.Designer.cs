﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34014
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace StarryEyes.Globalization {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class BackstageResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal BackstageResources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("StarryEyes.Globalization.BackstageResources", typeof(BackstageResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
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
        ///   Account {0} is fallbacked to {1} due to post limit exceeded. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string FallbackFormat {
            get {
                return ResourceManager.GetString("FallbackFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Could not retrieve account information({0}). に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string GetAccountInfoFailedFormat {
            get {
                return ResourceManager.GetString("GetAccountInfoFailedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   {0} is post limited. release prediction: {1} に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string PostLimitFormat {
            get {
                return ResourceManager.GetString("PostLimitFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Theme profile {0} is not found. use default theme. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ProfileNotFoundFormat {
            get {
                return ResourceManager.GetString("ProfileNotFoundFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Tab {0} is initialized because query is corrupted: {1} に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string QueryCorruptedFormat {
            get {
                return ResourceManager.GetString("QueryCorruptedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Unknown data received({0}): {1} に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string StreamDecodeFailedFormat {
            get {
                return ResourceManager.GetString("StreamDecodeFailedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   {0} tweets had dropped. {1}&apos;s timeline is too fast. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string TrackLimitFormat {
            get {
                return ResourceManager.GetString("TrackLimitFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   New version of Krile is available. It will available on next start. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UpdateAvailable {
            get {
                return ResourceManager.GetString("UpdateAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   User Streams is disconnected({0}): {1} に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UserStreamDisconnectedFormat {
            get {
                return ResourceManager.GetString("UserStreamDisconnectedFormat", resourceCulture);
            }
        }
    }
}
