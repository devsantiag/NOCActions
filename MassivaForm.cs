/*
 * Criado com SharpDevelop.
 * Usuário: fjstavares
 * Data: 06/12/2024
 * Hora: 09:37
 */

using System;
using System.IO;
using System.Windows.Forms;

namespace NOCActions
{
	public partial class MassivaForm : Form
	{
		public MassivaForm()
		{
			this.TopMost = true; // Mantém a janela sempre no topo
			InitializeComponent();
			CarregarOperadorasSalvasNoForm(); // Carrega as operadoras salvas ao iniciar o formulário
		}

		// Lê as operadoras salvas no arquivo e as adiciona ao ComboBox
		private void CarregarOperadorasSalvasNoForm()
		{
			string caminhoArquivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "operadoras.txt");

			if (File.Exists(caminhoArquivo))
			{
				string[] operadorasSalvas = File.ReadAllLines(caminhoArquivo);
				OperadorasSalvasPeloUsuario(operadorasSalvas);
			}
		}

		// Atualiza o ComboBox com a lista de operadoras carregadas
		public void OperadorasSalvasPeloUsuario(string[] operadoras)
		{
			textBoxOperadora.Items.Clear();
			textBoxOperadora.Items.AddRange(operadoras);

			if (textBoxOperadora.Items.Count > 0)
			{
				textBoxOperadora.SelectedIndex = 0; // Seleciona a primeira operadora da lista
			}
		}

		private void BtnGerarClick(object sender, EventArgs e)
		{
			GerarMensagemDeMassiva();
		}

		// Gera a mensagem de possível massiva com base na cidade e operadora informadas
		private void GerarMensagemDeMassiva()
		{
			textBoxExemplo.Clear();
			var estadoAfetado = textBoxCidades.Text.Trim();
			var operadoraAfetada = textBoxOperadora.Text.Trim();

			if (string.IsNullOrWhiteSpace(estadoAfetado) || string.IsNullOrWhiteSpace(operadoraAfetada))
			{
				MessageBox.Show("Por favor, preencha as informações de cidade e operadora antes de gerar a mensagem.", 
					"Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var mensagemDeMassiva = string.Format(
				"Possível massiva na região de {0} devido ambos os links da {1} caírem simultaneamente.", 
				estadoAfetado, operadoraAfetada);

			textBoxExemplo.Text = mensagemDeMassiva;
		}

		// Copia a mensagem gerada para a área de transferência
		private void ButtonCopiarClick(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(textBoxExemplo.Text))
			{
				Clipboard.SetText(textBoxExemplo.Text);
			}
		}

		// Limpa os campos do formulário
		private void BtnApagarClick(object sender, EventArgs e)
		{
			textBoxCidades.Clear();
			textBoxOperadora.Items.Clear();
			textBoxExemplo.Clear();
		}

		// Abre a tela de configuração e recarrega as operadoras caso haja alteração
		private void BtnConfigClick(object sender, EventArgs e)
		{
			UserConfig config = new UserConfig();
			config.ShowDialog();

			if (config != null && !string.IsNullOrEmpty(config.CaminhoArquivo) && File.Exists(config.CaminhoArquivo))
			{
				string[] operadorasSalvas = File.ReadAllLines(config.CaminhoArquivo);
				OperadorasSalvasPeloUsuario(operadorasSalvas);
			}
		}
	}
}
