/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 26/02/2025
 * Time: 15:19
 */

using System;
using System.Windows.Forms;

namespace NOCActions
{
	public partial class MenuDeAcesso : Form
	{
		public MenuDeAcesso()
		{
			InitializeComponent();
		}
		
//		button responsável para opções de abertura de Massiva Contratual
		void Button1AcaoAberturaDeMassivaClick(object sender, EventArgs e)
		{
			MassivaForm acaoAberturaDeMassivaForm = new MassivaForm();
			acaoAberturaDeMassivaForm.ShowDialog();
		}

		void ButtonComunicacaoComClienteClick(object sender, EventArgs e)
		{
			ACAO_ComunicacaoComCliente comunicacaoComClienteShowProject = new ACAO_ComunicacaoComCliente();
			comunicacaoComClienteShowProject.ShowDialog();
		}
	}
}
