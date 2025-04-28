using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NOCActions
{
	public partial class ACAO_ComunicacaoComCliente : Form
	{
		// Lista que armazena os e-mails concatenados
		public List<string> ListaDeEmailsConcatenados;

		public ACAO_ComunicacaoComCliente()
		{
			InitializeComponent();
			ListaDeEmailsConcatenados = new List<string>();
			CarregarEmailConcatenadoNoComboBox();
			AtualizarComboBox();
			OrganizarTabIndex();
		}

		// Adiciona e-mails concatenados à lista e atualiza o ComboBox
		public void AdicionarEmailsConcatenados(string emails)
		{
			if (!string.IsNullOrWhiteSpace(emails))
			{
				ListaDeEmailsConcatenados.Add(emails);
				AtualizarComboBox();
			}
		}

		// Atualiza o ComboBox com os e-mails da lista
		public void AtualizarComboBox()
		{
			comboBox2Para.Items.Clear();
			foreach (var emails in ListaDeEmailsConcatenados)
			{
				comboBox2Para.Items.Add(emails);
			}
		}

		// Abre o formulário de configuração
		void BtnConfiguracaoDeContratoEUsuarioPadraoClick(object sender, EventArgs e)
		{
			CONFIG_ComunicacaoComCliente formConfig = new CONFIG_ComunicacaoComCliente(this);
			formConfig.ShowDialog();
		}

		// Carrega e-mails previamente salvos (implementação futura)
		private void CarregarEmailConcatenadoNoComboBox()
		{
			// Em desenvolvimento
		}
		
		// Função responsável por organizar a navegação entre os controles do formulário
		private void OrganizarTabIndex()
		{
			comboBox1De.TabIndex = 0;
			comboBox2Para.TabIndex = 1;
			comboBox3Cc.TabIndex = 2;
			
			textBox1EmailAssunto.TabIndex = 3;
			richTextBox1Descricao.TabIndex = 4;
			
			btnEnviar.TabIndex = 5;
			btnDeletar.TabIndex = 6;
			btnPreviaEmail.TabIndex = 7;

		}
	}
}
