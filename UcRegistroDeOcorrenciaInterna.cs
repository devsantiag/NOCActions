using System;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace NOC_Actions
{
	public partial class UcRegistroDeOcorrenciaInterna : UserControl
	{
		private readonly string arquivo_todas_as_informacoes = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "registroOcorrencias.txt");
		
		public UcRegistroDeOcorrenciaInterna()
		{
			InitializeComponent();
			listBox_RegistroDeOcorrencia.MouseDoubleClick += ListBox_RegistroDeOcorrencia_MouseDoubleClick;
			LoadContentList();
		}
		
		void BtnSaveAndCopyClick(object sender, EventArgs e)
		{
			string textContratoUnidade = textBox_UnidadeContrato.Text.Trim();
			string textOperadoraDoContratoUnidade = textBox_OperadoraDaUnidade.Text.Trim();
			string textObservacaoContratoUnidade = textBox_observacaoDoContrato.Text.Trim();

			string itemList =
				"> Unidade: " + textContratoUnidade +
				" | Operadora/Designação: " + textOperadoraDoContratoUnidade +
				" | Observação: " + textObservacaoContratoUnidade;
			
			listBox_RegistroDeOcorrencia.Items.Add(
				itemList
			);

			string linhaArquivo =
				textContratoUnidade + "|" +
				textOperadoraDoContratoUnidade + "|" +
				textObservacaoContratoUnidade;
			
			File.AppendAllText(arquivo_todas_as_informacoes, linhaArquivo + Environment.NewLine);
		}
		
		void SelectedIndexOnListBoxToShowInformation(string message)
		{
			MessageBox.Show(message);
		}
		
		void ListBox_RegistroDeOcorrencia_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (listBox_RegistroDeOcorrencia.SelectedItem != null)
			{
				SelectedIndexOnListBoxToShowInformation(listBox_RegistroDeOcorrencia.SelectedItem.ToString());
			}
		}
		
		void LoadContentList()
		{
			if (File.Exists(arquivo_todas_as_informacoes))
			{
				foreach (var linha in File.ReadAllLines(arquivo_todas_as_informacoes))
				{
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
		
		void BtnDeletarSelecionadoClick(object sender, EventArgs e)
		{
			
			if (listBox_RegistroDeOcorrencia.SelectedItem == null) {
				MessageBox.Show("Nada selecionado. Tente novamente, por favor.");
				return;
			}

			listBox_RegistroDeOcorrencia.Items.Remove(listBox_RegistroDeOcorrencia.SelectedItem);
			
			using (StreamWriter writer = new StreamWriter(arquivo_todas_as_informacoes, false))
			{
				foreach (var item in listBox_RegistroDeOcorrencia.Items)
				{
					string linha = item.ToString();
					var partes = linha.Split('|');
					if (partes.Length == 3)
					{
						string unidade = partes[0].Replace("> Unidade:", "").Replace("> Contrato/unidade:", "").Trim();
						string operadora = partes[1].Replace("Operadora:", "").Trim();
						string observacao = partes[2].Replace("Observação:", "").Trim();

						writer.WriteLine(unidade + "|" + operadora + "|" + observacao);
					}
				}
			}
		}
		
		void BtnDeletarListaClick(object sender, EventArgs e)
		{
			if (listBox_RegistroDeOcorrencia == null)
			{
				MessageBox.Show("A lista já se encontra vazia!");
				return;
			}
			
			var confirm = MessageBox.Show("Deseja realmente apagar TUDO?\nEsta ação não poderá ser desfeita.", "Confirmar Exclusão Completa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			
			if (confirm == DialogResult.Yes)
			{
				listBox_RegistroDeOcorrencia.Items.Clear();
				File.WriteAllText(arquivo_todas_as_informacoes, "");
				MessageBox.Show("Todos os registros foram deletados com sucesso.");
			}
		}
		
		void BtnCloseWindowClick(object sender, EventArgs e)
		{
			CloseWindow();
		}
		
		void CloseWindow()
		{
			this.FindForm().Close();
		}
	}
}