using System;
using System.Windows.Forms;

namespace NOC_Actions
{
	public partial class UcLiberacaoDeAcessoComPrevisao : UserControl
	{
		private string mensagemASerExibida;

		public UcLiberacaoDeAcessoComPrevisao()
		{
			InitializeComponent();
		}

		void BtnGravarECopiarClick(object sender, EventArgs e)
		{
			string getDadosTecnicos = richTextBox1_DadosTecnicos.Text.Trim();
			string getPrevisaoChegada = textBox1_PrevisaoChegada.Text.Trim();

			mensagemASerExibida =
				"Prezados, necessário acionamento com a loja para liberação de acesso do(s) técnico(s) abaixo. " +
				"Previsão de chegada às " + getPrevisaoChegada + "." +
				Environment.NewLine + Environment.NewLine +
				getDadosTecnicos;

			Clipboard.SetText(mensagemASerExibida);

			// limpa os campos
			richTextBox1_DadosTecnicos.Text = "";
			textBox1_PrevisaoChegada.Text = "";
		}

		void BtnApagarCamposClick(object sender, EventArgs e)
		{
			richTextBox1_DadosTecnicos.Text = "";
			textBox1_PrevisaoChegada.Text = "";
		}

		void BtnFecharJanelaClick(object sender, EventArgs e)
		{
			this.FindForm().Close();
		}

		void PreviaDaMensagem(string msn)
		{
			MessageBox.Show(msn, "Prévia da Mensagem",
			                MessageBoxButtons.OK,
			                MessageBoxIcon.Information);
		}

		void BtnPreviaDaMensagemClick(object sender, EventArgs e)
		{
			// monta a mensagem com os campos atuais (sem precisar gravar/copiar)
			string getDadosTecnicos = richTextBox1_DadosTecnicos.Text.Trim();
			string getPrevisaoChegada = textBox1_PrevisaoChegada.Text.Trim();

			if (string.IsNullOrWhiteSpace(getDadosTecnicos) ||
			    string.IsNullOrWhiteSpace(getPrevisaoChegada))
			{
				MessageBox.Show("Preencha todos os campos antes de ver a prévia.",
				                "Atenção",
				                MessageBoxButtons.OK,
				                MessageBoxIcon.Warning);
				return;
			}

			string previa =
				"Prezados, necessário acionamento com a loja para liberação de acesso do(s) técnico(s) abaixo. " +
				"Previsão de chegada às " + getPrevisaoChegada + "." +
				Environment.NewLine + Environment.NewLine +
				getDadosTecnicos;

			PreviaDaMensagem(previa);
		}
	}
}
