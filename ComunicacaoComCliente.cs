using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NOCActions
{
    // Classe do formulário principal responsável pela comunicação com o cliente
    public partial class ACAO_ComunicacaoComCliente : Form
    {
        // Lista para armazenar os e-mails concatenados que serão exibidos no ComboBox
        public List<string> ListaDeEmailsConcatenados;

        // Construtor do formulário
        public ACAO_ComunicacaoComCliente()
        {
            InitializeComponent(); // Inicializa os componentes visuais do formulário
            ListaDeEmailsConcatenados = new List<string>(); // Inicializa a lista de e-mails
            CarregarEmailConcatenadoNoComboBox(); // (Atualmente vazio) Pretende carregar e-mails já existentes ao abrir o formulário
            
            AtualizarComboBox();
            
        }

        // Método público para adicionar uma string de e-mails concatenados à lista
        public void AdicionarEmailsConcatenados(string emails)
        {
            // Verifica se a string não é nula, vazia ou composta apenas por espaços
            if (!string.IsNullOrWhiteSpace(emails))
            {
                ListaDeEmailsConcatenados.Add(emails); // Adiciona o e-mail à lista
                AtualizarComboBox(); // Atualiza o ComboBox com a nova lista
            }
        }

        // Método que atualiza os itens do ComboBox com os e-mails armazenados
        public void AtualizarComboBox()
        {
            comboBox2Para.Items.Clear(); // Limpa todos os itens existentes no ComboBox
            foreach (var emails in ListaDeEmailsConcatenados)
            {
                comboBox2Para.Items.Add(emails); // Adiciona cada e-mail na lista de opções do ComboBox
            }
        }

        // Evento de clique do botão para abrir a configuração de contratos e usuários
        void BtnConfiguracaoDeContratoEUsuarioPadraoClick(object sender, EventArgs e)
        {
            CONFIG_ComunicacaoComCliente formConfig = new CONFIG_ComunicacaoComCliente(this); // Instancia o formulário de configuração, passando a referência do formulário atual
            formConfig.ShowDialog(); // Abre o formulário de configuração como uma janela modal (bloqueia o formulário principal até fechar)
        }

        // Método reservado para carregar e-mails já salvos no ComboBox ao iniciar o formulário
        private void CarregarEmailConcatenadoNoComboBox()
        {
            // Está vazio atualmente. Pode ser implementado para carregar e-mails do banco de dados ou arquivo, se necessário.
        }
    }
}
