using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace NOC_Actions
{
    /// <summary>
    /// UserControl responsável por registrar e notificar
    /// indisponibilidade de link de operadora.
    /// Inclui persistência local das operadoras utilizadas.
    /// </summary>
    public partial class UcAlarmeDeLinkIndisponivel : UserControl
    {
        /// <summary>
        /// Caminho do arquivo utilizado para persistir
        /// a lista de operadoras informadas pelo usuário.
        /// O arquivo é salvo na pasta AppData do usuário.
        /// </summary>
        private readonly string Uc_AlarmeDeLinkIndisponivel_arquivoOperadora =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "registroDeOperadoraEmArquivo.txt"
            );

        /// <summary>
        /// Construtor padrão do UserControl.
        /// Inicializa componentes visuais e carrega
        /// os dados persistidos no ComboBox.
        /// </summary>
        public UcAlarmeDeLinkIndisponivel()
        {
            InitializeComponent();
            CarregarComboBoxItems();
        }

        /// <summary>
        /// Retorna uma saudação adequada com base
        /// no horário atual do sistema.
        /// </summary>
        /// <returns>
        /// "bom dia", "boa tarde" ou "boa noite"
        /// </returns>
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
        /// Monta a mensagem padrão de notificação
        /// ao cliente sobre indisponibilidade de link.
        /// </summary>
        /// <returns>
        /// Mensagem formatada pronta para envio/copiar.
        /// </returns>
        private string GetCustomerNotificationMessage()
        {
            // Nome da operadora selecionada
            string getValueCarrierName = comboBoxCarrierName.Text;

            // Horário informado da queda do link
            string getValueHorario_Queda = textBoxDowntime.Text;

            // Retorna a mensagem final formatada
            return "Prezados, " + ObterSaudacao() +
                   "! Identificamos que o link da operadora " +
                   getValueCarrierName +
                   " está indisponível às " +
                   getValueHorario_Queda +
                   ". Daremos sequência ao acionamento junto ao fornecedor.";
        }

        /// <summary>
        /// Salva a operadora informada no ComboBox
        /// e persiste a lista no arquivo local.
        /// Evita duplicidades e valores inválidos.
        /// </summary>
        private void SalvarArquivoOperadoraDoCliente()
        {
            string adicionarOperadoraDoClienteEmLista =
                comboBoxCarrierName.Text.Trim();

            // Valida se o valor é válido e não existe na lista
            if (!string.IsNullOrWhiteSpace(adicionarOperadoraDoClienteEmLista) &&
                !comboBoxCarrierName.Items.Contains(adicionarOperadoraDoClienteEmLista))
            {
                comboBoxCarrierName.Items.Add(adicionarOperadoraDoClienteEmLista);
                comboBoxCarrierName.Text = "";

                // Persiste os itens no arquivo
                RegistrarNoArquivo(
                    comboBoxCarrierName,
                    Uc_AlarmeDeLinkIndisponivel_arquivoOperadora
                );
            }
        }

        /// <summary>
        /// Registra todos os itens de um ComboBox
        /// em um arquivo de texto.
        /// </summary>
        private void RegistrarNoArquivo(ComboBox comboBox, string caminhoArquivo)
        {
            try
            {
                File.WriteAllLines(
                    caminhoArquivo,
                    comboBox.Items.Cast<string>()
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao realizar este procedimento.\n\n" + ex,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        /// <summary>
        /// Carrega os itens persistidos no arquivo
        /// para o ComboBox ao iniciar o UserControl.
        /// </summary>
        private void CarregarComboBoxItems()
        {
            if (File.Exists(Uc_AlarmeDeLinkIndisponivel_arquivoOperadora))
            {
                string[] itens =
                    File.ReadAllLines(Uc_AlarmeDeLinkIndisponivel_arquivoOperadora);

                comboBoxCarrierName.Items.AddRange(itens);
            }
        }

        /// <summary>
        /// Remove apenas o item atualmente selecionado
        /// no ComboBox e atualiza o arquivo.
        /// </summary>
        private void DeletarInformesSelecionado()
        {
            if (comboBoxCarrierName.SelectedItem == null)
            {
                MessageBox.Show("Nenhum item selecionado para excluir.");
                return;
            }

            string itemSelecionado =
                comboBoxCarrierName.SelectedItem.ToString();

            comboBoxCarrierName.Items.Remove(itemSelecionado);

            // Atualiza o arquivo com os itens restantes
            File.WriteAllLines(
                Uc_AlarmeDeLinkIndisponivel_arquivoOperadora,
                comboBoxCarrierName.Items.Cast<string>()
            );

            MessageBox.Show("Item removido com sucesso!");
        }

        /// <summary>
        /// Remove todos os itens do ComboBox
        /// e limpa completamente o arquivo.
        /// </summary>
        private void DeletarListaDeInformesCompleta()
        {
            if (comboBoxCarrierName.Items.Count == 0)
            {
                MessageBox.Show("A lista já está vazia.");
                return;
            }

            // Confirmação explícita para ação destrutiva
            if (MessageBox.Show(
                    "Deseja realmente apagar toda a lista?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                ) == DialogResult.Yes)
            {
                comboBoxCarrierName.Items.Clear();
                File.WriteAllText(
                    Uc_AlarmeDeLinkIndisponivel_arquivoOperadora,
                    ""
                );

                MessageBox.Show("Lista completamente apagada!");
            }
        }

        /// <summary>
        /// Evento do botão para deletar todos os itens.
        /// </summary>
        void BtnDeletarTodosOsItensSelecionadosDaListaClick(object sender, EventArgs e)
        {
            DeletarListaDeInformesCompleta();
        }

        /// <summary>
        /// Evento do botão para deletar apenas o item selecionado.
        /// </summary>
        void BtnDeletarItemSelecionadoDaListaClick(object sender, EventArgs e)
        {
            DeletarInformesSelecionado();
        }

        /// <summary>
        /// Fecha o formulário pai que contém este UserControl.
        /// </summary>
        void BtnCloseWindowClick(object sender, EventArgs e)
        {
            CloseWindow();
        }

        /// <summary>
        /// Limpa os campos de entrada do formulário.
        /// </summary>
        void BtnClearFieldsClick(object sender, EventArgs e)
        {
            ClearField();
        }

        /// <summary>
        /// Gera a mensagem, copia para a área de transferência,
        /// salva a operadora e limpa os campos.
        /// </summary>
        void BtnSaveAndCopyClick(object sender, EventArgs e)
        {
            string msn = GetCustomerNotificationMessage();
            Clipboard.SetText(msn);

            SalvarArquivoOperadoraDoCliente();
            ClearField();
        }

        /// <summary>
        /// Limpa os campos utilizados na geração da mensagem.
        /// </summary>
        void ClearField()
        {
            comboBoxCarrierName.Text = "";
            textBoxDowntime.Text = "";
        }

        /// <summary>
        /// Fecha o formulário pai.
        /// </summary>
        void CloseWindow()
        {
            this.FindForm().Close();
        }

        /// <summary>
        /// Ativa o modo de exclusão (modo diretor).
        /// </summary>
        void CheckBox1CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Sim.Checked)
            {
                DesativarElementosNoFormTemporariamente(true);
            }
        }

        /// <summary>
        /// Desativa o modo de exclusão.
        /// </summary>
        void CheckBox2CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Não.Checked)
            {
                checkBox_Sim.Checked = false;
                DesativarElementosNoFormTemporariamente(false);
            }
        }

        /// <summary>
        /// Habilita ou desabilita elementos do formulário
        /// conforme o modo de operação (normal ou exclusão).
        /// </summary>
        private void DesativarElementosNoFormTemporariamente(bool modoAtivo)
        {
            if (modoAtivo)
            {
                checkBox_Não.Checked = false;

                // Ativa botões destrutivos
                btnDeletarItemSelecionadoDaLista.Enabled = true;
                btnDeletarTodosOsItensSelecionadosDaLista.Enabled = true;

                // Exibe avisos e bloqueia ações normais
                labelModoDiretor.Visible = true;
                btnSaveAndCopy.Enabled = false;
                btnClearFields.Enabled = false;
                btnPrevia.Enabled = false;
                textBoxDowntime.Enabled = false;

                labelAvisoDeUso.Visible = true;
                labelAvisoDeUso.Text =
                    "Deletar Lista: Esta ação apagará todos os itens da lista.\n" +
                    "Deletar Selecionado: Esta ação apagará apenas o item atualmente\n" +
                    "selecionado.";
            }
            else
            {
                // Retorna ao modo normal
                checkBox_Sim.Checked = false;

                btnDeletarItemSelecionadoDaLista.Enabled = false;
                btnDeletarTodosOsItensSelecionadosDaLista.Enabled = false;

                labelModoDiretor.Visible = false;
                labelAvisoDeUso.Visible = false;

                btnSaveAndCopy.Enabled = true;
                btnClearFields.Enabled = true;
                btnPrevia.Enabled = true;
                textBoxDowntime.Enabled = true;
            }
        }
    }
}
