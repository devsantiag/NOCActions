using System;
using System.Windows.Forms;

namespace NOC_Actions
{
    /// <summary>
    /// UserControl responsável por gerar mensagens de solicitação
    /// de liberação de acesso para técnicos **sem previsão de chegada**.
    /// Utilizado quando a operadora/fornecedor ainda não informou o horário.
    /// </summary>
    public partial class UcLiberacaoDeAcessoSemPrevisao : UserControl
    {
        /// <summary>
        /// Construtor padrão do UserControl.
        /// Inicializa os componentes visuais definidos no Designer.
        /// </summary>
        public UcLiberacaoDeAcessoSemPrevisao()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Monta a mensagem padrão de notificação ao cliente
        /// informando a necessidade de liberação de acesso,
        /// sem previsão de chegada definida.
        /// </summary>
        /// <returns>
        /// Mensagem formatada pronta para envio ou cópia.
        /// </returns>
        private string GetCustomerNotificationMessage()
        {
            return
                "Prezados, é necessário acionar a loja para a liberação de acesso do(s) técnico(s) listados abaixo. " +
                "Ainda não recebemos a previsão de chegada; assim que obtivermos essa informação, atualizaremos a thread."
                + Environment.NewLine + Environment.NewLine
                + richTextBoxTechDetails.Text;
        }

        /// <summary>
        /// Evento do botão de fechar.
        /// Fecha o formulário pai que contém este UserControl.
        /// </summary>
        void BtnCloseWindowClick(object sender, EventArgs e)
        {
            CloseWindow();
        }

        /// <summary>
        /// Evento do botão de pré-visualização da mensagem.
        /// Exibe a mensagem gerada sem copiá-la.
        /// </summary>
        void BtnMessagePreviewClick(object sender, EventArgs e)
        {
            string msn = GetCustomerNotificationMessage();
            MessageBox.Show(msn, "Prévia da Mensagem");
        }

        /// <summary>
        /// Evento do botão de limpar campos.
        /// Remove os dados informados no formulário.
        /// </summary>
        void BtnClearFieldsClick(object sender, EventArgs e)
        {
            ClearField();
        }

        /// <summary>
        /// Evento do botão de salvar e copiar.
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
        /// Limpa os campos utilizados para a geração da mensagem.
        /// </summary>
        void ClearField()
        {
            richTextBoxTechDetails.Text = "";
        }

        /// <summary>
        /// Fecha o formulário pai que hospeda este UserControl.
        /// </summary>
        void CloseWindow()
        {
            this.FindForm().Close();
        }
    }
}
