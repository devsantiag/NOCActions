using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NOC_Actions
{
    /// <summary>
    /// UserControl responsável pela abertura de reparo
    /// e geração de mensagens de notificação ao cliente.
    /// </summary>
    public partial class UcAberturaDeReparo : UserControl
    {
        /// <summary>
        /// Construtor padrão do UserControl.
        /// Inicializa os componentes visuais definidos no designer.
        /// </summary>
        public UcAberturaDeReparo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Monta a mensagem padrão de notificação ao cliente
        /// com base nos dados informados na interface.
        /// </summary>
        /// <returns>
        /// String formatada contendo o número do chamado
        /// e o horário de registro junto ao fornecedor.
        /// </returns>
        private string GetCustomerNotificationMessage()
        {
            // Obtém o número do chamado informado pelo operador
            string getNumeroChamado = txtOperatorCallID.Text.Trim();

            // Obtém o horário de registro do chamado
            string getHorarioDeRegistro = textBoxCallRegistrationTime.Text.Trim();

            // Retorna a mensagem final formatada para envio ao cliente
            return "Prezados, o chamado "
                   + getNumeroChamado.ToUpper()
                   + " foi registrado às "
                   + getHorarioDeRegistro
                   + " junto ao fornecedor.";
        }

        /// <summary>
        /// Evento acionado ao clicar no botão de fechar.
        /// Fecha a janela (Form) que contém este UserControl.
        /// </summary>
        void BtnCloseWindowClick(object sender, EventArgs e)
        {
            CloseWindow();
        }

        /// <summary>
        /// Evento acionado ao clicar no botão de limpar campos.
        /// Remove os valores informados nos campos de entrada.
        /// </summary>
        void BtnClearFieldsClick(object sender, EventArgs e)
        {
            ClearField();
        }

        /// <summary>
        /// Evento acionado ao clicar no botão de salvar e copiar.
        /// Gera a mensagem, copia para a área de transferência
        /// e limpa os campos da tela.
        /// </summary>
        void BtnSaveAndCopyClick(object sender, EventArgs e)
        {
            string msn = GetCustomerNotificationMessage();
            Clipboard.SetText(msn);
            ClearField();
        }

        /// <summary>
        /// Evento acionado ao clicar no botão de pré-visualização.
        /// Exibe a mensagem gerada em uma janela de diálogo.
        /// </summary>
        void BtnPreviaMsnClick(object sender, EventArgs e)
        {
            string msnDetalhar = GetCustomerNotificationMessage();
            MessageBox.Show(msnDetalhar);
        }

        /// <summary>
        /// Limpa os campos de entrada utilizados para
        /// geração da mensagem de notificação.
        /// </summary>
        void ClearField()
        {
            txtOperatorCallID.Text = "";
            textBoxCallRegistrationTime.Text = "";
        }

        /// <summary>
        /// Fecha o formulário pai que contém este UserControl.
        /// </summary>
        void CloseWindow()
        {
            this.FindForm().Close();
        }
    }
}
