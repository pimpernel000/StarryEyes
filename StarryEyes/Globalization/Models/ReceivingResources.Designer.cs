﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34014
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace StarryEyes.Globalization.Models {
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
    internal class ReceivingResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ReceivingResources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("StarryEyes.Globalization.Models.ReceivingResources", typeof(ReceivingResources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Could not receive list timeline due to account is not registered. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string AccountIsNotRegisteredForList {
            get {
                return ResourceManager.GetString("AccountIsNotRegisteredForList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Could not receive search timeline due to account is not registered. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string AccountIsNotRegisteredForSearch {
            get {
                return ResourceManager.GetString("AccountIsNotRegisteredForSearch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Could not connect user streams. (Network Error) に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ConnectFailedByNetwork {
            get {
                return ResourceManager.GetString("ConnectFailedByNetwork", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Could not connect user streams. (Protocol Error) に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ConnectFailedByProtocol {
            get {
                return ResourceManager.GetString("ConnectFailedByProtocol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Could not authorize you. Check system clock is correct. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string DisconnectedAuthError {
            get {
                return ResourceManager.GetString("DisconnectedAuthError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Could not connect to endpoint. Access is denied? に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string DisconnectedEndpointError {
            get {
                return ResourceManager.GetString("DisconnectedEndpointError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Too many User Stream session is connected. Please close other clients. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string DisconnectedLimitError {
            get {
                return ResourceManager.GetString("DisconnectedLimitError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Too many network errors occured. Twitter service disruption? に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string DisconnectedNetworkError {
            get {
                return ResourceManager.GetString("DisconnectedNetworkError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Too many protocol errors occured. Twitter service disruption? に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string DisconnectedProtocolError {
            get {
                return ResourceManager.GetString("DisconnectedProtocolError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Could not connect stream. Permission denied or out of range. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string DisconnectedRangeError {
            get {
                return ResourceManager.GetString("DisconnectedRangeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Tracking keyword too long or invalid. (keywords: {0}) に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string DisconnectedTrackErrorFormat {
            get {
                return ResourceManager.GetString("DisconnectedTrackErrorFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Account is not specified for receiving list {0}. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string MsgListReceiveErrorContentFormat {
            get {
                return ResourceManager.GetString("MsgListReceiveErrorContentFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   When receiving list created by someone(not yourself), you have to specify account explicitly for receiving list.
        ///ex: list: &quot;receiver/user/listname&quot; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string MsgListReceiveErrorExInfo {
            get {
                return ResourceManager.GetString("MsgListReceiveErrorExInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Could not start receiving list. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string MsgListReceiveErrorInst {
            get {
                return ResourceManager.GetString("MsgListReceiveErrorInst", resourceCulture);
            }
        }
        
        /// <summary>
        ///   List receiving error. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string MsgListReceiveErrorTitle {
            get {
                return ResourceManager.GetString("MsgListReceiveErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Receive failed: {0} に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ReceiveFailedFormat {
            get {
                return ResourceManager.GetString("ReceiveFailedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Direct messages({0}) に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ReceiverDirectMessageFormat {
            get {
                return ResourceManager.GetString("ReceiverDirectMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Home({0}) に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ReceiverHomeFormat {
            get {
                return ResourceManager.GetString("ReceiverHomeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   List info({0}) に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ReceiverListInfoFormat {
            get {
                return ResourceManager.GetString("ReceiverListInfoFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   List({0}) に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ReceiverListTimelineFormat {
            get {
                return ResourceManager.GetString("ReceiverListTimelineFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Replies({0}) に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ReceiverMentionFormat {
            get {
                return ResourceManager.GetString("ReceiverMentionFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Follow and follower info({0}) に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ReceiverRelationFormat {
            get {
                return ResourceManager.GetString("ReceiverRelationFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Search({0}) に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ReceiverSearchFormat {
            get {
                return ResourceManager.GetString("ReceiverSearchFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   User info({0}) に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ReceiverUserInfoFormat {
            get {
                return ResourceManager.GetString("ReceiverUserInfoFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   User({0}) に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ReceiverUserTimelineFormat {
            get {
                return ResourceManager.GetString("ReceiverUserTimelineFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Receiving: {0} に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ReceivingFormat {
            get {
                return ResourceManager.GetString("ReceivingFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Try to reconnect User Streams... (waiting {0} ms) に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ReconnectingFormat {
            get {
                return ResourceManager.GetString("ReconnectingFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   User streams is disconnected. (code: {0}, error: {1}) に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string UserStreamDisconnectedFormat {
            get {
                return ResourceManager.GetString("UserStreamDisconnectedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Reconnecting user streams... に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string UserStreamReconnecting {
            get {
                return ResourceManager.GetString("UserStreamReconnecting", resourceCulture);
            }
        }
    }
}
