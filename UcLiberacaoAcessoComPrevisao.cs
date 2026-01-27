using System;
using System.Windows.Forms;

namespace NOC_Actions
{
    /// <summary>
    /// UserControl responsável por gerar mensagens de solicitação
    /// de liberação de acesso para técnicos, incluindo previsão de chegada.
    /// </summary>
    public partial class UcLiberacaoDeAcessoComPrevisao : UserControl
    {
        /// <summary>
        /// Construtor padrão do UserControl.
        /// Inicializa os componentes visuais definidos no Designer.
        /// </summary>
        public UcLiberacaoDeAcessoComPrevisao()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Monta a mensagem de notificação ao cliente com base
        /// nos dados técnicos informados e na previsão de chegada.
        /// </summary>
        /// <returns>
        /// Mensagem formatada pronta para envio ou cópia.
        /// </returns>
        private string GetCustomerNotificationMessage()
        {
            // Dados técnicos dos profissionais responsáveis
            string getDadosTecnicos = richTextBoxTechnicalData.Text.Trim();

            // Previsão de chegada dos técnicos ao local
            string getPrevisaoChegada = textBoxEstimatedArrival.Text.Trim();

            // Retorna a mensagem final formatada
            return
                "Prezados, é necessário acionar a loja para a liberação de acesso do(s) técnico(s) abaixo. " +
                "Previsão de chegada às " + getPrevisaoChegada + ". " +
                "Seguem os dados dos técnicos responsáveis pela solução do problema:" +
                Environment.NewLine + Environment.NewLine +
                getDadosTecnicos;
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
        /// Valida os campos e exibe a mensagem sem copiá-la.
        /// </summary>
        void BtnPreviewMessageClick(object sender, EventArgs e)
        {
            // Obtém os valores atuais dos campos
            string getDadosTecnicos = richTextBoxTechnicalData.Text.Trim();
            string getPrevisaoChegada = textBoxEstimatedArrival.Text.Trim();

            // Validação básica antes de gerar a prévia
            if (string.IsNullOrWhiteSpace(getDadosTecnicos) ||
                string.IsNullOrWhiteSpace(getPrevisaoChegada))
            {
                MessageBox.Show(
                    "Preencha todos os campos antes de ver a prévia.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Gera e exibe a prévia da mensagem
            string previa = GetCustomerNotificationMessage();
            MessageBox.Show(
                previa,
                "Prévia da Mensagem",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        /// <summary>
        /// Evento do botão de limpar campos.
        /// Remove os valores preenchidos no formulário.
        /// </summary>
        void BtnClearFieldsClick(object sender, EventArgs e)
        {
            ClearField();
        }

        /// <summary>
        /// Evento do botão de salvar e copiar.
        /// Gera a mensagem, copia para a área de transferência
        /// e limpa os campos do formulário.
        /// </summary>
        void BtnSaveAndCopyClick(object sender, EventArgs e)
        {
            string msn = GetCustomerNotificationMessage();
            Clipboard.SetText(msn);
            ClearField();
        }

        /// <summary>
        /// Limpa os campos utilizados para gerar a mensagem.
        /// </summary>
        void ClearField()
        {
            richTextBoxTechnicalData.Text = "";
            textBoxEstimatedArrival.Text = "";
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
