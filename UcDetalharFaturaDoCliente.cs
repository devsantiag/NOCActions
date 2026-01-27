using System;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace NOC_Actions
{
    /// <summary>
    /// UserControl responsável por detalhar informações de fatura
    /// associadas a pendência administrativa-financeira de um cliente.
    /// Possui persistência local de dados auxiliares para reutilização.
    /// </summary>
    public partial class UcDetalharFaturaDoCliente : UserControl
    {
        /// <summary>
        /// Arquivo que armazena as unidades com pendência financeira.
        /// </summary>
        private readonly string arquivo_unidadeComPendenciaFinanceira =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "unidadeComPendenciaFinanceira.txt"
            );

        /// <summary>
        /// Arquivo que armazena as operadoras responsáveis
        /// pelo bloqueio do serviço.
        /// </summary>
        private readonly string arquivo_operadoraQueBloqueouOServico =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "operadoraQueBloqueouOServico.txt"
            );

        /// <summary>
        /// Arquivo que armazena os possíveis status do contrato/fatura.
        /// </summary>
        private readonly string arquivo_statusDoContrato =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "statusDoContrato.txt"
            );

        /// <summary>
        /// Construtor do UserControl.
        /// Inicializa os componentes, configura o estado inicial
        /// dos controles e carrega dados persistidos.
        /// </summary>
        public UcDetalharFaturaDoCliente()
        {
            InitializeComponent();

            // Garante exclusividade entre as opções de edição
            if (checkBox_PermitirEdicaoSim.Checked)
            {
                checkBox_PermitirEdicaoNao.Checked = false;
            }

            // Carrega os dados persistidos para os ComboBox
            CarregarItensNoForm(arquivo_unidadeComPendenciaFinanceira, comboBox_UnidadeASerNotificada);
            CarregarItensNoForm(arquivo_operadoraQueBloqueouOServico, comboBox_TipoDeOperadoraDoContrato);
            CarregarItensNoForm(arquivo_statusDoContrato, comboBox_StatusDaFatura);
        }

        /// <summary>
        /// Exibe dinamicamente um UserControl dentro do atual,
        /// substituindo o conteúdo existente.
        /// </summary>
        private void MostrarUserControl(UserControl uc)
        {
            this.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        /// <summary>
        /// Retorna uma saudação de acordo com o horário atual.
        /// </summary>
        private string ObterSaudacao()
        {
            int hora = DateTime.Now.Hour;

            if (hora >= 5 && hora < 12)
                return "bom dia";
            else if (hora >= 12 && hora < 18)
                return "boa tarde";
            else
                return "boa noite";
        }

        /// <summary>
        /// Verifica se todos os campos obrigatórios estão vazios.
        /// Utilizado como validação antes de gerar a mensagem.
        /// </summary>
        private bool AnaliseDeCamposVazios()
        {
            return
                string.IsNullOrWhiteSpace(comboBox_UnidadeASerNotificada.Text) &&
                string.IsNullOrWhiteSpace(comboBox_TipoDeOperadoraDoContrato.Text) &&
                string.IsNullOrWhiteSpace(richTextBox_ObservacaoDaFatura.Text) &&
                string.IsNullOrWhiteSpace(maskedTextBox_ValorDaFatura.Text) &&
                string.IsNullOrWhiteSpace(maskedTextBox_VencimentoFatura.Text) &&
                string.IsNullOrWhiteSpace(comboBox_StatusDaFatura.Text) &&
                string.IsNullOrWhiteSpace(textBox_CodigoDeBarrasDaFatura.Text);
        }

        /// <summary>
        /// Monta o texto detalhado da fatura para comunicação
        /// com o cliente ou áreas internas.
        /// </summary>
        private string DetalhamentoDeFatura()
        {
            if (AnaliseDeCamposVazios())
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
                return string.Empty;
            }

            // Mensagem introdutória
            string msn =
                "Prezados, " + ObterSaudacao() + "," + Environment.NewLine +
                "Informamos que foi identificado um bloqueio de caráter administrativo-financeiro no contrato da unidade " +
                comboBox_UnidadeASerNotificada.Text.ToUpper() + "." + Environment.NewLine +
                "A seguir, seguem os detalhes referentes à situação:" + Environment.NewLine + Environment.NewLine;

            // Detalhamento da fatura
            string detalheFatura =
                "Operadora: " + comboBox_TipoDeOperadoraDoContrato.Text + Environment.NewLine +
                "Valor da Fatura: " + maskedTextBox_ValorDaFatura.Text + Environment.NewLine +
                "Data de Vencimento: " + maskedTextBox_VencimentoFatura.Text + Environment.NewLine +
                "Código de Pagamento: " + textBox_CodigoDeBarrasDaFatura.Text + Environment.NewLine +
                "Status: " + comboBox_StatusDaFatura.Text + Environment.NewLine +
                "Observações: " + richTextBox_ObservacaoDaFatura.Text + Environment.NewLine +
                "Religamento por inadimplemento: " + CheckReliguePorConfianca();

            return msn + detalheFatura;
        }

        /// <summary>
        /// Retorna a descrição do status de religamento por confiança.
        /// </summary>
        private string CheckReliguePorConfianca()
        {
            if (religuePorConfianca_Sim.Checked)
            {
                religuePorConfianca_Nao.Checked = false;
                return "O procedimento de religamento por confiança foi realizado pela operadora.";
            }
            else if (religuePorConfianca_Nao.Checked)
            {
                religuePorConfianca_Sim.Checked = false;
                return "O procedimento de religamento por confiança não foi realizado pela operadora.";
            }

            return "O status do religamento por confiança não foi definido.";
        }

        /// <summary>
        /// Adiciona um novo valor ao ComboBox e persiste no arquivo,
        /// evitando duplicidades.
        /// </summary>
        private void AdicionarAoArquivo(ComboBox comboBox, string valorAdicionado)
        {
            string valor = comboBox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(valor) && !comboBox.Items.Contains(valor))
            {
                comboBox.Items.Add(valor);
                comboBox.Text = "";
                SalvarNoArquivo(comboBox, valorAdicionado);
            }
        }

        /// <summary>
        /// Salva todos os itens de um ComboBox em um arquivo.
        /// </summary>
        private void SalvarNoArquivo(ComboBox comboBox, string arquivoCaminho)
        {
            try
            {
                File.WriteAllLines(arquivoCaminho, comboBox.Items.Cast<string>());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao salvar os dados: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Carrega itens de um arquivo de texto para um ComboBox.
        /// </summary>
        private void CarregarItensNoForm(string arquivoTxt, ComboBox comboBox)
        {
            if (File.Exists(arquivoTxt))
            {
                comboBox.Items.Clear();
                comboBox.Items.AddRange(File.ReadAllLines(arquivoTxt));
            }
        }

        /// <summary>
        /// Remove apenas o item selecionado e atualiza o arquivo.
        /// </summary>
        private void DeletarInformesSelecionado(ComboBox comboBox, string arquivoTxt)
        {
            if (comboBox.SelectedItem == null)
            {
                MessageBox.Show("Nenhum item selecionado para excluir.");
                return;
            }

            comboBox.Items.Remove(comboBox.SelectedItem);
            File.WriteAllLines(arquivoTxt, comboBox.Items.Cast<string>());
            MessageBox.Show("Item removido com sucesso!");
        }

        /// <summary>
        /// Remove todos os itens do ComboBox e limpa o arquivo.
        /// </summary>
        private void DeletarListaDeInformesCompleta(ComboBox comboBox, string arquivoTxt)
        {
            if (comboBox.Items.Count == 0)
            {
                MessageBox.Show("A lista já está vazia.");
                return;
            }

            if (MessageBox.Show(
                    "Deseja realmente apagar toda a lista?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                ) == DialogResult.Yes)
            {
                comboBox.Items.Clear();
                File.WriteAllText(arquivoTxt, string.Empty);
                MessageBox.Show("Lista completamente apagada!");
            }
        }

        /// <summary>
        /// Remove o item selecionado de todas as listas.
        /// </summary>
        void BtnDeletarItemSelecionadoNaListaClick(object sender, EventArgs e)
        {
            DeletarInformesSelecionado(comboBox_UnidadeASerNotificada, arquivo_unidadeComPendenciaFinanceira);
            DeletarInformesSelecionado(comboBox_TipoDeOperadoraDoContrato, arquivo_operadoraQueBloqueouOServico);
            DeletarInformesSelecionado(comboBox_StatusDaFatura, arquivo_statusDoContrato);
        }

        /// <summary>
        /// Apaga completamente todas as listas persistidas.
        /// </summary>
        void BtnDeletarListaClick(object sender, EventArgs e)
        {
            DeletarListaDeInformesCompleta(comboBox_UnidadeASerNotificada, arquivo_unidadeComPendenciaFinanceira);
            DeletarListaDeInformesCompleta(comboBox_TipoDeOperadoraDoContrato, arquivo_operadoraQueBloqueouOServico);
            DeletarListaDeInformesCompleta(comboBox_StatusDaFatura, arquivo_statusDoContrato);
        }

        /// <summary>
        /// Exibe uma prévia da mensagem gerada.
        /// </summary>
        void BtnPreviaClick(object sender, EventArgs e)
        {
            MessageBox.Show(DetalhamentoDeFatura());
        }

        /// <summary>
        /// Retorna para a tela anterior.
        /// </summary>
        void BtnVoltarClick(object sender, EventArgs e)
        {
            MostrarUserControl(new UcPendenciaFinanceiraInformes());
        }

        /// <summary>
        /// Salva os dados auxiliares, copia a mensagem
        /// e limpa os campos do formulário.
        /// </summary>
        void BtnGravarECopiarInformacoesDetalhadasClick(object sender, EventArgs e)
        {
            AdicionarAoArquivo(comboBox_UnidadeASerNotificada, arquivo_unidadeComPendenciaFinanceira);
            AdicionarAoArquivo(comboBox_TipoDeOperadoraDoContrato, arquivo_operadoraQueBloqueouOServico);
            AdicionarAoArquivo(comboBox_StatusDaFatura, arquivo_statusDoContrato);

            Clipboard.SetText(DetalhamentoDeFatura());
            LimparCampos();
        }

        /// <summary>
        /// Ativa o modo de edição restrita (modo diretor).
        /// </summary>
        void CheckBox_PermitirEdicaoSimCheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_PermitirEdicaoSim.Checked)
            {
                checkBox_PermitirEdicaoNao.Checked = false;
                label_modoDiretorAtivado.Visible = true;
                DesabilitarComponentesQuandoOModoEditorForAtivado(true);
            }
        }

        /// <summary>
        /// Desativa o modo de edição restrita.
        /// </summary>
        void CheckBox_PermitirEdicaoNaoCheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_PermitirEdicaoNao.Checked)
            {
                checkBox_PermitirEdicaoSim.Checked = false;
                label_modoDiretorAtivado.Visible = false;
                DesabilitarComponentesQuandoOModoEditorForAtivado(false);
            }
        }

        /// <summary>
        /// Habilita ou desabilita componentes conforme
        /// o modo de edição ativo.
        /// </summary>
        void DesabilitarComponentesQuandoOModoEditorForAtivado(bool modoAtivo)
        {
            btnDeletarItemSelecionadoNaLista.Enabled = modoAtivo;
            btnDeletarLista.Enabled = modoAtivo;

            richTextBox_ObservacaoDaFatura.Enabled = !modoAtivo;
            maskedTextBox_ValorDaFatura.Enabled = !modoAtivo;
            maskedTextBox_VencimentoFatura.Enabled = !modoAtivo;
            textBox_CodigoDeBarrasDaFatura.Enabled = !modoAtivo;

            btnPrevia.Enabled = !modoAtivo;
            btnApagarOsCampos.Enabled = !modoAtivo;
            btnGravarECopiarInformacoesDetalhadas.Enabled = !modoAtivo;

            religuePorConfianca_Sim.Enabled = !modoAtivo;
            religuePorConfianca_Nao.Enabled = !modoAtivo;
        }

        /// <summary>
        /// Garante seleção exclusiva do religamento por confiança.
        /// </summary>
        void ReliguePorConfianca_SimCheckedChanged(object sender, EventArgs e)
        {
            if (religuePorConfianca_Sim.Checked)
                religuePorConfianca_Nao.Checked = false;
        }

        /// <summary>
        /// Garante seleção exclusiva do religamento por confiança.
        /// </summary>
        void ReliguePorConfianca_NaoCheckedChanged(object sender, EventArgs e)
        {
            if (religuePorConfianca_Nao.Checked)
                religuePorConfianca_Sim.Checked = false;
        }

        /// <summary>
        /// Limpa todos os campos do formulário.
        /// </summary>
        void LimparCampos()
        {
            comboBox_UnidadeASerNotificada.Text = "";
            comboBox_TipoDeOperadoraDoContrato.Text = "";
            richTextBox_ObservacaoDaFatura.Text = "";
            maskedTextBox_ValorDaFatura.Text = "";
            maskedTextBox_VencimentoFatura.Text = "";
            comboBox_StatusDaFatura.Text = "";
            textBox_CodigoDeBarrasDaFatura.Text = "";
        }
    }
}