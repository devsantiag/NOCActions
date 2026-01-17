/*
 * Criado por SharpDevelop.
 * Usuário: fjstavares
 * Data: 06/12/2025
 * Hora: 13:39
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace NOC_Actions
{
	partial class Uc_BloqueioFinanceiro
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnCloseWindow;
		private System.Windows.Forms.Button btnSalvarECopiar;
		private System.Windows.Forms.Button btnApagarCampos;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comboBox_enderecoRespectivoDoBloqueioFinanceiro;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox_unidadeComBloqueioFinanceiro;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox_operadoraComBloqueioFinanceiro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.MaskedTextBox maskedTextBox_horarioQueda;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_dataDaReferencia;
        private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		
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
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.btnSalvarECopiar = new System.Windows.Forms.Button();
            this.btnApagarCampos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_unidadeComBloqueioFinanceiro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_enderecoRespectivoDoBloqueioFinanceiro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_operadoraComBloqueioFinanceiro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBox_horarioQueda = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_dataDaReferencia = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBox_valorAPagar = new System.Windows.Forms.MaskedTextBox();
            this.bntExcluirSelecionado = new System.Windows.Forms.Button();
            this.btnExcluirTudoDasListas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mensagem - Bloqueio Financeiro";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnVisualizar.ForeColor = System.Drawing.Color.Black;
            this.btnVisualizar.Location = new System.Drawing.Point(345, 394);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(128, 54);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseWindow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCloseWindow.ForeColor = System.Drawing.Color.Black;
            this.btnCloseWindow.Location = new System.Drawing.Point(49, 394);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(128, 54);
            this.btnCloseWindow.TabIndex = 8;
            this.btnCloseWindow.Text = "Fechar";
            this.btnCloseWindow.UseVisualStyleBackColor = false;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // btnSalvarECopiar
            // 
            this.btnSalvarECopiar.AutoSize = true;
            this.btnSalvarECopiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnSalvarECopiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarECopiar.FlatAppearance.BorderSize = 0;
            this.btnSalvarECopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarECopiar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSalvarECopiar.ForeColor = System.Drawing.Color.White;
            this.btnSalvarECopiar.Location = new System.Drawing.Point(480, 394);
            this.btnSalvarECopiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarECopiar.Name = "btnSalvarECopiar";
            this.btnSalvarECopiar.Size = new System.Drawing.Size(143, 54);
            this.btnSalvarECopiar.TabIndex = 6;
            this.btnSalvarECopiar.Text = "Gravar e Copiar";
            this.btnSalvarECopiar.UseVisualStyleBackColor = false;
            this.btnSalvarECopiar.Click += new System.EventHandler(this.btnSalvarECopiar_Click);
            // 
            // btnApagarCampos
            // 
            this.btnApagarCampos.BackColor = System.Drawing.Color.Transparent;
            this.btnApagarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagarCampos.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnApagarCampos.ForeColor = System.Drawing.Color.Black;
            this.btnApagarCampos.Location = new System.Drawing.Point(185, 394);
            this.btnApagarCampos.Margin = new System.Windows.Forms.Padding(4);
            this.btnApagarCampos.Name = "btnApagarCampos";
            this.btnApagarCampos.Size = new System.Drawing.Size(152, 54);
            this.btnApagarCampos.TabIndex = 9;
            this.btnApagarCampos.Text = "Apagar campos";
            this.btnApagarCampos.UseVisualStyleBackColor = false;
            this.btnApagarCampos.Click += new System.EventHandler(this.btnApagarCampos_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(1, 352);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(654, 23);
            this.label8.TabIndex = 68;
            this.label8.Text = "_________________________________________________________________________________" +
    "___________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(19, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 69;
            this.label2.Text = "Dados do Evento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(19, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 23);
            this.label5.TabIndex = 79;
            this.label5.Text = "Valor a Pagar";
            // 
            // comboBox_unidadeComBloqueioFinanceiro
            // 
            this.comboBox_unidadeComBloqueioFinanceiro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_unidadeComBloqueioFinanceiro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_unidadeComBloqueioFinanceiro.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBox_unidadeComBloqueioFinanceiro.FormattingEnabled = true;
            this.comboBox_unidadeComBloqueioFinanceiro.Location = new System.Drawing.Point(172, 70);
            this.comboBox_unidadeComBloqueioFinanceiro.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_unidadeComBloqueioFinanceiro.Name = "comboBox_unidadeComBloqueioFinanceiro";
            this.comboBox_unidadeComBloqueioFinanceiro.Size = new System.Drawing.Size(435, 29);
            this.comboBox_unidadeComBloqueioFinanceiro.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(19, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 73;
            this.label6.Text = "Unidade";
            // 
            // comboBox_enderecoRespectivoDoBloqueioFinanceiro
            // 
            this.comboBox_enderecoRespectivoDoBloqueioFinanceiro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_enderecoRespectivoDoBloqueioFinanceiro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_enderecoRespectivoDoBloqueioFinanceiro.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBox_enderecoRespectivoDoBloqueioFinanceiro.FormattingEnabled = true;
            this.comboBox_enderecoRespectivoDoBloqueioFinanceiro.Location = new System.Drawing.Point(172, 108);
            this.comboBox_enderecoRespectivoDoBloqueioFinanceiro.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_enderecoRespectivoDoBloqueioFinanceiro.Name = "comboBox_enderecoRespectivoDoBloqueioFinanceiro";
            this.comboBox_enderecoRespectivoDoBloqueioFinanceiro.Size = new System.Drawing.Size(435, 29);
            this.comboBox_enderecoRespectivoDoBloqueioFinanceiro.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(19, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 82;
            this.label3.Text = "Endereço";
            // 
            // comboBox_operadoraComBloqueioFinanceiro
            // 
            this.comboBox_operadoraComBloqueioFinanceiro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_operadoraComBloqueioFinanceiro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_operadoraComBloqueioFinanceiro.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBox_operadoraComBloqueioFinanceiro.FormattingEnabled = true;
            this.comboBox_operadoraComBloqueioFinanceiro.Location = new System.Drawing.Point(172, 146);
            this.comboBox_operadoraComBloqueioFinanceiro.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_operadoraComBloqueioFinanceiro.Name = "comboBox_operadoraComBloqueioFinanceiro";
            this.comboBox_operadoraComBloqueioFinanceiro.Size = new System.Drawing.Size(435, 29);
            this.comboBox_operadoraComBloqueioFinanceiro.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(19, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 84;
            this.label4.Text = "Operadora(a)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label7.Location = new System.Drawing.Point(19, 242);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 23);
            this.label7.TabIndex = 87;
            this.label7.Text = "Informações da Queda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label9.Location = new System.Drawing.Point(19, 283);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 23);
            this.label9.TabIndex = 88;
            this.label9.Text = "Hr. Queda";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label10.Location = new System.Drawing.Point(19, 318);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 23);
            this.label10.TabIndex = 89;
            this.label10.Text = "Dt. Ref.";
            // 
            // maskedTextBox_horarioQueda
            // 
            this.maskedTextBox_horarioQueda.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.maskedTextBox_horarioQueda.Location = new System.Drawing.Point(116, 280);
            this.maskedTextBox_horarioQueda.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox_horarioQueda.Mask = "00:00";
            this.maskedTextBox_horarioQueda.Name = "maskedTextBox_horarioQueda";
            this.maskedTextBox_horarioQueda.Size = new System.Drawing.Size(135, 29);
            this.maskedTextBox_horarioQueda.TabIndex = 4;
            this.maskedTextBox_horarioQueda.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_dataDaReferencia
            // 
            this.maskedTextBox_dataDaReferencia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.maskedTextBox_dataDaReferencia.Location = new System.Drawing.Point(116, 315);
            this.maskedTextBox_dataDaReferencia.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox_dataDaReferencia.Mask = "00/00/0000";
            this.maskedTextBox_dataDaReferencia.Name = "maskedTextBox_dataDaReferencia";
            this.maskedTextBox_dataDaReferencia.Size = new System.Drawing.Size(135, 29);
            this.maskedTextBox_dataDaReferencia.TabIndex = 5;
            this.maskedTextBox_dataDaReferencia.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(217, 242);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(409, 23);
            this.label11.TabIndex = 92;
            this.label11.Text = "_________________________________________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(175, 32);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(451, 23);
            this.label12.TabIndex = 93;
            this.label12.Text = "_______________________________________________________________";
            // 
            // maskedTextBox_valorAPagar
            // 
            this.maskedTextBox_valorAPagar.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox_valorAPagar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.maskedTextBox_valorAPagar.Location = new System.Drawing.Point(172, 188);
            this.maskedTextBox_valorAPagar.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox_valorAPagar.Name = "maskedTextBox_valorAPagar";
            this.maskedTextBox_valorAPagar.Size = new System.Drawing.Size(107, 29);
            this.maskedTextBox_valorAPagar.TabIndex = 3;
            // 
            // bntExcluirSelecionado
            // 
            this.bntExcluirSelecionado.AutoSize = true;
            this.bntExcluirSelecionado.BackColor = System.Drawing.Color.Transparent;
            this.bntExcluirSelecionado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntExcluirSelecionado.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bntExcluirSelecionado.ForeColor = System.Drawing.Color.Black;
            this.bntExcluirSelecionado.Location = new System.Drawing.Point(443, 269);
            this.bntExcluirSelecionado.Margin = new System.Windows.Forms.Padding(4);
            this.bntExcluirSelecionado.Name = "bntExcluirSelecionado";
            this.bntExcluirSelecionado.Size = new System.Drawing.Size(164, 33);
            this.bntExcluirSelecionado.TabIndex = 10;
            this.bntExcluirSelecionado.Text = "Excluir selecionado";
            this.bntExcluirSelecionado.UseVisualStyleBackColor = false;
            this.bntExcluirSelecionado.Click += new System.EventHandler(this.bntExcluirSelecionado_Click);
            // 
            // btnExcluirTudoDasListas
            // 
            this.btnExcluirTudoDasListas.AutoSize = true;
            this.btnExcluirTudoDasListas.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirTudoDasListas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirTudoDasListas.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnExcluirTudoDasListas.ForeColor = System.Drawing.Color.Black;
            this.btnExcluirTudoDasListas.Location = new System.Drawing.Point(494, 308);
            this.btnExcluirTudoDasListas.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirTudoDasListas.Name = "btnExcluirTudoDasListas";
            this.btnExcluirTudoDasListas.Size = new System.Drawing.Size(113, 33);
            this.btnExcluirTudoDasListas.TabIndex = 11;
            this.btnExcluirTudoDasListas.Text = "Excluir tudo";
            this.btnExcluirTudoDasListas.UseVisualStyleBackColor = false;
            this.btnExcluirTudoDasListas.Click += new System.EventHandler(this.btnExcluirTudoDasListas_Click);
            // 
            // Uc_BloqueioFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnExcluirTudoDasListas);
            this.Controls.Add(this.bntExcluirSelecionado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.maskedTextBox_dataDaReferencia);
            this.Controls.Add(this.maskedTextBox_horarioQueda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedTextBox_valorAPagar);
            this.Controls.Add(this.comboBox_operadoraComBloqueioFinanceiro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_enderecoRespectivoDoBloqueioFinanceiro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_unidadeComBloqueioFinanceiro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.btnSalvarECopiar);
            this.Controls.Add(this.btnApagarCampos);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Uc_BloqueioFinanceiro";
            this.Size = new System.Drawing.Size(627, 468);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.MaskedTextBox maskedTextBox_valorAPagar;
        private System.Windows.Forms.Button bntExcluirSelecionado;
        private System.Windows.Forms.Button btnExcluirTudoDasListas;
    }
}
