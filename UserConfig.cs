/*
 * Criado com SharpDevelop.
 * Usuário: fjstavares
 * Data: 01/02/2025
 * Hora: 02:42
 */

using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NOCActions
{
	public partial class UserConfig : Form
	{
		// Caminho do arquivo onde as operadoras serão salvas
		private string caminhoArquivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "operadoras.txt");
		public string CaminhoArquivo { get { return caminhoArquivo; } }
		
		public UserConfig()
		{
			InitializeComponent();
			CarregarOperadoraSalvas(); // Carrega as operadoras salvas no ComboBox ao abrir o formulário
			this.TopMost = true; // Mantém a janela no topo
		}
		
		// Eventos dos botões que chamam os métodos correspondentes
		void BtnAdicionarOperadoraClick(object sender, EventArgs e) { AdicionarOperadora(); }
		void BtnDeletarOperadoraClick(object sender, EventArgs e) { DeletarOperadoraListada(); }
		
		// Adiciona uma nova operadora à lista, evitando duplicatas
		private void AdicionarOperadora()
		{
			string adicionarOperadoraEmLista = textBoxAdicionarOperadora.Text.Trim();
			
			if (!string.IsNullOrWhiteSpace(adicionarOperadoraEmLista) && !comboBoxOperadoraJaAdicionadas.Items.Contains(adicionarOperadoraEmLista))
			{
				comboBoxOperadoraJaAdicionadas.Items.Add(adicionarOperadoraEmLista);
				textBoxAdicionarOperadora.Clear();
				SalvarOperadorasNoArquivo(); // Salva a lista atualizada no arquivo
			}
			else
			{
				MessageBox.Show("Essa operadora já foi adicionada ou o campo está vazio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		
		// Salva as operadoras da lista no arquivo
		private void SalvarOperadorasNoArquivo()
		{
			try
			{
				File.WriteAllLines(caminhoArquivo, comboBoxOperadoraJaAdicionadas.Items.Cast<string>());
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("Erro ao salvar os dados: {0}", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		// Remove a operadora selecionada da lista e atualiza o arquivo
		private void DeletarOperadoraListada()
		{
			if (comboBoxOperadoraJaAdicionadas.SelectedItem == null)
			{
				MessageBox.Show("Por favor, selecione uma operadora para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var resultadoDeConfirmacao = MessageBox.Show("Você tem certeza que deseja excluir esta operadora?", 
				"Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (resultadoDeConfirmacao == DialogResult.Yes)
			{
				comboBoxOperadoraJaAdicionadas.Items.Remove(comboBoxOperadoraJaAdicionadas.SelectedItem);
				SalvarOperadorasNoArquivo();
			}
		}
		
		// Carrega as operadoras salvas no arquivo para o ComboBox ao abrir o formulário
		private void CarregarOperadoraSalvas()
		{
			if (File.Exists(caminhoArquivo))
			{
				string[] operadorasSalvas = File.ReadAllLines(caminhoArquivo);
				comboBoxOperadoraJaAdicionadas.Items.AddRange(operadorasSalvas);
			}
		}
	}
}
