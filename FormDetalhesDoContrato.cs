using System;
using System.Windows.Forms;

namespace NOC_Actions
{
	public partial class FormDetalhesDoContrato : UserControl
	{
		private Class_InformacoesContrato_ReincidenciaDeFalha _contrato;
		
		public FormDetalhesDoContrato(Class_InformacoesContrato_ReincidenciaDeFalha contrato)
		{
			InitializeComponent();
			_contrato = contrato;
			CarregarDados();
		}
		
		private void CarregarDados()
		{
			title_contratoNomeEInformacoes.Text = "Unidade: " +_contrato.Unidade+ " | Operadora: " +_contrato.Operadora;
		}
	}
}
