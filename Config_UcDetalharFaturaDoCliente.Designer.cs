namespace NOC_Actions
{
	partial class Config_UcDetalharFaturaDoCliente
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox textBox_TipoDeOperadoraComPendencia;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		
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
			this.btnVoltar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_TipoDeOperadoraComPendencia = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnVoltar
			// 
			this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnVoltar.Location = new System.Drawing.Point(366, 326);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(96, 44);
			this.btnVoltar.TabIndex = 14;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(1, 292);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(469, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "_____________________________________________________________________________";
			// 
			// textBox_TipoDeOperadoraComPendencia
			// 
			this.textBox_TipoDeOperadoraComPendencia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.textBox_TipoDeOperadoraComPendencia.FormattingEnabled = true;
			this.textBox_TipoDeOperadoraComPendencia.Location = new System.Drawing.Point(135, 40);
			this.textBox_TipoDeOperadoraComPendencia.Name = "textBox_TipoDeOperadoraComPendencia";
			this.textBox_TipoDeOperadoraComPendencia.Size = new System.Drawing.Size(228, 25);
			this.textBox_TipoDeOperadoraComPendencia.TabIndex = 29;
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(135, 71);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(228, 25);
			this.comboBox1.TabIndex = 30;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label7.Location = new System.Drawing.Point(13, 43);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 17);
			this.label7.TabIndex = 31;
			this.label7.Text = "Operadora";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label9.Location = new System.Drawing.Point(13, 74);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(118, 17);
			this.label9.TabIndex = 32;
			this.label9.Text = "Status do Contrato";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.button1.Location = new System.Drawing.Point(374, 39);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(74, 25);
			this.button1.TabIndex = 33;
			this.button1.Text = "Salvar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.button2.Location = new System.Drawing.Point(374, 72);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(74, 25);
			this.button2.TabIndex = 34;
			this.button2.Text = "Salvar";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Config_UcDetalharFaturaDoCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox_TipoDeOperadoraComPendencia);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnVoltar);
			this.Name = "Config_UcDetalharFaturaDoCliente";
			this.Size = new System.Drawing.Size(470, 380);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
