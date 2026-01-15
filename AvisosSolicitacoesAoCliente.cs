using System;
using System.Windows.Forms;

namespace NOC_Actions
{
    public partial class AvisosSolicitacoesAoCliente : Form
    {
        public AvisosSolicitacoesAoCliente()
        {
            InitializeComponent();
            this.KeyPreview = true; // 👈 essencial para teclado
        }

        private void MostrarUserControl(UserControl uc)
        {
            splitContainer.Panel2.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            splitContainer.Panel2.Controls.Add(uc);
        }

        void BtnAnaliseDeInfraClick(object sender, EventArgs e)
        {
            var uc = new Uc_AnaliseDeInfra();

            MostrarUserControl(uc);

            // 👇 foco entra no UserControl
            DarFocoNoUserControl(uc);
        }

        void BtnLiberacaoDeAcessoClick(object sender, EventArgs e)
        {
            var uc = new Uc_LiberacaoDeAcesso();
            MostrarUserControl(uc);
            DarFocoNoUserControl(uc);
        }

        void BtnPossivelQuedaDeEnergiaClick(object sender, EventArgs e)
        {
            var uc = new Uc_PossivelQuedaDeEnergia();
            MostrarUserControl(uc);
            DarFocoNoUserControl(uc);
        }

        void BtnBloqueioFinanceiroClick(object sender, EventArgs e)
        {
            var uc = new Uc_BloqueioFinanceiro();
            MostrarUserControl(uc);
            DarFocoNoUserControl(uc);
        }

        // =========================
        // MÉTODO PADRÃO DE FOCO
        // =========================
        private void DarFocoNoUserControl(UserControl uc)
        {
            uc.Select();
            uc.Focus();

            Control controleInicial = null;

            foreach (Control c in uc.Controls)
            {
                if (c.TabIndex == 0 && c.CanSelect)
                {
                    controleInicial = c;
                    break;
                }
            }

            // Fallback: primeiro controle selecionável
            if (controleInicial == null)
            {
                foreach (Control c in uc.Controls)
                {
                    if (c.CanSelect)
                    {
                        controleInicial = c;
                        break;
                    }
                }
            }

            controleInicial?.Focus();
        }


        void LabelUsernameClick(object sender, EventArgs e)
        {
            AvisosSolicitacoesAoCliente home = new AvisosSolicitacoesAoCliente();
            home.Show();
            this.Hide();
        }
    }
}
