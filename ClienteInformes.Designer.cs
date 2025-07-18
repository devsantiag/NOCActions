/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 16/07/2025
 * Time: 08:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NOC_Actions
{
	partial class ClienteInformes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnAberturaDeReparo;
		private System.Windows.Forms.Button btnInformeDeReparo;
		private System.Windows.Forms.Button btnLiberacaoDeAcesso;
		private System.Windows.Forms.Button btnLibAcessoComPrevisao;
		private System.Windows.Forms.Button btnAnaliseDeEnergia;
		private System.Windows.Forms.Button btnInformeDeAbertura;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAberturaDeReparo = new System.Windows.Forms.Button();
			this.btnInformeDeReparo = new System.Windows.Forms.Button();
			this.btnLiberacaoDeAcesso = new System.Windows.Forms.Button();
			this.btnLibAcessoComPrevisao = new System.Windows.Forms.Button();
			this.btnAnaliseDeEnergia = new System.Windows.Forms.Button();
			this.btnInformeDeAbertura = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAberturaDeReparo
			// 
			this.btnAberturaDeReparo.Location = new System.Drawing.Point(5, 5);
			this.btnAberturaDeReparo.Name = "btnAberturaDeReparo";
			this.btnAberturaDeReparo.Size = new System.Drawing.Size(170, 23);
			this.btnAberturaDeReparo.TabIndex = 0;
			this.btnAberturaDeReparo.Text = "Abertura de Reparo";
			this.btnAberturaDeReparo.UseVisualStyleBackColor = true;
			// btnInformeDeReparo
			// 
			this.btnInformeDeReparo.Location = new System.Drawing.Point(5, 34);
			this.btnInformeDeReparo.Name = "btnInformeDeReparo";
			this.btnInformeDeReparo.Size = new System.Drawing.Size(170, 23);
			this.btnInformeDeReparo.TabIndex = 1;
			this.btnInformeDeReparo.Text = "Informe de Reparo";
			this.btnInformeDeReparo.UseVisualStyleBackColor = true;
			// 
			// btnLiberacaoDeAcesso
			// 
			this.btnLiberacaoDeAcesso.Location = new System.Drawing.Point(5, 63);
			this.btnLiberacaoDeAcesso.Name = "btnLiberacaoDeAcesso";
			this.btnLiberacaoDeAcesso.Size = new System.Drawing.Size(170, 23);
			this.btnLiberacaoDeAcesso.TabIndex = 2;
			this.btnLiberacaoDeAcesso.Text = "Liberação de Acesso";
			this.btnLiberacaoDeAcesso.UseVisualStyleBackColor = true;
			// 
			// btnLibAcessoComPrevisao
			// 
			this.btnLibAcessoComPrevisao.Location = new System.Drawing.Point(5, 92);
			this.btnLibAcessoComPrevisao.Name = "btnLibAcessoComPrevisao";
			this.btnLibAcessoComPrevisao.Size = new System.Drawing.Size(170, 23);
			this.btnLibAcessoComPrevisao.TabIndex = 3;
			this.btnLibAcessoComPrevisao.Text = "Lib. Acesso com Previsão";
			this.btnLibAcessoComPrevisao.UseVisualStyleBackColor = true;
			// 
			// btnAnaliseDeEnergia
			// 
			this.btnAnaliseDeEnergia.Location = new System.Drawing.Point(5, 121);
			this.btnAnaliseDeEnergia.Name = "btnAnaliseDeEnergia";
			this.btnAnaliseDeEnergia.Size = new System.Drawing.Size(170, 23);
			this.btnAnaliseDeEnergia.TabIndex = 4;
			this.btnAnaliseDeEnergia.Text = "Análise de Energia";
			this.btnAnaliseDeEnergia.UseVisualStyleBackColor = true;
			// 
			// btnInformeDeAbertura
			// 
			this.btnInformeDeAbertura.Location = new System.Drawing.Point(5, 150);
			this.btnInformeDeAbertura.Name = "btnInformeDeAbertura";
			this.btnInformeDeAbertura.Size = new System.Drawing.Size(170, 23);
			this.btnInformeDeAbertura.TabIndex = 5;
			this.btnInformeDeAbertura.Text = "Informe de Abertura";
			this.btnInformeDeAbertura.UseVisualStyleBackColor = true;
			// 
			// ClienteInformes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(596, 394);
			this.Controls.Add(this.btnInformeDeAbertura);
			this.Controls.Add(this.btnAnaliseDeEnergia);
			this.Controls.Add(this.btnLibAcessoComPrevisao);
			this.Controls.Add(this.btnLiberacaoDeAcesso);
			this.Controls.Add(this.btnInformeDeReparo);
			this.Controls.Add(this.btnAberturaDeReparo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ClienteInformes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cliente Informes";
			this.ResumeLayout(false);

		}
	}
}
