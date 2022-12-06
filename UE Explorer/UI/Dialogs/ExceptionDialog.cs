﻿using System;
using System.Net;
using System.Web;
using System.Windows.Forms;
using Eliot.Utilities.Net;
using UEExplorer.Properties;

namespace UEExplorer.UI.Dialogs
{
    public partial class ExceptionDialog : Form
    {
        private ExceptionDialog()
        {
            InitializeComponent();
        }

        public static void Show(string error, Exception exception)
        {
            using (var exceptionDialog = new ExceptionDialog())
            {
                exceptionDialog.ExceptionStack.Text =
                    string.Format(Resources.ExceptionText,
                        exception.TargetSite.Name,
                        exception.StackTrace,
                        exception.InnerException);
                exceptionDialog.ExceptionError.Text = error;
                if (exceptionDialog.ShowDialog() == DialogResult.OK)
                {
                    exceptionDialog.SendReport();
                }
            }
        }

        private void SendReport()
        {
            using (var sendDialog = new SendDialog())
            {
                if (sendDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                string logData = " exception:\r\n<code>"
                                 + ExceptionMessage.Text + "</code>\r\n\r\nStack:\r\n<code>"
                                 + ExceptionStack.Text;

                string postData = "data[reports][log]=" + HttpUtility.UrlEncode(logData)
                                                        + "&data[reports][title]=" +
                                                        HttpUtility.UrlEncode(ExceptionError.Text)
                                                        + "&data[reports][description]=" +
                                                        HttpUtility.UrlEncode(sendDialog.InfoText.Text)
                                                        + "&data[reports][reporter_email]=" +
                                                        HttpUtility.UrlEncode(sendDialog.Email.Text);

                try
                {
                    WebRequest
                        .Create(Program.SubmitReportUrl)
                        .Post(postData);
                    MessageBox.Show(Resources.ExceptionDialog_THANKS,
                        Resources.SUCCESS, MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                }
                catch
                {
                    MessageBox.Show(Resources.ExceptionDialog_FAIL,
                        Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                }
            }
        }
    }
}
