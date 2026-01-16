using System;
using System.Windows.Forms;

namespace NOC_Actions
{
    public partial class InterfaceClienteInformes : Form
    {
        public InterfaceClienteInformes()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void MostrarUserControl(UserControl uc)
        {
            painelInterface.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            painelInterface.Controls.Add(uc);
        }

        private void BtnAlarmeLinkIndisponivel_Click(object sender, EventArgs e)
        {
            var uc = new UcAlarmeDeLinkIndisponivel();
            MostrarUserControl(uc);
            DarFocoNoUserControl(uc);
        }

        private void BtnChamadoRegistrado_Click(object sender, EventArgs e)
        {
            var uc = new UcAberturaDeReparo();
            MostrarUserControl(uc);
            DarFocoNoUserControl(uc);
        }

        private void BtnLibAcessoSemPrevisao_Click(object sender, EventArgs e)
        {
            var uc = new UcLiberacaoDeAcessoSemPrevisao();
            MostrarUserControl(uc);
            DarFocoNoUserControl(uc);
        }

        private void BtnLibAcessoComPrevisao_Click(object sender, EventArgs e)
        {
            var uc = new UcLiberacaoDeAcessoComPrevisao();
            MostrarUserControl(uc);
            DarFocoNoUserControl(uc);
        }

        private void BtnAnaliseEnergia_Click(object sender, EventArgs e)
        {
            var uc = new UcPossivelQuedaDeEnergia();
            MostrarUserControl(uc);
            DarFocoNoUserControl(uc);
        }

        private void BtnQuedaEnergiaClick(object sender, EventArgs e)
        {
            var uc = new UcPossivelQuedaDeEnergia();
            MostrarUserControl(uc);
            DarFocoNoUserControl(uc);
        }

        private void Button1Click(object sender, EventArgs e)
        {
            var uc = new UcPendenciaFinanceiraInformes();
            MostrarUserControl(uc);
            DarFocoNoUserControl(uc);
        }

        private void BtnPendenciaFinanceiraClick(object sender, EventArgs e)
        {
            var uc = new UcPendenciaFinanceiraInformes();
            MostrarUserControl(uc);
            DarFocoNoUserControl(uc);
        }

        private void BtnRegistroDeFalhaInternaClienteClick(object sender, EventArgs e)
        {
            var uc = new UcRegistroDeOcorrenciaInterna();
            MostrarUserControl(uc);
            DarFocoNoUserControl(uc);
        }

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
    }
}
