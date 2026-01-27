using System;
using System.IO;
using System.Windows.Forms;

namespace NOC_Actions
{
    /// <summary>
    /// UserControl responsável por registrar ocorrências internas.
    /// Permite criar, visualizar (via duplo clique), persistir e excluir registros
    /// utilizando armazenamento local em arquivo texto.
    /// </summary>
    public partial class UcRegistroDeOcorrenciaInterna : UserControl
    {
        /// <summary>
        /// Caminho do arquivo onde todas as ocorrências são persistidas.
        /// Utiliza a pasta AppData do usuário para evitar problemas de permissão.
        /// </summary>
        private readonly string arquivo_todas_as_informacoes =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "registroOcorrencias.txt"
            );

        /// <summary>
        /// Construtor do UserControl.
        /// Inicializa componentes, associa eventos e carrega registros persistidos.
        /// </summary>
        public UcRegistroDeOcorrenciaInterna()
        {
            InitializeComponent();

            // Associa o evento de duplo clique ao ListBox
            listBox_RegistroDeOcorrencia.MouseDoubleClick +=
                ListBox_RegistroDeOcorrencia_MouseDoubleClick;

            // Carrega os registros já existentes no arquivo
            LoadContentList();
        }

        /// <summary>
        /// Salva o registro informado nos campos,
        /// adiciona na lista visual e persiste no arquivo.
        /// </summary>
        void BtnSaveAndCopyClick(object sender, EventArgs e)
        {
            // Captura e normaliza os dados informados
            string textContratoUnidade = textBox_UnidadeContrato.Text.Trim();
            string textOperadoraDoContratoUnidade = textBox_OperadoraDaUnidade.Text.Trim();
            string textObservacaoContratoUnidade = textBox_observacaoDoContrato.Text.Trim();

            // Formato visual exibido no ListBox
            string itemList =
                "> Unidade: " + textContratoUnidade +
                " | Operadora/Designação: " + textOperadoraDoContratoUnidade +
                " | Observação: " + textObservacaoContratoUnidade;

            // Adiciona o item à lista visual
            listBox_RegistroDeOcorrencia.Items.Add(itemList);

            // Formato persistido no arquivo (simples e delimitado)
            string linhaArquivo =
                textContratoUnidade + "|" +
                textOperadoraDoContratoUnidade + "|" +
                textObservacaoContratoUnidade;

            // Acrescenta a nova ocorrência ao arquivo
            File.AppendAllText(
                arquivo_todas_as_informacoes,
                linhaArquivo + Environment.NewLine
            );
        }

        /// <summary>
        /// Exibe uma mensagem em popup com o conteúdo selecionado.
        /// </summary>
        void SelectedIndexOnListBoxToShowInformation(string message)
        {
            MessageBox.Show(message);
        }

        /// <summary>
        /// Evento de duplo clique no ListBox.
        /// Mostra os detalhes completos do item selecionado.
        /// </summary>
        void ListBox_RegistroDeOcorrencia_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox_RegistroDeOcorrencia.SelectedItem != null)
            {
                SelectedIndexOnListBoxToShowInformation(
                    listBox_RegistroDeOcorrencia.SelectedItem.ToString()
                );
            }
        }

        /// <summary>
        /// Carrega os registros persistidos no arquivo
        /// e os converte para o formato visual exibido no ListBox.
        /// </summary>
        void LoadContentList()
        {
            if (File.Exists(arquivo_todas_as_informacoes))
            {
                foreach (var linha in File.ReadAllLines(arquivo_todas_as_informacoes))
                {
                    // Cada linha é composta por 3 partes separadas por '|'
                    var partes = linha.Split('|');

                    if (partes.Length == 3)
                    {
                        string unidade = partes[0];
                        string operadora = partes[1];
                        string observacao = partes[2];

                        listBox_RegistroDeOcorrencia.Items.Add(
                            "> Contrato/unidade: " + unidade +
                            " | Operadora: " + operadora +
                            " | Observação: " + observacao
                        );
                    }
                }
            }
        }

        /// <summary>
        /// Remove o item selecionado do ListBox
        /// e regrava o arquivo com os registros restantes.
        /// </summary>
        void BtnDeletarSelecionadoClick(object sender, EventArgs e)
        {
            if (listBox_RegistroDeOcorrencia.SelectedItem == null)
            {
                MessageBox.Show("Nada selecionado. Tente novamente, por favor.");
                return;
            }

            // Remove o item selecionado da interface
            listBox_RegistroDeOcorrencia.Items.Remove(
                listBox_RegistroDeOcorrencia.SelectedItem
            );

            // Regrava todo o arquivo com base nos itens restantes
            using (StreamWriter writer =
                   new StreamWriter(arquivo_todas_as_informacoes, false))
            {
                foreach (var item in listBox_RegistroDeOcorrencia.Items)
                {
                    string linha = item.ToString();

                    // Reconstrói os dados removendo rótulos visuais
                    var partes = linha.Split('|');

                    if (partes.Length == 3)
                    {
                        string unidade =
                            partes[0]
                                .Replace("> Unidade:", "")
                                .Replace("> Contrato/unidade:", "")
                                .Trim();

                        string operadora =
                            partes[1].Replace("Operadora:", "").Trim();

                        string observacao =
                            partes[2].Replace("Observação:", "").Trim();

                        writer.WriteLine(
                            unidade + "|" + operadora + "|" + observacao
                        );
                    }
                }
            }
        }

        /// <summary>
        /// Remove todos os registros da lista e do arquivo,
        /// após confirmação explícita do usuário.
        /// </summary>
        void BtnDeletarListaClick(object sender, EventArgs e)
        {
            if (listBox_RegistroDeOcorrencia == null)
            {
                MessageBox.Show("A lista já se encontra vazia!");
                return;
            }

            var confirm = MessageBox.Show(
                "Deseja realmente apagar TUDO?\nEsta ação não poderá ser desfeita.",
                "Confirmar Exclusão Completa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                listBox_RegistroDeOcorrencia.Items.Clear();
                File.WriteAllText(arquivo_todas_as_informacoes, "");
                MessageBox.Show("Todos os registros foram deletados com sucesso.");
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
        /// Encerra a janela atual.
        /// </summary>
        void CloseWindow()
        {
            this.FindForm().Close();
        }
    }
}
