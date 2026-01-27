using System;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace NOC_Actions
{
    /// <summary>
    /// UserControl responsável por gerar informes de pendência financeira
    /// relacionados a unidades com bloqueio administrativo-financeiro.
    /// Permite salvar, carregar e gerenciar unidades persistidas em arquivo local.
    /// </summary>
    public partial class UcPendenciaFinanceiraInformes : UserControl
    {
        /// <summary>
        /// Caminho do arquivo responsável por persistir as unidades
        /// com pendência financeira no AppData do usuário.
        /// </summary>
        private readonly string UcPendenciaFinanceiraInformes_arquivoUnidadeComPendenciaFinanceira =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "arquivoUnidadeComPendenciaFinanceira.txt"
            );

        /// <summary>
        /// Construtor do UserControl.
        /// Inicializa os componentes visuais e carrega os itens persistidos.
        /// </summary>
        public UcPendenciaFinanceiraInformes()
        {
            InitializeComponent();
            CarregarItens();
        }

        /// <summary>
        /// Exibe dinamicamente um UserControl dentro deste controle,
        /// substituindo o conteúdo atual.
        /// </summary>
        private void MostrarUserControl(UserControl uc)
        {
            this.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        /// <summary>
        /// Monta a mensagem padrão de notificação ao cliente
        /// referente à pendência financeira da unidade selecionada.
        /// </summary>
        private string GetCustomerNotificationMessage()
        {
            return "Prezados, identificamos a existência de um bloqueio de caráter administrativo-financeiro no contrato da unidade: "
                   + comboBoxUnidadeComPendenciaFinanceira.Text.Trim().ToUpper();
        }

        /// <summary>
        /// Salva a unidade informada no ComboBox em arquivo,
        /// caso ainda não exista na lista persistida.
        /// </summary>
        private void EncaminhandoESalvandoConteudosNoArquivo()
        {
            string salvarArquivoDeUnidadeComPendenciaFinanceira =
                comboBoxUnidadeComPendenciaFinanceira.Text.Trim();

            // Evita salvar valores vazios ou duplicados
            if (!string.IsNullOrWhiteSpace(salvarArquivoDeUnidadeComPendenciaFinanceira) &&
                !comboBoxUnidadeComPendenciaFinanceira.Items.Contains(salvarArquivoDeUnidadeComPendenciaFinanceira))
            {
                comboBoxUnidadeComPendenciaFinanceira.Items.Add(salvarArquivoDeUnidadeComPendenciaFinanceira);
                SalvarItensArquivo(
                    comboBoxUnidadeComPendenciaFinanceira,
                    UcPendenciaFinanceiraInformes_arquivoUnidadeComPendenciaFinanceira
                );
            }
        }

        /// <summary>
        /// Persiste todos os itens de um ComboBox em um arquivo texto.
        /// </summary>
        private void SalvarItensArquivo(ComboBox comboBox, string caminhoArquivo)
        {
            try
            {
                File.WriteAllLines(caminhoArquivo, comboBox.Items.Cast<string>());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao realizar este procedimento. \n\n" + ex.ToString(),
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        /// <summary>
        /// Carrega os itens persistidos em arquivo para o ComboBox.
        /// </summary>
        private void CarregarItens()
        {
            if (File.Exists(UcPendenciaFinanceiraInformes_arquivoUnidadeComPendenciaFinanceira))
            {
                string[] unidadeComPendencia =
                    File.ReadAllLines(UcPendenciaFinanceiraInformes_arquivoUnidadeComPendenciaFinanceira);

                comboBoxUnidadeComPendenciaFinanceira.Items.AddRange(unidadeComPendencia);
            }
        }

        /// <summary>
        /// Fecha o formulário pai que contém este UserControl.
        /// </summary>
        void BtnCloseWindowClick(object sender, EventArgs e)
        {
            CloseWindow();
        }

        /// <summary>
        /// Limpa o campo de unidade selecionada.
        /// </summary>
        void BtnClearFieldsClick(object sender, EventArgs e)
        {
            ClearField();
        }

        /// <summary>
        /// Remove o item atualmente selecionado do ComboBox
        /// e atualiza o arquivo persistido.
        /// </summary>
        void BtnDeletarItemSelecionadoDaListaClick(object sender, EventArgs e)
        {
            if (comboBoxUnidadeComPendenciaFinanceira != null)
            {
                comboBoxUnidadeComPendenciaFinanceira.Items.Remove(
                    comboBoxUnidadeComPendenciaFinanceira.SelectedItem
                );

                SalvarItensArquivo(
                    comboBoxUnidadeComPendenciaFinanceira,
                    UcPendenciaFinanceiraInformes_arquivoUnidadeComPendenciaFinanceira
                );
            }
        }

        /// <summary>
        /// Remove todos os itens do ComboBox
        /// e reflete a alteração no arquivo persistido.
        /// </summary>
        void BtnDeletarListaCompletaClick(object sender, EventArgs e)
        {
            if (comboBoxUnidadeComPendenciaFinanceira.Items.Count > 0)
            {
                comboBoxUnidadeComPendenciaFinanceira.Items.Clear();
                SalvarItensArquivo(
                    comboBoxUnidadeComPendenciaFinanceira,
                    UcPendenciaFinanceiraInformes_arquivoUnidadeComPendenciaFinanceira
                );
            }
        }

        /// <summary>
        /// Gera a mensagem, copia para a área de transferência,
        /// salva a unidade informada e limpa os campos.
        /// </summary>
        void BtnSaveAndCopyClick(object sender, EventArgs e)
        {
            string msn = GetCustomerNotificationMessage();
            Clipboard.SetText(msn);
            EncaminhandoESalvandoConteudosNoArquivo();
            ClearField();
        }

        /// <summary>
        /// Ativa ou desativa o modo de detalhamento da fatura,
        /// ajustando a interface e exibindo avisos ao usuário.
        /// </summary>
        void checkBoxDetalharFatura_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDetalharFatura.Checked)
            {
                btnClearFields.Enabled = false;
                btnSaveAndCopy.Enabled = false;
                labelEditarCampoUnidade.Visible = false;
                checkEditarCampoUnidade.Visible = false;
                txtLabel_campoDeAviso.Visible = true;
                btnDeletarListaCompleta.Visible = false;
                btnDeletarItemSelecionadoDaLista.Visible = false;

                txtLabel_campoDeAviso.Location = new System.Drawing.Point(38, 224);
                btnViewInvoiceDetails.Enabled = true;

                txtLabel_campoDeAviso.Text =
                    "Aviso: ao clicar em “Detalhar a Fatura”, você receberá informações\n" +
                    "adicionais para serem incluídas. Isso pode gerar inconsistências em\n" +
                    "valores, datas e outros dados. Tenha cuidado ao preencher todos os\n" +
                    "campos e revise cuidadosamente as informações inseridas.";
            }
            else
            {
                btnClearFields.Enabled = true;
                btnSaveAndCopy.Enabled = true;
                labelEditarCampoUnidade.Visible = true;
                checkEditarCampoUnidade.Visible = true;
                btnViewInvoiceDetails.Enabled = false;
                txtLabel_campoDeAviso.Visible = false;
            }
        }

        /// <summary>
        /// Ativa o modo de edição avançada ("modo diretor"),
        /// permitindo exclusão de itens da lista persistida.
        /// </summary>
        void CheckEditarCampoUnidadeCheckedChanged(object sender, EventArgs e)
        {
            if (checkEditarCampoUnidade.Checked)
            {
                label_modoDiretorAtivado.Visible = true;
                btnSaveAndCopy.Enabled = false;
                btnClearFields.Enabled = false;
                btnViewInvoiceDetails.Enabled = false;
                btnDeletarListaCompleta.Visible = true;
                btnDeletarItemSelecionadoDaLista.Visible = true;

                txtLabel_campoDeAviso.Location = new System.Drawing.Point(34, 242);
                txtLabel_campoDeAviso.Visible = true;
                txtLabel_campoDeAviso.Text =
                    "Deletar Lista: Esta ação apagará todos os itens da lista.\n" +
                    "Deletar Selecionado: Esta ação apagará apenas o item atualmente\n" +
                    "selecionado.";
            }
            else
            {
                label_modoDiretorAtivado.Visible = false;
                btnSaveAndCopy.Enabled = true;
                btnClearFields.Enabled = true;
                btnViewInvoiceDetails.Enabled = true;
                btnDeletarListaCompleta.Visible = false;
                btnDeletarItemSelecionadoDaLista.Visible = false;
                txtLabel_campoDeAviso.Visible = false;
            }
        }

        /// <summary>
        /// Abre o UserControl responsável por detalhar a fatura do cliente.
        /// </summary>
        void BtnViewInvoiceDetailsClick(object sender, EventArgs e)
        {
            MostrarUserControl(new UcDetalharFaturaDoCliente());
        }

        /// <summary>
        /// Limpa o campo de unidade selecionada.
        /// </summary>
        void ClearField()
        {
            comboBoxUnidadeComPendenciaFinanceira.Text = "";
        }

        /// <summary>
        /// Fecha o formulário pai que hospeda este UserControl.
        /// </summary>
        void CloseWindow()
        {
            this.FindForm().Close();
        }

        /// <summary>
        /// Evento de carregamento do UserControl.
        /// Reservado para inicializações futuras.
        /// </summary>
        void UcPendenciaFinanceiraInformesLoad(object sender, EventArgs e)
        {
        }
    }
}
