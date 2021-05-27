using System;
using System.Collections.Generic;
using System.Text;

namespace WpfMVVM.NotificationDialogs
{
    /// <summary>
    /// NotificationDialog 
    /// </summary>
    public sealed class NotificationDialogParamKey
    {
        /// <summary>
        /// ダイアログに表示するメッセージ。
        /// </summary>
        public static string DialogMessage = nameof(DialogMessage);

        /// <summary>
        /// ダイアログに表示するボタン。
        /// </summary>
        public static string DialogButtons = nameof(DialogButtons);

        /// <summary>
        /// コンストラクター。非公開。
        /// </summary>
        private NotificationDialogParamKey()
        {

        }
    }
}
