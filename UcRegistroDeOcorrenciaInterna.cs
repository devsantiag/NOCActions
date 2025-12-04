using System;
using System.Windows.Forms;
using NOC_Actions;
using System.Linq;
using System.IO;

namespace NOC_Actions
{
	public partial class UcRegistroDeOcorrenciaInterna : UserControl
	{
		private readonly string arquivo_unidadeSemNecessidadeDeRegistroTecnico = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "unidadeSemNecessidadeDeRegistroTecnico.txt");
		
		private readonly string arquivo_operadoraDaUnidade = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "operadoraDaUnidade.txt");
		
		public UcRegistroDeOcorrenciaInterna()
		{
			InitializeComponent();
		}
		
		void BtnSaveAndCopyClick(object sender, EventArgs e)
		{
			string textContratoUnidade = textBox_UnidadeContrato.Text.Trim();
			string textOperadoraDoContratoUnidade = textBox_OperadoraDaUnidade.Text.Trim();
			string textObservacaoContratoUnidade = textBox_observacaoDoContrato.Text.Trim();
			listBox_RegistroDeOcorrencia.Items.Add("> Contrato/unidade: " +textContratoUnidade+ " |  Operadora: " +textOperadoraDoContratoUnidade+ " |" + " Observação: " +textObservacaoContratoUnidade);
		}
		
		void ListBox_RegistroDeOcorrenciaSelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox_RegistroDeOcorrencia.SelectedItem == null)
				return;

			string linha = listBox_RegistroDeOcorrencia.SelectedItem.ToString();

			string unidade = "";
			string operadora = "";
			// Extrair informações da linha
			if (linha.Contains("Contrato/unidade:") && linha.Contains("Operadora:"))
			{
				int idxUnidade = linha.IndexOf("Contrato/unidade:") + "Contrato/unidade:".Length;
				int idxOperadora = linha.IndexOf("Operadora:");

				unidade = linha.Substring(idxUnidade, idxOperadora - idxUnidade).Trim();
				operadora = linha.Substring(idxOperadora + "Operadora:".Length).Trim();
			}

			Class_InformacoesContrato_ReincidenciaDeFalha contrato =
				new Class_InformacoesContrato_ReincidenciaDeFalha
			{
				Unidade = unidade,
				Operadora = operadora
			};

			FormDetalhesDoContrato detalhes = new FormDetalhesDoContrato(contrato);
			detalhes.Show();
		}
	}
}