using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NOC_Actions
{
    /// <summary>
    /// Formulário de configuração do usuário.
    /// Permite adicionar, remover e salvar cidades e operadoras.
    /// </summary>
    public partial class UserConfig : Form
    {
        #region Campos de Persistência

        // Caminho do arquivo onde as operadoras serão salvas no AppData do usuário
        private string caminhoArquivo = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "operadoras.txt"
        );

        // Caminho do arquivo onde as cidades serão salvas no AppData do usuário
        private string caminhoArquivo1 = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "cidades.txt"
        );

        // Propriedade pública para acessar o caminho do arquivo de operadoras
        public string CaminhoArquivo { get { return caminhoArquivo; } }

        #endregion

        #region Construtor

        /// <summary>
        /// Inicializa o formulário e carrega dados salvos.
        /// </summary>
        public UserConfig()
        {
            InitializeComponent();
            CarregarOperadoraSalvas();
            CarregarCidadeSalvas();
        }

        #endregion

        #region Eventos de Botões

        /// <summary>
        /// Adiciona uma nova operadora
        /// </summary>
        void BtnAdicionarOperadoraClick(object sender, EventArgs e)
        {
            AdicionarOperadora();
        }

        /// <summary>
        /// Deleta a operadora selecionada
        /// </summary>
        void BtnDeletarOperadoraClick(object sender, EventArgs e)
        {
            DeletarOperadoraListada();
        }

        /// <summary>
        /// Adiciona uma nova cidade
        /// </summary>
        void ButtonAdicionarCidadeClick(object sender, EventArgs e)
        {
            AdicionarCidade();
        }

        /// <summary>
        /// Deleta a cidade selecionada
        /// </summary>
        void ButtonDeletarCidadeClick(object sender, EventArgs e)
        {
            DeletarCidadeAdicionada();
        }

        #endregion

        #region Operações com Cidades

        /// <summary>
        /// Adiciona uma nova cidade à lista e salva no arquivo.
        /// </summary>
        private void AdicionarCidade()
        {
            string adicionarCidadeEmLista = textBoxAdicionarCidade.Text.Trim();

            // Evita duplicatas ou campos vazios
            if (!string.IsNullOrWhiteSpace(adicionarCidadeEmLista) &&
                !comboBoxCidadeAdicionada.Items.Contains(adicionarCidadeEmLista))
            {
                comboBoxCidadeAdicionada.Items.Add(adicionarCidadeEmLista);
                textBoxAdicionarCidade.Clear();
                SalvarCidadeNoArquivo();
            }
            else
            {
                MessageBox.Show(
                    "Essa Cidade já foi adicionada ou o campo está vazio.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        /// <summary>
        /// Salva todas as cidades do ComboBox no arquivo de persistência.
        /// </summary>
        private void SalvarCidadeNoArquivo()
        {
            try
            {
                File.WriteAllLines(caminhoArquivo1, comboBoxCidadeAdicionada.Items.Cast<string>());
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
        /// Remove a cidade selecionada após confirmação e atualiza o arquivo.
        /// </summary>
        private void DeletarCidadeAdicionada()
        {
            if (comboBoxCidadeAdicionada.SelectedItem == null)
            {
                MessageBox.Show(
                    "Por favor, selecione uma cidade para excluir.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var resultadoDeConfirmacao = MessageBox.Show(
                "Você tem certeza que deseja excluir esta cidade?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultadoDeConfirmacao == DialogResult.Yes)
            {
                comboBoxCidadeAdicionada.Items.Remove(comboBoxCidadeAdicionada.SelectedItem);
                SalvarCidadeNoArquivo();
            }
        }

        #endregion

        #region Operações com Operadoras

        /// <summary>
        /// Adiciona uma nova operadora à lista evitando duplicatas.
        /// </summary>
        private void AdicionarOperadora()
        {
            string adicionarOperadoraEmLista = textBoxAdicionarOperadora.Text.Trim();

            if (!string.IsNullOrWhiteSpace(adicionarOperadoraEmLista) &&
                !comboBoxOperadoraJaAdicionadas.Items.Contains(adicionarOperadoraEmLista))
            {
                comboBoxOperadoraJaAdicionadas.Items.Add(adicionarOperadoraEmLista);
                textBoxAdicionarOperadora.Clear();
                SalvarOperadorasNoArquivo();
            }
            else
            {
                MessageBox.Show(
                    "Essa operadora já foi adicionada ou o campo está vazio.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        /// <summary>
        /// Salva todas as operadoras do ComboBox no arquivo de persistência.
        /// </summary>
        private void SalvarOperadorasNoArquivo()
        {
            try
            {
                File.WriteAllLines(caminhoArquivo, comboBoxOperadoraJaAdicionadas.Items.Cast<string>());
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
        /// Remove a operadora selecionada após confirmação e atualiza o arquivo.
        /// </summary>
        private void DeletarOperadoraListada()
        {
            if (comboBoxOperadoraJaAdicionadas.SelectedItem == null)
            {
                MessageBox.Show(
                    "Por favor, selecione uma operadora para excluir.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var resultadoDeConfirmacao = MessageBox.Show(
                "Você tem certeza que deseja excluir esta operadora?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultadoDeConfirmacao == DialogResult.Yes)
            {
                comboBoxOperadoraJaAdicionadas.Items.Remove(comboBoxOperadoraJaAdicionadas.SelectedItem);
                SalvarOperadorasNoArquivo();
            }
        }

        #endregion

        #region Carregamento Inicial

        /// <summary>
        /// Carrega operadoras salvas no arquivo para o ComboBox ao abrir o formulário.
        /// </summary>
        private void CarregarOperadoraSalvas()
        {
            if (File.Exists(caminhoArquivo))
            {
                string[] operadorasSalvas = File.ReadAllLines(caminhoArquivo);
                comboBoxOperadoraJaAdicionadas.Items.AddRange(operadorasSalvas);
            }
        }

        /// <summary>
        /// Carrega cidades salvas no arquivo para o ComboBox ao abrir o formulário.
        /// </summary>
        private void CarregarCidadeSalvas()
        {
            if (File.Exists(caminhoArquivo1))
            {
                string[] cidadesSalvas = File.ReadAllLines(caminhoArquivo1);
                comboBoxCidadeAdicionada.Items.AddRange(cidadesSalvas);
            }
        }

        #endregion

    }
}
