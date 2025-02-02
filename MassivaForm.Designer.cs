/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 06/12/2024
 * Time: 09:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NOCActions
{
	partial class MassivaForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonCopiar;
		private System.Windows.Forms.Button btnGerar;
		private System.Windows.Forms.RichTextBox textBoxExemplo;
		private System.Windows.Forms.Button btnApagar;
		private System.Windows.Forms.Button btnConfig;
		private System.Windows.Forms.TextBox textBoxCidades;
		private System.Windows.Forms.ComboBox textBoxOperadora;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxExemplo = new System.Windows.Forms.RichTextBox();
			this.btnApagar = new System.Windows.Forms.Button();
			this.buttonCopiar = new System.Windows.Forms.Button();
			this.btnGerar = new System.Windows.Forms.Button();
			this.btnConfig = new System.Windows.Forms.Button();
			this.textBoxCidades = new System.Windows.Forms.TextBox();
			this.textBoxOperadora = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12.25F);
			this.label1.Location = new System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 19);
			this.label1.TabIndex = 7;
			this.label1.Text = "Cidade";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12.25F);
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 19);
			this.label2.TabIndex = 8;
			this.label2.Text = "Operadora";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 12.25F);
			this.label3.Location = new System.Drawing.Point(12, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 19);
			this.label3.TabIndex = 9;
			this.label3.Text = "Exemplo";
			// 
			// textBoxExemplo
			// 
			this.textBoxExemplo.Enabled = false;
			this.textBoxExemplo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxExemplo.Location = new System.Drawing.Point(110, 86);
			this.textBoxExemplo.Name = "textBoxExemplo";
			this.textBoxExemplo.ReadOnly = true;
			this.textBoxExemplo.Size = new System.Drawing.Size(440, 71);
			this.textBoxExemplo.TabIndex = 3;
			this.textBoxExemplo.Text = "";
			// 
			// btnApagar
			// 
			this.btnApagar.Location = new System.Drawing.Point(456, 165);
			this.btnApagar.Name = "btnApagar";
			this.btnApagar.Size = new System.Drawing.Size(94, 56);
			this.btnApagar.TabIndex = 5;
			this.btnApagar.Text = "Apagar";
			this.btnApagar.Click += new System.EventHandler(this.BtnApagarClick);
			// 
			// buttonCopiar
			// 
			this.buttonCopiar.Location = new System.Drawing.Point(358, 165);
			this.buttonCopiar.Name = "buttonCopiar";
			this.buttonCopiar.Size = new System.Drawing.Size(94, 56);
			this.buttonCopiar.TabIndex = 4;
			this.buttonCopiar.Text = "Copiar";
			this.buttonCopiar.Click += new System.EventHandler(this.ButtonCopiarClick);
			// 
			// btnGerar
			// 
			this.btnGerar.Location = new System.Drawing.Point(260, 165);
			this.btnGerar.Name = "btnGerar";
			this.btnGerar.Size = new System.Drawing.Size(94, 56);
			this.btnGerar.TabIndex = 3;
			this.btnGerar.Text = "Gerar";
			this.btnGerar.Click += new System.EventHandler(this.BtnGerarClick);
			// 
			// btnConfig
			// 
			this.btnConfig.Location = new System.Drawing.Point(498, 8);
			this.btnConfig.Name = "btnConfig";
			this.btnConfig.Size = new System.Drawing.Size(57, 22);
			this.btnConfig.TabIndex = 6;
			this.btnConfig.Text = "Config";
			this.btnConfig.Click += new System.EventHandler(this.BtnConfigClick);
			// 
			// textBoxCidades
			// 
			this.textBoxCidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCidades.Location = new System.Drawing.Point(110, 11);
			this.textBoxCidades.Name = "textBoxCidades";
			this.textBoxCidades.Size = new System.Drawing.Size(171, 22);
			this.textBoxCidades.TabIndex = 1;
			// 
			// textBoxOperadora
			// 
			this.textBoxOperadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxOperadora.FormattingEnabled = true;
			this.textBoxOperadora.Location = new System.Drawing.Point(110, 41);
			this.textBoxOperadora.Name = "textBoxOperadora";
			this.textBoxOperadora.Size = new System.Drawing.Size(171, 24);
			this.textBoxOperadora.TabIndex = 2;
			// 
			// MassivaForm
			// 
			this.ClientSize = new System.Drawing.Size(562, 236);
			this.Controls.Add(this.textBoxOperadora);
			this.Controls.Add(this.textBoxCidades);
			this.Controls.Add(this.btnConfig);
			this.Controls.Add(this.textBoxExemplo);
			this.Controls.Add(this.btnGerar);
			this.Controls.Add(this.buttonCopiar);
			this.Controls.Add(this.btnApagar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MassivaForm";
			this.Text = "Abertura de Massiva";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
