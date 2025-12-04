using System;
using System.Windows.Forms;
using NOC_Actions;
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
		}
		
		void BtnSaveAndCopyClick(object sender, EventArgs e)
		{
			string textContratoUnidade = textBox_UnidadeContrato.Text.Trim();
			string textOperadoraDoContratoUnidade = textBox_OperadoraDaUnidade.Text.Trim();
			string textObservacaoContratoUnidade = textBox_observacaoDoContrato.Text.Trim();

			string itemList =
				"> Unidade: " + textContratoUnidade +
				" | Operadora: " + textOperadoraDoContratoUnidade +
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
	}
}