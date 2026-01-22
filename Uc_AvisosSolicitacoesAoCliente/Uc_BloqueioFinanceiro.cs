using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NOC_Actions
{
    public partial class Uc_BloqueioFinanceiro : UserControl
    {
        #region Arquivos (Persistência)

        private static readonly string AppData =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        private readonly string arquivo_unidade =
            Path.Combine(AppData, "unidadeBloqueioFinanceiro.txt");

        private readonly string arquivo_endereco =
            Path.Combine(AppData, "enderecoUnidadeBloqueioFinanceiro.txt");

        private readonly string arquivo_operadora =
            Path.Combine(AppData, "operadoraComBloqueioFinanceiro.txt");

        #endregion

        #region Construtor

        public Uc_BloqueioFinanceiro()
        {
            InitializeComponent();
            CarregarInformacoes();
        }

        #endregion

        #region Eventos

        private void btnSalvarECopiar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            SalvarItem(comboBox_unidadeComBloqueioFinanceiro, arquivo_unidade);
            SalvarItem(comboBox_enderecoRespectivoDoBloqueioFinanceiro, arquivo_endereco);
            SalvarItem(comboBox_operadoraComBloqueioFinanceiro, arquivo_operadora);

            Clipboard.SetText(GerarMensagem());

            MessageBox.Show(
                "Itens salvos e mensagem copiada para a área de transferência.",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            LimparCampos();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            MessageBox.Show(
                GerarMensagem(),
                "Visualização da Mensagem",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnApagarCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            FindForm()?.Close();
        }

        private void bntExcluirSelecionado_Click(object sender, EventArgs e)
        {
            bool excluiu = false;

            excluiu |= ExcluirSelecionado(comboBox_unidadeComBloqueioFinanceiro, arquivo_unidade);
            excluiu |= ExcluirSelecionado(comboBox_enderecoRespectivoDoBloqueioFinanceiro, arquivo_endereco);
            excluiu |= ExcluirSelecionado(comboBox_operadoraComBloqueioFinanceiro, arquivo_operadora);

            if (excluiu)
            {
                MessageBox.Show(
                    "Item(ns) selecionado(s) excluído(s) com sucesso.",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Selecione ao menos um item válido para exclusão.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnExcluirTudoDasListas_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show(
                "Tem certeza que deseja excluir TODOS os itens?\n\nEssa ação não poderá ser desfeita.",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacao != DialogResult.Yes)
                return;

            bool excluiu = false;

            excluiu |= ExcluirTodos(comboBox_unidadeComBloqueioFinanceiro, arquivo_unidade);
            excluiu |= ExcluirTodos(comboBox_enderecoRespectivoDoBloqueioFinanceiro, arquivo_endereco);
            excluiu |= ExcluirTodos(comboBox_operadoraComBloqueioFinanceiro, arquivo_operadora);

            if (excluiu)
            {
                MessageBox.Show(
                    "Todos os itens foram excluídos com sucesso.",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Não havia itens cadastrados para exclusão.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        #endregion

        #region Validações

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(comboBox_unidadeComBloqueioFinanceiro.Text) ||
                string.IsNullOrWhiteSpace(comboBox_operadoraComBloqueioFinanceiro.Text) ||
                !maskedTextBox_valorAPagar.MaskCompleted ||
                !maskedTextBox_dataDaReferencia.MaskCompleted ||
                !maskedTextBox_horarioQueda.MaskCompleted)
            {
                MessageBox.Show(
                    "Preencha todos os campos antes de continuar.",
                    "Atenção",
                    MessageBoxButtons.OK,
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
            decimal valor = decimal.Parse(
                maskedTextBox_valorAPagar.Text,
                CultureInfo.CurrentCulture
            );

            DateTime data = DateTime.Parse(maskedTextBox_dataDaReferencia.Text);
            DateTime hora = DateTime.Parse(maskedTextBox_horarioQueda.Text);

            return
                $"Prezados, {ObterSaudacao()}.\n\n" +
                $"Informamos que a unidade {comboBox_unidadeComBloqueioFinanceiro.Text} encontra-se inoperante " +
                $"devido a bloqueio financeiro junto à operadora {comboBox_operadoraComBloqueioFinanceiro.Text}.\n\n" +
                $"Valor pendente: R$ {valor:N2}\n" +
                $"Data de referência: {data:dd/MM/yyyy}\n" +
                $"Início da indisponibilidade: {hora:HH:mm}\n\n" +
                $"Atenciosamente,\nEquipe NOC";
        }

        private static string ObterSaudacao()
        {
            int hora = DateTime.Now.Hour;

            if (hora < 12) return "bom dia";
            if (hora < 18) return "boa tarde";
            return "boa noite";
        }

        #endregion

        #region Utilidades

        private void LimparCampos()
        {
            comboBox_unidadeComBloqueioFinanceiro.Text = "";
            comboBox_enderecoRespectivoDoBloqueioFinanceiro.Text = "";
            comboBox_operadoraComBloqueioFinanceiro.Text = "";

            maskedTextBox_valorAPagar.Clear();
            maskedTextBox_dataDaReferencia.Clear();
            maskedTextBox_horarioQueda.Clear();
        }

        #endregion

        #region Arquivos

        private void SalvarItem(ComboBox comboBox, string arquivo)
        {
            var valor = comboBox.Text?.Trim();

            if (string.IsNullOrWhiteSpace(valor))
                return;

            if (comboBox.Items.Contains(valor))
                return;

            comboBox.Items.Add(valor);
            File.WriteAllLines(arquivo, comboBox.Items.Cast<string>());
        }

        private bool ExcluirSelecionado(ComboBox comboBox, string arquivo)
        {
            var valor = comboBox.SelectedItem as string;

            if (valor == null || !File.Exists(arquivo))
                return false;

            var linhas = File.ReadAllLines(arquivo).ToList();

            if (!linhas.Remove(valor))
                return false;

            File.WriteAllLines(arquivo, linhas);
            comboBox.Items.Remove(valor);
            comboBox.SelectedIndex = -1;

            return true;
        }

        private bool ExcluirTodos(ComboBox comboBox, string arquivo)
        {
            if (!File.Exists(arquivo))
                return false;

            File.WriteAllText(arquivo, string.Empty);
            comboBox.Items.Clear();
            comboBox.SelectedIndex = -1;
            comboBox.Text = string.Empty;

            return true;
        }

        private void CarregarInformacoes()
        {
            CarregarItens(arquivo_unidade, comboBox_unidadeComBloqueioFinanceiro);
            CarregarItens(arquivo_endereco, comboBox_enderecoRespectivoDoBloqueioFinanceiro);
            CarregarItens(arquivo_operadora, comboBox_operadoraComBloqueioFinanceiro);
        }

        private void CarregarItens(string arquivo, ComboBox comboBox)
        {
            if (!File.Exists(arquivo))
                return;

            comboBox.Items.Clear();
            comboBox.Items.AddRange(
                File.ReadAllLines(arquivo)
                    .Where(l => !string.IsNullOrWhiteSpace(l))
                    .Distinct()
                    .ToArray()
            );
        }

        #endregion
    }
}
