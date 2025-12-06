/*
 * Criado por SharpDevelop.
 * Usuário: fjstavares
 * Data: 05/12/2025
 * Hora: 12:13
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace NOC_Actions
{
	partial class AvisosSolicitacoesAoCliente
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label_login_username;
		private System.Windows.Forms.Button button5;
		
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label_login_username = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.button5);
			this.splitContainer1.Panel1.Controls.Add(this.label_login_username);
			this.splitContainer1.Panel1.Controls.Add(this.button4);
			this.splitContainer1.Panel1.Controls.Add(this.button2);
			this.splitContainer1.Panel1.Controls.Add(this.button1);
			this.splitContainer1.Size = new System.Drawing.Size(745, 380);
			this.splitContainer1.SplitterDistance = 248;
			this.splitContainer1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Top;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(248, 27);
			this.button1.TabIndex = 0;
			this.button1.Text = "Análise de Infra";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Top;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.button2.Location = new System.Drawing.Point(0, 27);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(248, 27);
			this.button2.TabIndex = 1;
			this.button2.Text = "Liberação de Acesso";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Dock = System.Windows.Forms.DockStyle.Top;
			this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.button4.Location = new System.Drawing.Point(0, 54);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(248, 27);
			this.button4.TabIndex = 3;
			this.button4.Text = "Possível queda de Energia";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// label_login_username
			// 
			this.label_login_username.AutoSize = true;
			this.label_login_username.BackColor = System.Drawing.Color.Transparent;
			this.label_login_username.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label_login_username.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label_login_username.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label_login_username.Location = new System.Drawing.Point(0, 363);
			this.label_login_username.Name = "label_login_username";
			this.label_login_username.Size = new System.Drawing.Size(68, 17);
			this.label_login_username.TabIndex = 4;
			this.label_login_username.Text = "userName";
			// 
			// button5
			// 
			this.button5.Dock = System.Windows.Forms.DockStyle.Top;
			this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.button5.Location = new System.Drawing.Point(0, 81);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(248, 27);
			this.button5.TabIndex = 5;
			this.button5.Text = "Bloqueio Financeiro";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// AvisosSolicitacoesAoCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(745, 380);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AvisosSolicitacoesAoCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AvisosSolicitacoesAoCliente";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
