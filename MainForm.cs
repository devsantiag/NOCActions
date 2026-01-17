using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NOC_Actions.Uc_AvisosSolicitacoesAoCliente;

namespace NOC_Actions
{
    public partial class MainForm : Form
    {
        #region Win32 - Drag Window

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(
            IntPtr hWnd,
            int Msg,
            int wParam,
            int lParam
        );

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        #endregion

        // Janelas controladas
        private InterfaceClienteInformes informesWindow;
        private AvisosSolicitacoesAoCliente avisosWindow;
        private MassivaForm massivaWindow;
        private WebForm webFormWindow;

        public MainForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;

            PointerMouseMove.MouseDown += PointerMouseMovePaint_MouseDown;
        }

        private void PointerMouseMovePaint_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        // ===============================
        // CLIPBOARD
        // ===============================

        private void SemEnergiaClick(object sender, EventArgs e)
        {
            Clipboard.SetText(
                "Sem contato com a unidade. Devido queda simultânea dos links, possível queda de energia."
            );
        }

        private void ButtonSemContatoLocalClick(object sender, EventArgs e)
        {
            Clipboard.SetText(
                "Sem contato do local, solicitado auxílio do Cliente na validação interna."
            );
        }

        private void ButtonSemExpedienteClick(object sender, EventArgs e)
        {
            Clipboard.SetText(
                "Devido expediente do cliente, manteremos o link em monitoração até o próximo dia útil."
            );
        }

        private void ButtonInfraOkClienteClick(object sender, EventArgs e)
        {
            Clipboard.SetText(
                "Cliente informa que unidade está com energia e Internet, será acionado fornecedor para verificação do alarme."
            );
        }

        private void ButtonSemContatoOperadoraClick(object sender, EventArgs e)
        {
            Clipboard.SetText(
                "Sem contato com a Operadora, tentaremos novamente mais tarde."
            );
        }

        private void ButtonAberturaDeOsClick(object sender, EventArgs e)
        {
            Clipboard.SetText(
                "Encaminhado e-mail solicitando abertura de chamado ao fornecedor."
            );
        }

        private void ButtonPosicionamentoTecnicoClick(object sender, EventArgs e)
        {
            Clipboard.SetText(
                "Encaminhado e-mail solicitando posicionamento frente ao reparo em aberto junto ao fornecedor."
            );
        }

        // ===============================
        // JANELAS
        // ===============================

        private void BtnAberturaDeMassivaClick(object sender, EventArgs e)
        {
            if (massivaWindow == null || massivaWindow.IsDisposed)
            {
                massivaWindow = new MassivaForm();
                massivaWindow.FormClosed += (s, args) => massivaWindow = null;
                massivaWindow.Show();
            }
            else
            {
                massivaWindow.BringToFront();
            }
        }

        private void BtnInformesClientesClick(object sender, EventArgs e)
        {
            if (informesWindow != null && !informesWindow.IsDisposed)
            {
                informesWindow.Close();
                btnInformesClientes.Text = "Informes";
                return;
            }

            informesWindow = new InterfaceClienteInformes();
            informesWindow.FormClosed += (s, args) =>
            {
                informesWindow = null;
                btnInformesClientes.Text = "Informes";
            };

            informesWindow.Show();
            btnInformesClientes.Text = "Fechar";
        }

        private void BtnAvisoSolicitacoesClick(object sender, EventArgs e)
        {
            if (avisosWindow != null && !avisosWindow.IsDisposed)
            {
                avisosWindow.Close();
                btnAvisoSolicitacoes.Text = "Avisos / Solicitações";
                return;
            }

            avisosWindow = new AvisosSolicitacoesAoCliente();
            avisosWindow.FormClosed += (s, args) =>
            {
                avisosWindow = null;
                btnAvisoSolicitacoes.Text = "Avisos / Solicitações";
            };

            avisosWindow.Show();
            btnAvisoSolicitacoes.Text = "Fechar";
        }

        private void BtnCentralNoc(object sender, EventArgs e)
        {
            if (webFormWindow == null || webFormWindow.IsDisposed)
            {
                webFormWindow = new WebForm();
                webFormWindow.FormClosed += (s, args) => webFormWindow = null;
                webFormWindow.Show();
            }
            else
            {
                webFormWindow.BringToFront();
            }
        }
    }
}
