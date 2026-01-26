using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NOC_Actions.Uc_AvisosSolicitacoesAoCliente;

namespace NOC_Actions
{
    /// <summary>
    /// Form principal do NOC, responsável por gerenciar:
    /// - A interface principal do usuário
    /// - Janelas filhas (Avisos, Massiva, WebForm, Informes)
    /// - Funções de Clipboard rápidas para mensagens padrões
    /// - Drag da janela sem borda (Win32)
    /// </summary>
    public partial class MainForm : Form
    {
        #region Win32 - Drag Window

        // Importações do Win32 para permitir mover janela sem borda
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(
            IntPtr hWnd,
            int Msg,
            int wParam,
            int lParam
        );

        // Constantes necessárias para o SendMessage
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        #endregion

        #region Janelas Filhas

        // Referências das janelas filhas para controle de instâncias
        private InterfaceClienteInformes informesWindow;
        private AvisosSolicitacoesAoCliente avisosWindow;
        private MassivaForm massivaWindow;
        private WebForm webFormWindow;

        #endregion

        #region Construtor

        public MainForm()
        {
            InitializeComponent();

            // Configuração de aparência: sem borda e sempre no topo
            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;

            // Evento de arrastar a janela clicando no painel PointerMouseMove
            PointerMouseMove.MouseDown += PointerMouseMovePaint_MouseDown;
        }

        #endregion

        #region Win32 Drag Handler

        /// <summary>
        /// Permite arrastar a janela clicando com o botão esquerdo do mouse
        /// no painel PointerMouseMove.
        /// </summary>
        private void PointerMouseMovePaint_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Libera captura do mouse e envia mensagem para mover janela
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        #endregion

        #region Clipboard - Mensagens Rápidas

        // Funções que copiam textos padrão para o clipboard.
        // Cada botão tem um texto específico para situações de NOC.

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

        #endregion

        #region Janelas - Gerenciamento e Instâncias

        /// <summary>
        /// Abre ou traz para frente a janela de Massiva.
        /// </summary>
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

        /// <summary>
        /// Abre ou fecha a janela de Informes de Clientes.
        /// </summary>
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

        /// <summary>
        /// Abre ou fecha a janela de Avisos e Solicitações ao Cliente.
        /// </summary>
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

        /// <summary>
        /// Abre ou traz para frente a janela de WebForm.
        /// </summary>
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

        #endregion
    
    }
}
