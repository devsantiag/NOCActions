using System;
using System.IO;
using System.Windows.Forms;

namespace NOC_Actions
{
    /// <summary>
    /// Formulário para geração de mensagens de possíveis interrupções em massa (massiva),
    /// com base em cidades e operadoras previamente cadastradas pelo usuário.
    /// </summary>
    public partial class MassivaForm : Form
    {
        #region Campos de Persistência

        // Caminho do arquivo de operadoras no AppData do usuário
        private string caminhoArquivoOperadoras = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "operadoras.txt"
        );

        // Caminho do arquivo de cidades no AppData do usuário
        private string caminhoArquivoCidades = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "cidades.txt"
        );

        #endregion

        #region Construtor

        /// <summary>
        /// Inicializa o formulário e carrega listas de cidades e operadoras salvas.
        /// </summary>
        public MassivaForm()
        {
            InitializeComponent();
            CarregarOperadorasSalvasNoForm();
            CarregarCidadesSalvasNoForm();
        }

        #endregion

        #region Carregamento de Dados

        /// <summary>
        /// Carrega as cidades armazenadas no arquivo e atualiza o ComboBox no formulário.
        /// </summary>
        private void CarregarCidadesSalvasNoForm()
        {
            if (File.Exists(caminhoArquivoCidades))
            {
                string[] cidadesSalvas = File.ReadAllLines(caminhoArquivoCidades);
                CidadesSalvasPeloUsuario(cidadesSalvas);
            }
        }

        /// <summary>
        /// Carrega as operadoras armazenadas no arquivo e atualiza o ComboBox no formulário.
        /// </summary>
        private void CarregarOperadorasSalvasNoForm()
        {
            if (File.Exists(caminhoArquivoOperadoras))
            {
                string[] operadorasSalvas = File.ReadAllLines(caminhoArquivoOperadoras);
                OperadorasSalvasPeloUsuario(operadorasSalvas);
            }
        }

        #endregion

        #region Atualização de UI

        /// <summary>
        /// Atualiza a lista de cidades no ComboBox com os valores fornecidos.
        /// Seleciona a primeira cidade como padrão se houver dados.
        /// </summary>
        public void CidadesSalvasPeloUsuario(string[] cidades)
        {
            textBoxCidades.Items.Clear();
            textBoxCidades.Items.AddRange(cidades);
            if (textBoxCidades.Items.Count > 0)
            {
                textBoxCidades.SelectedIndex = 0; // Seleção padrão
            }
        }

        /// <summary>
        /// Atualiza a lista de operadoras no ComboBox com os valores fornecidos.
        /// Seleciona a primeira operadora como padrão se houver dados.
        /// </summary>
        public void OperadorasSalvasPeloUsuario(string[] operadoras)
        {
            textBoxOperadora.Items.Clear();
            textBoxOperadora.Items.AddRange(operadoras);
            if (textBoxOperadora.Items.Count > 0)
            {
                textBoxOperadora.SelectedIndex = 0; // Seleção padrão
            }
        }

        #endregion

        #region Geração de Mensagem

        /// <summary>
        /// Evento do botão "Gerar", dispara a criação da mensagem de massiva.
        /// </summary>
        private void BtnGerarClick(object sender, EventArgs e)
        {
            GerarMensagemDeMassiva();
        }

        /// <summary>
        /// Gera uma mensagem informando possível interrupção em massa
        /// com base na cidade e operadora selecionadas pelo usuário.
        /// </summary>
        private void GerarMensagemDeMassiva()
        {
            textBoxExemplo.Clear();

            string cidadeAfetada = textBoxCidades.Text.Trim();
            string operadoraAfetada = textBoxOperadora.Text.Trim();

            // Validação de campos obrigatórios
            if (string.IsNullOrWhiteSpace(cidadeAfetada) || string.IsNullOrWhiteSpace(operadoraAfetada))
            {
                MessageBox.Show(
                    "Por favor, preencha as informações de cidade e operadora antes de gerar a mensagem.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Cria mensagem formatada
            string mensagemDeMassiva = string.Format(
                "Possível massiva na região de {0} devido a ambos os links da {1} caírem simultaneamente.",
                cidadeAfetada,
                operadoraAfetada
            );

            textBoxExemplo.Text = mensagemDeMassiva;
        }

        #endregion

        #region Copiar e Apagar Campos

        /// <summary>
        /// Copia o texto gerado para a área de transferência e limpa os campos.
        /// </summary>
        private void ButtonCopiarClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxExemplo.Text))
            {
                Clipboard.SetText(textBoxExemplo.Text);
                clearField();
            }
        }

        /// <summary>
        /// Limpa todos os campos do formulário.
        /// </summary>
        private void BtnApagarClick(object sender, EventArgs e)
        {
            clearField();
        }

        /// <summary>
        /// Limpa ComboBoxes e TextBox de exemplo.
        /// </summary>
        private void clearField()
        {
            textBoxCidades.Text = string.Empty;
            textBoxOperadora.Text = string.Empty;
            textBoxExemplo.Clear();
        }

        #endregion

        #region Configurações do Usuário

        /// <summary>
        /// Abre a janela de configuração para seleção de arquivos personalizados.
        /// Após selecionar arquivos válidos, recarrega listas de cidades e operadoras.
        /// </summary>
        private void BtnUserInformationsConfigClick(object sender, EventArgs e)
        {
            using (UserConfig config = new UserConfig())
            {
                config.ShowDialog();

                if (!string.IsNullOrEmpty(config.CaminhoArquivo) && File.Exists(config.CaminhoArquivo))
                {
                    CarregarCidadesSalvasNoForm();
                    CarregarOperadorasSalvasNoForm();
                }
            }
        }

        #endregion

    }
}
