using System;
using System.Collections.Generic;
using System.Text;

namespace WpfMVVM.Dialogs
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
        /// コンストラクター。非公開。
        /// </summary>
        private NotificationDialogParamKey()
        {

        }
    }
}
