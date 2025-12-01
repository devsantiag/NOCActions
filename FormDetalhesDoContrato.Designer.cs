/*
 * Criado por SharpDevelop.
 * Usuário: fjstavares
 * Data: 21/11/2025
 * Hora: 14:46
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace NOC_Actions
{
	partial class FormDetalhesDoContrato
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label title_contratoNomeEInformacoes;
		private System.Windows.Forms.Panel panel1;
		
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
			this.title_contratoNomeEInformacoes = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// title_contratoNomeEInformacoes
			// 
			this.title_contratoNomeEInformacoes.AutoSize = true;
			this.title_contratoNomeEInformacoes.BackColor = System.Drawing.Color.Transparent;
			this.title_contratoNomeEInformacoes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title_contratoNomeEInformacoes.ForeColor = System.Drawing.Color.Black;
			this.title_contratoNomeEInformacoes.Location = new System.Drawing.Point(3, 9);
			this.title_contratoNomeEInformacoes.Name = "title_contratoNomeEInformacoes";
			this.title_contratoNomeEInformacoes.Size = new System.Drawing.Size(170, 32);
			this.title_contratoNomeEInformacoes.TabIndex = 2;
			this.title_contratoNomeEInformacoes.Text = "contratoNome";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkGray;
			this.panel1.Controls.Add(this.title_contratoNomeEInformacoes);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(766, 55);
			this.panel1.TabIndex = 3;
			// 
			// FormDetalhesDoContrato
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(766, 378);
			this.Controls.Add(this.panel1);
			this.Name = "FormDetalhesDoContrato";
			this.Text = "FormDetalhesDoContrato";
//			this.Load += new System.EventHandler(this.FormDetalhesDoContratoLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
