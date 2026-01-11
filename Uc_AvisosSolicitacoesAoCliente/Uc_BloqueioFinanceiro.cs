using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;


namespace NOC_Actions
{
    public partial class Uc_BloqueioFinanceiro : UserControl
    {

        private readonly string arquivo_bloqueioFinanceiro_unidade =
           Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "unidadeBloqueioFinanceiro.txt");

        private readonly string arquivo_bloqueioFinanceiro_enderecoUnidade =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "enderecoUnidadeBloqueioFinanceiro.txt");

        private readonly string arquivo_operadoraComBloqueioFinanceiro =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "operadoraComBloqueioFinanceiro.txt");

        public Uc_BloqueioFinanceiro()
        {
            InitializeComponent();
            CarregarInformacoes();
        }

        private string ValorOuNull(string valor)
        {
            return string.IsNullOrWhiteSpace(valor) ? "NULL" : valor;
        }


        private string ObterSaudacao()
        {
            int hora = DateTime.Now.Hour;

            if (hora >= 5 && hora < 12) return "bom dia";
            if (hora >= 12 && hora < 18) return "boa tarde";
            return "boa noite";
        }

        private void btnSalvarECopiar_Click(object sender, EventArgs e)
        {
            SalvarItem(comboBox_unidadeComBloqueioFinanceiro, arquivo_bloqueioFinanceiro_unidade);
            SalvarItem(comboBox_enderecoRespectivoDoBloqueioFinanceiro, arquivo_bloqueioFinanceiro_enderecoUnidade);
            SalvarItem(comboBox_operadoraComBloqueioFinanceiro, arquivo_operadoraComBloqueioFinanceiro);

            if (!decimal.TryParse(
                maskedTextBox_valorAPagar.Text.Replace("R$", "").Trim(),
                NumberStyles.Number,
                new CultureInfo("pt-BR"),
                out decimal valorFatura))
            {
                MessageBox.Show("Valor da fatura inválido.");
                return;
            }

            DateTime.TryParse(maskedTextBox_dataDaReferencia.Text, out DateTime dataVencimento);
            DateTime.TryParse(maskedTextBox_horarioQueda.Text, out DateTime horarioQueda);

            string mensagem = GerarMensagem(
                comboBox_unidadeComBloqueioFinanceiro.Text,
                comboBox_operadoraComBloqueioFinanceiro.Text,
                valorFatura,
                dataVencimento,
                horarioQueda
            );

            Clipboard.SetText(mensagem);
            
            MessageBox.Show("Mensagem copiada para a área de transferência.");
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            string valorTexto = maskedTextBox_valorAPagar.Text
                .Replace("R$", "")
                .Trim();

            if (!decimal.TryParse(
                valorTexto,
                NumberStyles.Number | NumberStyles.AllowCurrencySymbol,
                new CultureInfo("pt-BR"),
                out decimal valorFatura))
            {
                MessageBox.Show("Valor da fatura inválido.");
                return;
            }

            if (!DateTime.TryParse(maskedTextBox_dataDaReferencia.Text, out DateTime dataVencimento))
            {
                MessageBox.Show("Data de vencimento inválida.");
                return;
            }

            if (!DateTime.TryParse(maskedTextBox_horarioQueda.Text, out DateTime horarioQueda))
            {
                MessageBox.Show("Horário da queda inválido.");
                return;
            }

            MensagemPronta(
                comboBox_unidadeComBloqueioFinanceiro.Text,
                comboBox_operadoraComBloqueioFinanceiro.Text,
                valorFatura,
                dataVencimento,
                horarioQueda
            );
        }

        private void btnApagarCampos_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }


        private void SalvarItem(ComboBox comboBox, string caminhoArquivo)
        {
            string valor = comboBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(valor))
                return;

            if (!comboBox.Items.Contains(valor))
            {
                comboBox.Items.Add(valor);
                File.WriteAllLines(caminhoArquivo, comboBox.Items.Cast<string>());
            }
        }
        private void CarregarInformacoes()
        {
            CarregarItens(arquivo_bloqueioFinanceiro_unidade, comboBox_unidadeComBloqueioFinanceiro);
            CarregarItens(arquivo_bloqueioFinanceiro_enderecoUnidade, comboBox_enderecoRespectivoDoBloqueioFinanceiro);
            CarregarItens(arquivo_operadoraComBloqueioFinanceiro, comboBox_operadoraComBloqueioFinanceiro);
        }

        private void CarregarItens(string arquivo, ComboBox comboBox)
        {
            // Se o arquivo não existe, nada a carregar
            if (!File.Exists(arquivo))
                return;

            var linhas = File.ReadAllLines(arquivo)
                            .Where(l => !string.IsNullOrWhiteSpace(l))
                            .Distinct()
                            .ToArray();

            comboBox.Items.Clear();
            comboBox.Items.AddRange(linhas);
        }


        private void MensagemPronta(
            string unidadeComBloqueio,
            string operadoraComBloqueio,
            decimal valorFatura,
            DateTime dataVencimento,
            DateTime horarioQueda)
        {
            MessageBox.Show(
                $"Prezados, {ObterSaudacao()}! Informamos que a unidade {ValorOuNull(unidadeComBloqueio)} " +
                $"encontra-se inoperante em decorrência de um bloqueio administrativo de natureza financeira junto à operadora " +
                $"{ValorOuNull(operadoraComBloqueio)}. O valor total pendente é de R$ {valorFatura:N2}, " +
                $"com vencimento em {dataVencimento:dd/MM/yyyy}. A indisponibilidade teve início às {horarioQueda:HH:mm} horas."
            );
        }

        private string GerarMensagem(
        string unidadeComBloqueio,
        string operadoraComBloqueio,
        decimal valorFatura,
        DateTime dataVencimento,
        DateTime horarioQueda)
        {
            return
                $"Prezados, {ObterSaudacao()}! Informamos que a unidade {ValorOuNull(unidadeComBloqueio)} " +
                $"encontra-se inoperante em decorrência de um bloqueio administrativo de natureza financeira junto à operadora " +
                $"{ValorOuNull(operadoraComBloqueio)}. O valor total pendente é de R$ {valorFatura:N2}, " +
                $"com vencimento em {dataVencimento:dd/MM/yyyy}. A indisponibilidade teve início às {horarioQueda:HH:mm} horas.";
        }


        private void ClearField()
        {
            comboBox_unidadeComBloqueioFinanceiro.Text = "";
            comboBox_enderecoRespectivoDoBloqueioFinanceiro.Text = "";
            comboBox_operadoraComBloqueioFinanceiro.Text = "";
            maskedTextBox_valorAPagar.Text = "";
            maskedTextBox_horarioQueda.Text = "";
            maskedTextBox_dataDaReferencia.Text = "";
        }

        void CloseWindow()
        {
            this.FindForm().Close();
        }
    }
}