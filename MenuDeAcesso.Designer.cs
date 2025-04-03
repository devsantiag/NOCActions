/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 26/02/2025
 * Time: 15:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NOCActions
{
	partial class MenuDeAcesso
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1AcaoAberturaDeMassiva;
//		private System.Windows.Forms.Button buttonAvaliacaoComCliente;
		private System.Windows.Forms.Button button3AberturaDeReparo;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button buttonComunicacaoComCliente;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			this.button1AcaoAberturaDeMassiva = new System.Windows.Forms.Button();
			this.button3AberturaDeReparo = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.buttonComunicacaoComCliente = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1AcaoAberturaDeMassiva
			// 
			this.button1AcaoAberturaDeMassiva.Font = new System.Drawing.Font("Arial", 9F);
			this.button1AcaoAberturaDeMassiva.Location = new System.Drawing.Point(3, 3);
			this.button1AcaoAberturaDeMassiva.Name = "button1AcaoAberturaDeMassiva";
			this.button1AcaoAberturaDeMassiva.Size = new System.Drawing.Size(97, 71);
			this.button1AcaoAberturaDeMassiva.TabIndex = 0;
			this.button1AcaoAberturaDeMassiva.Text = "Massiva";
			this.button1AcaoAberturaDeMassiva.UseVisualStyleBackColor = true;
			this.button1AcaoAberturaDeMassiva.Click += new System.EventHandler(this.Button1AcaoAberturaDeMassivaClick);
			// 
			// button3AberturaDeReparo
			// 
			this.button3AberturaDeReparo.Font = new System.Drawing.Font("Arial", 9F);
			this.button3AberturaDeReparo.Location = new System.Drawing.Point(209, 3);
			this.button3AberturaDeReparo.Name = "button3AberturaDeReparo";
			this.button3AberturaDeReparo.Size = new System.Drawing.Size(97, 71);
			this.button3AberturaDeReparo.TabIndex = 2;
			this.button3AberturaDeReparo.Text = "Abertura de Reparo - (E-mail)";
			this.button3AberturaDeReparo.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Arial", 9F);
			this.button4.Location = new System.Drawing.Point(3, 80);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(97, 71);
			this.button4.TabIndex = 3;
			this.button4.Text = "Ação";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Arial", 9F);
			this.button5.Location = new System.Drawing.Point(106, 80);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(97, 71);
			this.button5.TabIndex = 4;
			this.button5.Text = "Ação";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Arial", 9F);
			this.button6.Location = new System.Drawing.Point(209, 80);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(97, 71);
			this.button6.TabIndex = 5;
			this.button6.Text = "Ação";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// buttonComunicacaoComCliente
			// 
			this.buttonComunicacaoComCliente.Font = new System.Drawing.Font("Arial", 9F);
			this.buttonComunicacaoComCliente.Location = new System.Drawing.Point(106, 3);
			this.buttonComunicacaoComCliente.Name = "buttonComunicacaoComCliente";
			this.buttonComunicacaoComCliente.Size = new System.Drawing.Size(97, 71);
			this.buttonComunicacaoComCliente.TabIndex = 6;
			this.buttonComunicacaoComCliente.Text = "Comunicar Cliente";
			this.buttonComunicacaoComCliente.UseVisualStyleBackColor = true;
			this.buttonComunicacaoComCliente.Click += new System.EventHandler(this.ButtonComunicacaoComClienteClick);
			// 
			// MenuDeAcesso
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(309, 154);
			this.Controls.Add(this.buttonComunicacaoComCliente);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3AberturaDeReparo);
			this.Controls.Add(this.button1AcaoAberturaDeMassiva);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MenuDeAcesso";
			this.Text = "Menu - Ações Específicas";
			this.ResumeLayout(false);

		}
	}
}
