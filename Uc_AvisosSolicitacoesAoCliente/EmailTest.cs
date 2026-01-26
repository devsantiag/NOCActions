using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace NOC_Actions.Uc_AvisosSolicitacoesAoCliente
{
    public partial class EmailTest : Form
    {
        private Outlook.Application outlookApp;
        private Outlook.NameSpace outlookNs;
        private Outlook.MAPIFolder inbox;

        private Timer timer;
        private DateTime lastCheck;
        private HashSet<string> processedMailIds;

        public EmailTest()
        {
            InitializeComponent();

            processedMailIds = new HashSet<string>();
            lastCheck = DateTime.Now.AddMinutes(-1);

            listBoxMostrarEmails.Items.Add("🟢 Monitor de e-mails iniciado");

            StartOutlookListener();
        }

        private void StartOutlookListener()
        {
            outlookApp = new Outlook.Application();
            outlookNs = outlookApp.GetNamespace("MAPI");
            inbox = outlookNs.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox);

            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                string filter =
                    "[ReceivedTime] >= '" + lastCheck.ToString("g") + "'";

                Outlook.Items items = inbox.Items.Restrict(filter);
                items.Sort("[ReceivedTime]", true);

                foreach (object obj in items)
                {
                    Outlook.MailItem mail = obj as Outlook.MailItem;
                    if (mail == null)
                        continue;

                    string entryId = mail.EntryID;

                    if (processedMailIds.Contains(entryId))
                        continue;

                    processedMailIds.Add(entryId);
                    ProcessMail(mail);
                }

                if (processedMailIds.Count > 1000)
                    processedMailIds.Clear();

                lastCheck = DateTime.Now;
            }
            catch
            {
                // Outlook COM é instável — nunca deixar cair o app
            }
        }

        private void ProcessMail(Outlook.MailItem mail)
        {
            try
            {
                string subject = mail.Subject ?? "";
                string sender = mail.SenderEmailAddress ?? "desconhecido";
                string receivedBy = GetReceivedByEmail(mail);

                // 🔒 Filtro da conta
                if (!receivedBy.Equals(
                    "fjstavares@telecomsa.com.br",
                    StringComparison.OrdinalIgnoreCase))
                    return;

                // 🔍 Filtro do assunto (NET Framework)
                if (subject.IndexOf("ALERTA", StringComparison.OrdinalIgnoreCase) < 0)
                    return;

                BeginInvoke((MethodInvoker)(() =>
                {
                    string item =
                        $"[{mail.ReceivedTime:HH:mm:ss}] {subject} | {sender}";

                    listBoxMostrarEmails.Items.Insert(0, item);

                    if (listBoxMostrarEmails.Items.Count > 300)
                        listBoxMostrarEmails.Items.RemoveAt(300);
                }));
            }
            catch
            {
                // nunca matar o listener
            }
        }

        private string GetReceivedByEmail(Outlook.MailItem mail)
        {
            try
            {
                const string PR_RECEIVED_BY_EMAIL_ADDRESS =
                    "http://schemas.microsoft.com/mapi/proptag/0x0076001E";

                object value = mail.PropertyAccessor.GetProperty(
                    PR_RECEIVED_BY_EMAIL_ADDRESS);

                return value != null ? value.ToString() : "";
            }
            catch
            {
                return "";
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Tick -= Timer_Tick;
            }

            base.OnFormClosing(e);
        }
    }
}
