namespace NOC_Actions
{
	partial class UcRegistroDeOcorrenciaInterna
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox listBox_RegistroDeOcorrencia;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDeletarLista;
		private System.Windows.Forms.Button btnCloseWindow;
		private System.Windows.Forms.Button btnSalvarContratoEOperadora;
		private System.Windows.Forms.Button btnDeletarSelecionado;
		private System.Windows.Forms.TextBox textBox_UnidadeContrato;
		private System.Windows.Forms.TextBox textBox_OperadoraDaUnidade;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_observacaoDoContrato;
		private System.Windows.Forms.Label label5;
		
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
            this.listBox_RegistroDeOcorrencia = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeletarLista = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.btnSalvarContratoEOperadora = new System.Windows.Forms.Button();
            this.btnDeletarSelecionado = new System.Windows.Forms.Button();
            this.textBox_UnidadeContrato = new System.Windows.Forms.TextBox();
            this.textBox_OperadoraDaUnidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_observacaoDoContrato = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_RegistroDeOcorrencia
            // 
            this.listBox_RegistroDeOcorrencia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_RegistroDeOcorrencia.FormattingEnabled = true;
            this.listBox_RegistroDeOcorrencia.ItemHeight = 21;
            this.listBox_RegistroDeOcorrencia.Location = new System.Drawing.Point(0, 186);
            this.listBox_RegistroDeOcorrencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_RegistroDeOcorrencia.Name = "listBox_RegistroDeOcorrencia";
            this.listBox_RegistroDeOcorrencia.Size = new System.Drawing.Size(625, 151);
            this.listBox_RegistroDeOcorrencia.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reincidência de Falha";
            // 
            // btnDeletarLista
            // 
            this.btnDeletarLista.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletarLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletarLista.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDeletarLista.ForeColor = System.Drawing.Color.Black;
            this.btnDeletarLista.Location = new System.Drawing.Point(204, 388);
            this.btnDeletarLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeletarLista.Name = "btnDeletarLista";
            this.btnDeletarLista.Size = new System.Drawing.Size(128, 54);
            this.btnDeletarLista.TabIndex = 7;
            this.btnDeletarLista.Text = "Deletar Lista";
            this.btnDeletarLista.UseVisualStyleBackColor = false;
            this.btnDeletarLista.Click += new System.EventHandler(this.BtnDeletarListaClick);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseWindow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCloseWindow.ForeColor = System.Drawing.Color.Black;
            this.btnCloseWindow.Location = new System.Drawing.Point(45, 388);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(128, 54);
            this.btnCloseWindow.TabIndex = 6;
            this.btnCloseWindow.Text = "Fechar";
            this.btnCloseWindow.UseVisualStyleBackColor = false;
            this.btnCloseWindow.Click += new System.EventHandler(this.BtnCloseWindowClick);
            // 
            // btnSalvarContratoEOperadora
            // 
            this.btnSalvarContratoEOperadora.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarContratoEOperadora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarContratoEOperadora.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSalvarContratoEOperadora.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarContratoEOperadora.Location = new System.Drawing.Point(476, 388);
            this.btnSalvarContratoEOperadora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvarContratoEOperadora.Name = "btnSalvarContratoEOperadora";
            this.btnSalvarContratoEOperadora.Size = new System.Drawing.Size(128, 54);
            this.btnSalvarContratoEOperadora.TabIndex = 4;
            this.btnSalvarContratoEOperadora.Text = "Gravar e Copiar";
            this.btnSalvarContratoEOperadora.UseVisualStyleBackColor = false;
            this.btnSalvarContratoEOperadora.Click += new System.EventHandler(this.BtnSaveAndCopyClick);
            // 
            // btnDeletarSelecionado
            // 
            this.btnDeletarSelecionado.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletarSelecionado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletarSelecionado.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDeletarSelecionado.ForeColor = System.Drawing.Color.Black;
            this.btnDeletarSelecionado.Location = new System.Drawing.Point(340, 388);
            this.btnDeletarSelecionado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeletarSelecionado.Name = "btnDeletarSelecionado";
            this.btnDeletarSelecionado.Size = new System.Drawing.Size(128, 54);
            this.btnDeletarSelecionado.TabIndex = 5;
            this.btnDeletarSelecionado.Text = "Deletar";
            this.btnDeletarSelecionado.UseVisualStyleBackColor = false;
            this.btnDeletarSelecionado.Click += new System.EventHandler(this.BtnDeletarSelecionadoClick);
            // 
            // textBox_UnidadeContrato
            // 
            this.textBox_UnidadeContrato.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBox_UnidadeContrato.Location = new System.Drawing.Point(12, 54);
            this.textBox_UnidadeContrato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_UnidadeContrato.Name = "textBox_UnidadeContrato";
            this.textBox_UnidadeContrato.Size = new System.Drawing.Size(295, 29);
            this.textBox_UnidadeContrato.TabIndex = 0;
            // 
            // textBox_OperadoraDaUnidade
            // 
            this.textBox_OperadoraDaUnidade.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBox_OperadoraDaUnidade.Location = new System.Drawing.Point(319, 54);
            this.textBox_OperadoraDaUnidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_OperadoraDaUnidade.Name = "textBox_OperadoraDaUnidade";
            this.textBox_OperadoraDaUnidade.Size = new System.Drawing.Size(295, 29);
            this.textBox_OperadoraDaUnidade.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Unidade / Contrato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(319, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Operadora / Circuito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(3, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(654, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "_________________________________________________________________________________" +
    "___________";
            // 
            // textBox_observacaoDoContrato
            // 
            this.textBox_observacaoDoContrato.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBox_observacaoDoContrato.Location = new System.Drawing.Point(0, 119);
            this.textBox_observacaoDoContrato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_observacaoDoContrato.Multiline = true;
            this.textBox_observacaoDoContrato.Name = "textBox_observacaoDoContrato";
            this.textBox_observacaoDoContrato.Size = new System.Drawing.Size(625, 62);
            this.textBox_observacaoDoContrato.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Observação";
            // 
            // UcRegistroDeOcorrenciaInterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_observacaoDoContrato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_OperadoraDaUnidade);
            this.Controls.Add(this.textBox_UnidadeContrato);
            this.Controls.Add(this.btnDeletarLista);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.btnSalvarContratoEOperadora);
            this.Controls.Add(this.btnDeletarSelecionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_RegistroDeOcorrencia);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UcRegistroDeOcorrenciaInterna";
            this.Size = new System.Drawing.Size(627, 468);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
