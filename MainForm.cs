using System;
using System.Windows.Forms;

namespace NOCActions
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			this.TopMost = true;
			
		}
				
		void SemEnergiaClick(object sender, EventArgs e)
		{
			Clipboard.SetText("Sem contato com a unidade. Devido queda simultânea dos links, possível queda de energia.");
		}
		
		void ButtonSemContatoLocalClick(object sender, EventArgs e)
		{
			Clipboard.SetText("Sem contato do local, solicitado auxílio do Cliente na validação interna.");
		}
		
		void ButtonSemExpedienteClick(object sender, EventArgs e)
		{
			Clipboard.SetText("Devido expediente do cliente, manteremos o link em monitoração até o próximo dia útil.");
		}
		
		void ButtonInfraOkClienteClick(object sender, EventArgs e)
		{
			Clipboard.SetText("Cliente informa que unidade está com energia e Internet, será acionado fornecedor para verificação do alarme.");
		}
		
		void ButtonSemContatoOperadoraClick(object sender, EventArgs e)
		{
			Clipboard.SetText("Sem contato com a Operadora, tentaremos novamente mais tarde.");
		}
		
		void ButtonAberturaDeOsClick(object sender, EventArgs e)
		{
			Clipboard.SetText("Encaminhado e-mail solicitando abertura de chamado ao fornecedor.");
		}
		
		void ButtonPosicionamentoTecnicoClick(object sender, EventArgs e)
		{
			Clipboard.SetText("Encaminhado e-mail solicitando posicionamento frente ao reparo em aberto junto ao fornecedor.");
		}
		void Button2Click(object sender, EventArgs e)
		{
	
		}
	}
}
