using System;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace NOC_Actions
{
    /// <summary>
    /// UserControl responsável por tratar cenários de possível queda de energia em unidades.
    /// Permite gerar mensagens padrão, salvar unidades em arquivo local
    /// e gerenciar a lista persistida (modo normal e modo edição).
    /// </summary>
    public partial class UcPossivelQuedaDeEnergia : UserControl
    {
        /// <summary>
        /// Caminho do arquivo utilizado para persistir as unidades
        /// com possível falta de energia no AppData do usuário.
        /// </summary>
        private readonly string UcPossivelQuedaDeEnergia_arquivoUnidadeComQuedaDeEnergia =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "arquivoUnidadeComQuedaDeEnergia.txt"
            );

        /// <summary>
        /// Construtor do UserControl.
        /// Inicializa os componentes visuais e carrega a lista persistida.
        /// </summary>
        public UcPossivelQuedaDeEnergia()
        {
            InitializeComponent();
            CarregarItensEmLista();
        }

        /// <summary>
        /// Monta a mensagem padrão de notificação ao cliente
        /// solicitando confirmação de possível queda de energia.
        /// </summary>
        private string GetCustomerNotificationMessage()
        {
            string getValueUnidadeComQueda =
                comboBox_UnidadeComFaltaDeEnergia.Text.Trim();

            const string msnValidacao =
                "Prezados, poderiam confirmar uma possível queda de energia na loja ";

            return msnValidacao
                   + getValueUnidadeComQueda.ToUpper()
                   + "? Constatamos que ambos os links encontram-se indisponíveis no momento.";
        }

        /// <summary>
        /// Salva a unidade informada no ComboBox caso ainda não exista,
        /// persistindo a lista atualizada em arquivo.
        /// </summary>
        private void SalvarItensArquivo()
        {
            string adicionarUnidadeComFaltaDeEnergiaEmLista =
                comboBox_UnidadeComFaltaDeEnergia.Text.Trim();

            // Evita persistir valores vazios ou duplicados
            if (!string.IsNullOrWhiteSpace(adicionarUnidadeComFaltaDeEnergiaEmLista) &&
                !comboBox_UnidadeComFaltaDeEnergia.Items.Contains(adicionarUnidadeComFaltaDeEnergiaEmLista))
            {
                comboBox_UnidadeComFaltaDeEnergia.Items.Add(adicionarUnidadeComFaltaDeEnergiaEmLista);

                GravarItensNoArquivo(
                    comboBox_UnidadeComFaltaDeEnergia,
                    UcPossivelQuedaDeEnergia_arquivoUnidadeComQuedaDeEnergia
                );

                // Limpa o campo após salvar
                comboBox_UnidadeComFaltaDeEnergia.Text = "";
            }
        }

        /// <summary>
        /// Carrega as unidades persistidas em arquivo
        /// para o ComboBox na inicialização do controle.
        /// </summary>
        private void CarregarItensEmLista()
        {
            if (File.Exists(UcPossivelQuedaDeEnergia_arquivoUnidadeComQuedaDeEnergia))
            {
                string[] unidade =
                    File.ReadAllLines(UcPossivelQuedaDeEnergia_arquivoUnidadeComQuedaDeEnergia);

                comboBox_UnidadeComFaltaDeEnergia.Items.AddRange(unidade);
            }
        }

        /// <summary>
        /// Grava todos os itens de um ComboBox em um arquivo texto.
        /// </summary>
        private void GravarItensNoArquivo(ComboBox comboBox, string caminhoArquivo)
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
        /// Ativa ou desativa o modo de edição avançada ("modo diretor"),
        /// permitindo exclusão de itens da lista persistida.
        /// </summary>
        void CheckEditarCampoUnidadeCheckedChanged(object sender, EventArgs e)
        {
            if (checkEditarCampoUnidade.Checked)
            {
                label_modoDiretorAtivado.Visible = true;
                labelAviso.Visible = true;

                btnPrevia.Enabled = false;
                btnClearFields.Enabled = false;
                btnSaveAndCopy.Enabled = false;

                labelAviso.Text =
                    "Deletar Lista: Esta ação apagará todos os itens da lista.\n" +
                    "Deletar Selecionado: Esta ação apagará apenas o item atualmente selecionado.";

                btnDeletarListaCompleta.Visible = true;
                btnDeletarItemSelecionadoDaLista.Visible = true;
            }
            else
            {
                label_modoDiretorAtivado.Visible = false;

                btnPrevia.Enabled = true;
                btnClearFields.Enabled = true;
                btnSaveAndCopy.Enabled = true;

                labelAviso.Visible = false;
                btnDeletarListaCompleta.Visible = false;
                btnDeletarItemSelecionadoDaLista.Visible = false;
            }
        }

        /// <summary>
        /// Remove o item selecionado da lista
        /// e atualiza o arquivo persistido.
        /// </summary>
        void BtnDeletarItemSelecionadoDaListaClick(object sender, EventArgs e)
        {
            if (comboBox_UnidadeComFaltaDeEnergia != null)
            {
                comboBox_UnidadeComFaltaDeEnergia.Items.Remove(
                    comboBox_UnidadeComFaltaDeEnergia.SelectedItem
                );

                GravarItensNoArquivo(
                    comboBox_UnidadeComFaltaDeEnergia,
                    UcPossivelQuedaDeEnergia_arquivoUnidadeComQuedaDeEnergia
                );
            }
        }

        /// <summary>
        /// Remove todos os itens da lista
        /// e reflete a alteração no arquivo persistido.
        /// </summary>
        void BtnDeletarListaCompletaClick(object sender, EventArgs e)
        {
            if (comboBox_UnidadeComFaltaDeEnergia.Items.Count > 0)
            {
                comboBox_UnidadeComFaltaDeEnergia.Items.Clear();

                GravarItensNoArquivo(
                    comboBox_UnidadeComFaltaDeEnergia,
                    UcPossivelQuedaDeEnergia_arquivoUnidadeComQuedaDeEnergia
                );
            }
        }

        /// <summary>
        /// Fecha o formulário pai que hospeda este UserControl.
        /// </summary>
        void BtnCloseWindowClick(object sender, EventArgs e)
        {
            CloseWindow();
        }

        /// <summary>
        /// Limpa o campo de unidade informada.
        /// </summary>
        void BtnClearFieldsClick(object sender, EventArgs e)
        {
            ClearField();
        }

        /// <summary>
        /// Exibe uma prévia da mensagem gerada,
        /// sem copiar ou salvar dados.
        /// </summary>
        void BtnPreviaClick(object sender, EventArgs e)
        {
            string msn_previa = GetCustomerNotificationMessage();

            MessageBox.Show(
                msn_previa,
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        /// <summary>
        /// Gera a mensagem, copia para a área de transferência,
        /// salva a unidade informada e limpa o campo.
        /// </summary>
        void BtnSaveAndCopyClick(object sender, EventArgs e)
        {
            string msn = GetCustomerNotificationMessage();
            Clipboard.SetText(msn);
            SalvarItensArquivo();
            ClearField();
        }

        /// <summary>
        /// Limpa o campo de texto do ComboBox.
        /// </summary>
        void ClearField()
        {
            comboBox_UnidadeComFaltaDeEnergia.Text = "";
        }

        /// <summary>
        /// Fecha o formulário pai.
        /// </summary>
        void CloseWindow()
        {
            this.FindForm().Close();
        }
    }
}
