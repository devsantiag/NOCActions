using System;
using System.Windows.Forms;

namespace NOC_Actions
{
    public partial class LoginUser : Form
    {
        private readonly LoginUsuario loginInfo = new LoginUsuario();

        public LoginUser()
        {
            InitializeComponent();
        }

        private void BtnLoginClick(object sender, EventArgs e)
        {
            string usuarioDigitado = textBox1_userLogin.Text;
            string senhaDigitada   = textBox2_userPassword.Text;

            bool loginWindowsValido =
                usuarioDigitado == loginInfo.UserLogin_Windows &&
                senhaDigitada   == loginInfo.UserLogin_Windows;

            bool loginPadraoValido =
                usuarioDigitado == loginInfo.UserLoginPadrao &&
                senhaDigitada   == loginInfo.UserLoginPadrao;

            if (loginWindowsValido || loginPadraoValido)
            {
                MainForm principal = new MainForm();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void BtnSairClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {

        }
    }
}