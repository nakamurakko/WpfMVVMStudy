using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Text;
using WpfMVVM.NotificationDialogs;

namespace WpfMVVM.NotificationDialogs
{
    /// <summary>
    /// NotificationDialog パラメーター用クラス。
    /// </summary>
    public sealed class NotificationDialogParam
    {
        /// <summary>
        /// コンストラクター。非公開。
        /// </summary>
        private NotificationDialogParam()
        {

        }

        /// <summary>
        /// ダイアログメッセージを設定した DialogParameters を生成する。
        /// </summary>
        /// <param name="message">ダイアログメッセージ。</param>
        /// <param name="dialogButtons">ダイアログに表示するボタン。</param>
        /// <returns>DialogParameters。</returns>
        public static DialogParameters CreateDialogMessageParam(string message, NotificationDialogButtons dialogButtons = NotificationDialogButtons.Ok)
        {
            var result = new DialogParameters();

            result.Add(NotificationDialogParamKey.DialogMessage, message);

            result.Add(NotificationDialogParamKey.DialogButtons, dialogButtons);

            return result;
        }
    }
}
