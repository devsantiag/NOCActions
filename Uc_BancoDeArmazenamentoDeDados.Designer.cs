/*
 * Criado por SharpDevelop.
 * Usuário: fjstavares
 * Data: 15/11/2025
 * Hora: 23:25
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace NOC_Actions
{
	partial class Uc_BancoDeArmazenamentoDeDados
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox listBox1_Operadoras;
		private System.Windows.Forms.ListBox listBox2_Cliente;
		private System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Button btnExportarDados;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		
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
            this.listBox1_Operadoras = new System.Windows.Forms.ListBox();
            this.listBox2_Cliente = new System.Windows.Forms.ListBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExportarDados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1_Operadoras
            // 
            this.listBox1_Operadoras.FormattingEnabled = true;
            this.listBox1_Operadoras.ItemHeight = 16;
            this.listBox1_Operadoras.Location = new System.Drawing.Point(77, 82);
            this.listBox1_Operadoras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1_Operadoras.Name = "listBox1_Operadoras";
            this.listBox1_Operadoras.Size = new System.Drawing.Size(559, 580);
            this.listBox1_Operadoras.TabIndex = 0;
            // 
            // listBox2_Cliente
            // 
            this.listBox2_Cliente.FormattingEnabled = true;
            this.listBox2_Cliente.ItemHeight = 16;
            this.listBox2_Cliente.Location = new System.Drawing.Point(645, 82);
            this.listBox2_Cliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox2_Cliente.Name = "listBox2_Cliente";
            this.listBox2_Cliente.Size = new System.Drawing.Size(559, 580);
            this.listBox2_Cliente.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(992, 670);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(212, 70);
            this.btnFechar.TabIndex = 46;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFecharClick);
            // 
            // btnExportarDados
            // 
            this.btnExportarDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarDados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarDados.Location = new System.Drawing.Point(718, 670);
            this.btnExportarDados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportarDados.Name = "btnExportarDados";
            this.btnExportarDados.Size = new System.Drawing.Size(264, 70);
            this.btnExportarDados.TabIndex = 47;
            this.btnExportarDados.Text = "Exportar ";
            this.btnExportarDados.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(77, 670);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "_______________________________________________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(77, 686);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(560, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "_______________________________________________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(77, 702);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(560, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "_______________________________________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(77, 718);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(560, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "_______________________________________________________________________________";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 22);
            this.textBox1.TabIndex = 52;
            // 
            // Uc_BancoDeArmazenamentoDeDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 757);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportarDados);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.listBox2_Cliente);
            this.Controls.Add(this.listBox1_Operadoras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Uc_BancoDeArmazenamentoDeDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.TextBox textBox1;
    }
}
