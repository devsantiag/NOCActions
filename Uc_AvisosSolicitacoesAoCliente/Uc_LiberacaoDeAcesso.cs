using NOC_Actions.Uc_AvisosSolicitacoesAoCliente;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NOC_Actions
{
    public partial class Uc_LiberacaoDeAcesso : UserControl
    {
        #region Arquivos (Persistência)

        private static readonly string AppData =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        private readonly string arquivoOperadoraSolicitacaoVisita =
            Path.Combine(AppData, "operadoraSolicitacaoVisita.txt");

        private readonly string arquivoPrevisaoDeChegadaTecnica =
            Path.Combine(AppData, "previsaoDeChegadaTecnica.txt");

        private readonly string arquivoUnidadeRespectivaParaVisita =
            Path.Combine(AppData, "unidadeRespectivaParaVisita.txt");

        private readonly string arquivoEnderecoDaUnidade =
            Path.Combine(AppData, "unidadeEnderecoParaVisitaTecnica.txt");

        #endregion

        #region Construtor

        public Uc_LiberacaoDeAcesso()
        {
            InitializeComponent();
            CarregarDadosIniciais();
            btnAmplicarTexto.Click += btnAmplicarTexto_Click;
        }

        #endregion

        #region Inicialização

        private void CarregarDadosIniciais()
        {
            CarregarItens(arquivoOperadoraSolicitacaoVisita, comboBox_operadoraResponsavel);
            CarregarItens(arquivoPrevisaoDeChegadaTecnica, comboBox_previaoDeChegada);
            CarregarItens(arquivoUnidadeRespectivaParaVisita, comboBox_unidadeParaLiberacaoDeAcesso);
            CarregarItens(arquivoEnderecoDaUnidade, comboBox_enderecoDaUnidadeResponsavel);
        }

        #endregion

        #region Persistência

        private void SalvarItem(ComboBox comboBox, string caminhoArquivo)
        {
            var valor = comboBox.Text?.Trim();

            if (string.IsNullOrWhiteSpace(valor))
                return;

            if (comboBox.Items.Contains(valor))
                return;

            comboBox.Items.Add(valor);
            File.WriteAllLines(caminhoArquivo, comboBox.Items.Cast<string>());
        }

        private void CarregarItens(string caminhoArquivo, ComboBox comboBox)
        {
            if (!File.Exists(caminhoArquivo))
                return;

            comboBox.Items.Clear();
            comboBox.Items.AddRange(
                File.ReadAllLines(caminhoArquivo)
                    .Where(l => !string.IsNullOrWhiteSpace(l))
                    .Distinct()
                    .ToArray()
            );
        }

        #endregion

        #region Botões Principais

        private void btnSalvarECopiar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            SalvarItem(comboBox_operadoraResponsavel, arquivoOperadoraSolicitacaoVisita);
            SalvarItem(comboBox_previaoDeChegada, arquivoPrevisaoDeChegadaTecnica);
            SalvarItem(comboBox_unidadeParaLiberacaoDeAcesso, arquivoUnidadeRespectivaParaVisita);
            SalvarItem(comboBox_enderecoDaUnidadeResponsavel, arquivoEnderecoDaUnidade);

            Clipboard.SetText(GerarMensagem());

            MessageBox.Show(
                "Itens salvos e mensagem copiada para a área de transferência.",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            LimparCampos();
        }

        private void btnGerarAlerta_Click(object sender, EventArgs e)
        {
            richTextBox_mensagemASerEncaminhadaAoCliente.Text = GerarMensagem();
        }

        #endregion

        #region Validação

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(comboBox_operadoraResponsavel.Text) ||
                string.IsNullOrWhiteSpace(comboBox_previaoDeChegada.Text) ||
                string.IsNullOrWhiteSpace(comboBox_unidadeParaLiberacaoDeAcesso.Text) ||
                string.IsNullOrWhiteSpace(comboBox_enderecoDaUnidadeResponsavel.Text))
            {
                MostrarMensagem(
                    "Preencha todos os campos antes de continuar.",
                    MessageBoxIcon.Warning
                );
                return false;
            }

            return true;
        }

        #endregion

        #region Mensagem

        private string GerarMensagem()
        {
            string equipeTecnica =
                string.IsNullOrWhiteSpace(textBox_nomeEquipeTecnica.Text) &&
                string.IsNullOrWhiteSpace(textBox_credenciaisDePessoaFisica.Text)
                    ? string.Empty
                    : $"Equipe técnica: {textBox_nomeEquipeTecnica.Text} | {textBox_credenciaisDePessoaFisica.Text}\n";

            return
                $"Prezados, {ObterSaudacao()}.\n\n" +
                $"Faço parte do NOC da Tel&Com e solicito liberação de acesso para visita técnica.\n\n" +
                $"Operadora responsável: {comboBox_operadoraResponsavel.Text}\n" +
                $"Unidade: {comboBox_unidadeParaLiberacaoDeAcesso.Text}\n" +
                $"Endereço: {comboBox_enderecoDaUnidadeResponsavel.Text}\n" +
                equipeTecnica +
                $"Previsão de chegada: {comboBox_previaoDeChegada.Text}\n\n" +
                $"Atenciosamente,\nNOC - Tel&Com";
        }

        private static string ObterSaudacao()
        {
            int hora = DateTime.Now.Hour;

            if (hora < 12) return "bom dia";
            if (hora < 18) return "boa tarde";
            return "boa noite";
        }

        #endregion

        #region Exclusão

        private void bntExcluirSelecionado_Click(object sender, EventArgs e)
        {
            bool excluiu = false;

            excluiu |= ExcluirSelecionado(comboBox_operadoraResponsavel, arquivoOperadoraSolicitacaoVisita);
            excluiu |= ExcluirSelecionado(comboBox_previaoDeChegada, arquivoPrevisaoDeChegadaTecnica);
            excluiu |= ExcluirSelecionado(comboBox_unidadeParaLiberacaoDeAcesso, arquivoUnidadeRespectivaParaVisita);
            excluiu |= ExcluirSelecionado(comboBox_enderecoDaUnidadeResponsavel, arquivoEnderecoDaUnidade);

            MostrarMensagem(
                excluiu
                    ? "Item(ns) selecionado(s) excluído(s) com sucesso."
                    : "Selecione ao menos um item válido para exclusão.",
                excluiu ? MessageBoxIcon.Information : MessageBoxIcon.Warning
            );
        }

        private void btnExcluirTodosOsCampos_Click(object sender, EventArgs e)
        {
            if (!ConfirmarAcao(
                "Tem certeza que deseja excluir TODOS os itens?\n\nEssa ação não poderá ser desfeita."))
                return;

            bool excluiu = false;

            excluiu |= LimparComboBoxEArquivo(comboBox_operadoraResponsavel, arquivoOperadoraSolicitacaoVisita);
            excluiu |= LimparComboBoxEArquivo(comboBox_previaoDeChegada, arquivoPrevisaoDeChegadaTecnica);
            excluiu |= LimparComboBoxEArquivo(comboBox_unidadeParaLiberacaoDeAcesso, arquivoUnidadeRespectivaParaVisita);
            excluiu |= LimparComboBoxEArquivo(comboBox_enderecoDaUnidadeResponsavel, arquivoEnderecoDaUnidade);

            MostrarMensagem(
                excluiu
                    ? "Todos os itens foram excluídos com sucesso."
                    : "Não havia itens cadastrados para exclusão.",
                excluiu ? MessageBoxIcon.Information : MessageBoxIcon.Warning
            );
        }

        private bool ExcluirSelecionado(ComboBox comboBox, string caminhoArquivo)
        {
            var valor = comboBox.SelectedItem as string;

            if (string.IsNullOrWhiteSpace(valor) || !File.Exists(caminhoArquivo))
                return false;

            var linhas = File.ReadAllLines(caminhoArquivo).ToList();

            if (!linhas.Remove(valor))
                return false;

            File.WriteAllLines(caminhoArquivo, linhas);
            comboBox.Items.Remove(valor);
            comboBox.SelectedIndex = -1;
            comboBox.Text = "";

            return true;
        }

        private bool LimparComboBoxEArquivo(ComboBox comboBox, string caminhoArquivo)
        {
            if (comboBox.Items.Count == 0 && !File.Exists(caminhoArquivo))
                return false;

            comboBox.Items.Clear();
            comboBox.Text = "";

            if (File.Exists(caminhoArquivo))
                File.Delete(caminhoArquivo);

            return true;
        }

        #endregion

        #region Utilidades

        private void LimparCampos()
        {
            textBox_nomeEquipeTecnica.Clear();
            textBox_credenciaisDePessoaFisica.Clear();
            comboBox_operadoraResponsavel.Text = "";
            comboBox_previaoDeChegada.Text = "";
            comboBox_unidadeParaLiberacaoDeAcesso.Text = "";
            comboBox_enderecoDaUnidadeResponsavel.Text = "";
            richTextBox_mensagemASerEncaminhadaAoCliente.Clear();
        }

        private void btnAmplicarTexto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBox_mensagemASerEncaminhadaAoCliente.Text))
                return;

            new AmpliarMensagemDeTexto_LiberacaoDeAcesso(
                richTextBox_mensagemASerEncaminhadaAoCliente.Text
            ).ShowDialog();
        }

        private void MostrarMensagem(string texto, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            MessageBox.Show(
                texto,
                "NOC - Tel&Com",
                MessageBoxButtons.OK,
                icon
            );
        }

        private bool ConfirmarAcao(string texto)
        {
            return MessageBox.Show(
                texto,
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) == DialogResult.Yes;
        }

        #endregion
    }
}
