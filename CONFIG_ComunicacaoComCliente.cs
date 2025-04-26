using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace NOCActions
{
	// Formulário de configuração de comunicação com o cliente
	public partial class CONFIG_ComunicacaoComCliente : Form
	{
		private ACAO_ComunicacaoComCliente form_comunicacaoComCliente;
		private string arquivo_emailCliente = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "email_de_clientes.txt");
		

		public CONFIG_ComunicacaoComCliente(ACAO_ComunicacaoComCliente form)
		{
			InitializeComponent(); // Inicializa os componentes do formulário
			form_comunicacaoComCliente = form; // Recebe a referência do formulário principal
			CarregarEmailsSalvosNosComboBox();
		}

		void BtnSalvarClick(object sender, EventArgs e)
		{
			string emailDestinatario1 = comboEmailContratoCliente_01.Text;
			string emailDestinatario2 = comboEmailContratoCliente_02.Text;
			string emailDestinatario3 = comboEmailContratoCliente_03.Text;

			// Concatena os e-mails usando ';' e remove os que estiverem vazios
			string concatenarEmails = string.Join(";", new[] {
			                                      	emailDestinatario1,
			                                      	emailDestinatario2,
			                                      	emailDestinatario3
			                                      }.Where(email => !string.IsNullOrWhiteSpace(email)));

			// Adiciona ao ComboBox no formulário principal
			if (!string.IsNullOrWhiteSpace(concatenarEmails))
			{
				form_comunicacaoComCliente.AdicionarEmailsConcatenados(concatenarEmails);
			}

			SalvarEmailsNoArquivo(concatenarEmails);
			this.Close(); // Fecha o formulário de configuração
		}
		private void SalvarEmailsNoArquivo(string email)
		{
			try {
				string newDirectory = Path.GetDirectoryName(arquivo_emailCliente);
				if(!Directory.Exists(newDirectory))
				{
					Directory.CreateDirectory(newDirectory);
				}
				
				File.AppendAllText(arquivo_emailCliente, email + Environment.NewLine);
				
			} catch (Exception ex)
			{
				MessageBox.Show("Erro ao salvar o e-mail: " + ex.Message);
			}
		}
		
		private void CarregarEmailsSalvosNosComboBox()
		{
			if (File.Exists(arquivo_emailCliente))
			{
				var linhas = File.ReadAllLines(arquivo_emailCliente)
					.Where(l => !string.IsNullOrWhiteSpace(l))
					.ToList();

				// Adiciona os e-mails que estão no arquivo, sem apagar os existentes no ComboBox
				foreach (var email in linhas)
				{
					if (!comboEmailContratoCliente_01.Items.Contains(email))
						comboEmailContratoCliente_01.Items.Add(email);
					if (!comboEmailContratoCliente_02.Items.Contains(email))
						comboEmailContratoCliente_02.Items.Add(email);
					if (!comboEmailContratoCliente_03.Items.Contains(email))
						comboEmailContratoCliente_03.Items.Add(email);
				}
			}
		}

	}
}
