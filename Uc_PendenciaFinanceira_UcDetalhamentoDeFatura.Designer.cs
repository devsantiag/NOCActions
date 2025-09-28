/*
 * Criado por SharpDevelop.
 * Usuário: fjstavares
 * Data: 28/09/2025
 * Hora: 14:40
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace NOC_Actions
{
	partial class Uc_PendenciaFinanceira_UcDetalhamentoDeFatura
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(469, 65);
			this.label1.TabIndex = 1000000000;
			this.label1.Text = "Esta página foi criada para que você possa consultar e acompanhar as pendências f" +
	"inanceiras do contrato da unidade selecionada.";
			// 
			// Uc_PendenciaFinanceira_UcDetalhamentoDeFatura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.label1);
			this.Name = "Uc_PendenciaFinanceira_UcDetalhamentoDeFatura";
			this.Size = new System.Drawing.Size(470, 380);
			this.ResumeLayout(false);

		}
	}
}
