/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 01/02/2025
 * Time: 02:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NOCActions
{
	partial class UserConfig
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxAdicionarOperadora;
		private System.Windows.Forms.Button btnAdicionarOperadora;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxOperadoraJaAdicionadas;
		private System.Windows.Forms.Button btnDeletarOperadora;
		private System.Windows.Forms.Label label3;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxAdicionarOperadora = new System.Windows.Forms.TextBox();
			this.btnAdicionarOperadora = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxOperadoraJaAdicionadas = new System.Windows.Forms.ComboBox();
			this.btnDeletarOperadora = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Adicionar Operadora";
			// 
			// textBoxAdicionarOperadora
			// 
			this.textBoxAdicionarOperadora.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxAdicionarOperadora.Location = new System.Drawing.Point(168, 13);
			this.textBoxAdicionarOperadora.Name = "textBoxAdicionarOperadora";
			this.textBoxAdicionarOperadora.Size = new System.Drawing.Size(172, 22);
			this.textBoxAdicionarOperadora.TabIndex = 1;
			// 
			// btnAdicionarOperadora
			// 
			this.btnAdicionarOperadora.Location = new System.Drawing.Point(348, 13);
			this.btnAdicionarOperadora.Name = "btnAdicionarOperadora";
			this.btnAdicionarOperadora.Size = new System.Drawing.Size(77, 23);
			this.btnAdicionarOperadora.TabIndex = 2;
			this.btnAdicionarOperadora.Text = "Adicionar";
			this.btnAdicionarOperadora.UseVisualStyleBackColor = true;
			this.btnAdicionarOperadora.Click += new System.EventHandler(this.BtnAdicionarOperadoraClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Opers. adicionadas";
			// 
			// comboBoxOperadoraJaAdicionadas
			// 
			this.comboBoxOperadoraJaAdicionadas.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxOperadoraJaAdicionadas.FormattingEnabled = true;
			this.comboBoxOperadoraJaAdicionadas.Location = new System.Drawing.Point(168, 41);
			this.comboBoxOperadoraJaAdicionadas.Name = "comboBoxOperadoraJaAdicionadas";
			this.comboBoxOperadoraJaAdicionadas.Size = new System.Drawing.Size(172, 24);
			this.comboBoxOperadoraJaAdicionadas.TabIndex = 4;
			// 
			// btnDeletarOperadora
			// 
			this.btnDeletarOperadora.Location = new System.Drawing.Point(348, 39);
			this.btnDeletarOperadora.Name = "btnDeletarOperadora";
			this.btnDeletarOperadora.Size = new System.Drawing.Size(77, 23);
			this.btnDeletarOperadora.TabIndex = 5;
			this.btnDeletarOperadora.Text = "Deletar";
			this.btnDeletarOperadora.UseVisualStyleBackColor = true;
			this.btnDeletarOperadora.Click += new System.EventHandler(this.BtnDeletarOperadoraClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(0, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(505, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "_______________________________________________________________________";
			// 
			// UserConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 93);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnDeletarOperadora);
			this.Controls.Add(this.comboBoxOperadoraJaAdicionadas);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnAdicionarOperadora);
			this.Controls.Add(this.textBoxAdicionarOperadora);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "UserConfig";
			this.Text = "Configurações";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
