/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 21/07/2025
 * Time: 10:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NOC_Actions
{
	partial class UcPendenciaFinanceiraInformes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBoxUnidadeComPendenciaFinanceira;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSaveAndCopy;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnClearFields;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCloseWindow;
		private System.Windows.Forms.CheckBox checkBoxDetalharFatura;
		private System.Windows.Forms.Button btnViewInvoiceDetails;
		private System.Windows.Forms.Label txtLabel_campoDeAviso;
		private System.Windows.Forms.Button btnDeletarItemSelecionadoDaLista;
		private System.Windows.Forms.Button btnDeletarListaCompleta;
		private System.Windows.Forms.CheckBox checkEditarCampoUnidade;
		private System.Windows.Forms.Label labelEditarCampoUnidade;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label_modoDiretorAtivado;
		
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveAndCopy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.checkBoxDetalharFatura = new System.Windows.Forms.CheckBox();
            this.btnViewInvoiceDetails = new System.Windows.Forms.Button();
            this.comboBoxUnidadeComPendenciaFinanceira = new System.Windows.Forms.ComboBox();
            this.txtLabel_campoDeAviso = new System.Windows.Forms.Label();
            this.btnDeletarItemSelecionadoDaLista = new System.Windows.Forms.Button();
            this.btnDeletarListaCompleta = new System.Windows.Forms.Button();
            this.checkEditarCampoUnidade = new System.Windows.Forms.CheckBox();
            this.labelEditarCampoUnidade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_modoDiretorAtivado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(105, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 35;
            this.label6.Text = "Unidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(455, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "________________________________________________________________";
            // 
            // btnSaveAndCopy
            // 
            this.btnSaveAndCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAndCopy.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSaveAndCopy.Location = new System.Drawing.Point(476, 388);
            this.btnSaveAndCopy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveAndCopy.Name = "btnSaveAndCopy";
            this.btnSaveAndCopy.Size = new System.Drawing.Size(128, 54);
            this.btnSaveAndCopy.TabIndex = 1;
            this.btnSaveAndCopy.Text = "Gravar e Copiar";
            this.btnSaveAndCopy.UseVisualStyleBackColor = true;
            this.btnSaveAndCopy.Click += new System.EventHandler(this.BtnSaveAndCopyClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(4, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Mensagem a ser exibida";
            // 
            // btnClearFields
            // 
            this.btnClearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearFields.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnClearFields.Location = new System.Drawing.Point(340, 388);
            this.btnClearFields.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(128, 54);
            this.btnClearFields.TabIndex = 3;
            this.btnClearFields.Text = "Apagar";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.BtnClearFieldsClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 43);
            this.label1.TabIndex = 26;
            this.label1.Text = "Prezados, identificamos a existência de um bloqueio de caráter administrativo-fin" +
    "anceiro no contrato da unidade [UNIDADE].";
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseWindow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCloseWindow.Location = new System.Drawing.Point(45, 388);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(128, 54);
            this.btnCloseWindow.TabIndex = 4;
            this.btnCloseWindow.Text = "Fechar";
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.BtnCloseWindowClick);
            // 
            // checkBoxDetalharFatura
            // 
            this.checkBoxDetalharFatura.AutoSize = true;
            this.checkBoxDetalharFatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxDetalharFatura.Location = new System.Drawing.Point(48, 240);
            this.checkBoxDetalharFatura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxDetalharFatura.Name = "checkBoxDetalharFatura";
            this.checkBoxDetalharFatura.Size = new System.Drawing.Size(18, 17);
            this.checkBoxDetalharFatura.TabIndex = 39;
            this.checkBoxDetalharFatura.UseVisualStyleBackColor = true;
            this.checkBoxDetalharFatura.CheckedChanged += new System.EventHandler(this.checkBoxDetalharFatura_CheckedChanged);
            // 
            // btnViewInvoiceDetails
            // 
            this.btnViewInvoiceDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewInvoiceDetails.Enabled = false;
            this.btnViewInvoiceDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnViewInvoiceDetails.Location = new System.Drawing.Point(204, 388);
            this.btnViewInvoiceDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewInvoiceDetails.Name = "btnViewInvoiceDetails";
            this.btnViewInvoiceDetails.Size = new System.Drawing.Size(128, 54);
            this.btnViewInvoiceDetails.TabIndex = 2;
            this.btnViewInvoiceDetails.Text = "Detalhar ...";
            this.btnViewInvoiceDetails.UseVisualStyleBackColor = true;
            this.btnViewInvoiceDetails.Click += new System.EventHandler(this.BtnViewInvoiceDetailsClick);
            // 
            // comboBoxUnidadeComPendenciaFinanceira
            // 
            this.comboBoxUnidadeComPendenciaFinanceira.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUnidadeComPendenciaFinanceira.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxUnidadeComPendenciaFinanceira.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBoxUnidadeComPendenciaFinanceira.FormattingEnabled = true;
            this.comboBoxUnidadeComPendenciaFinanceira.Location = new System.Drawing.Point(204, 156);
            this.comboBoxUnidadeComPendenciaFinanceira.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxUnidadeComPendenciaFinanceira.Name = "comboBoxUnidadeComPendenciaFinanceira";
            this.comboBoxUnidadeComPendenciaFinanceira.Size = new System.Drawing.Size(315, 29);
            this.comboBoxUnidadeComPendenciaFinanceira.TabIndex = 0;
            // 
            // txtLabel_campoDeAviso
            // 
            this.txtLabel_campoDeAviso.AutoSize = true;
            this.txtLabel_campoDeAviso.BackColor = System.Drawing.Color.Transparent;
            this.txtLabel_campoDeAviso.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLabel_campoDeAviso.ForeColor = System.Drawing.Color.Red;
            this.txtLabel_campoDeAviso.Location = new System.Drawing.Point(51, 276);
            this.txtLabel_campoDeAviso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtLabel_campoDeAviso.Name = "txtLabel_campoDeAviso";
            this.txtLabel_campoDeAviso.Size = new System.Drawing.Size(106, 23);
            this.txtLabel_campoDeAviso.TabIndex = 42;
            this.txtLabel_campoDeAviso.Text = "Aviso de uso";
            this.txtLabel_campoDeAviso.Visible = false;
            // 
            // btnDeletarItemSelecionadoDaLista
            // 
            this.btnDeletarItemSelecionadoDaLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletarItemSelecionadoDaLista.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarItemSelecionadoDaLista.Location = new System.Drawing.Point(439, 231);
            this.btnDeletarItemSelecionadoDaLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeletarItemSelecionadoDaLista.Name = "btnDeletarItemSelecionadoDaLista";
            this.btnDeletarItemSelecionadoDaLista.Size = new System.Drawing.Size(128, 52);
            this.btnDeletarItemSelecionadoDaLista.TabIndex = 46;
            this.btnDeletarItemSelecionadoDaLista.Text = "Deletar Selecionado";
            this.btnDeletarItemSelecionadoDaLista.UseVisualStyleBackColor = true;
            this.btnDeletarItemSelecionadoDaLista.Visible = false;
            this.btnDeletarItemSelecionadoDaLista.Click += new System.EventHandler(this.BtnDeletarItemSelecionadoDaListaClick);
            // 
            // btnDeletarListaCompleta
            // 
            this.btnDeletarListaCompleta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletarListaCompleta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarListaCompleta.Location = new System.Drawing.Point(303, 231);
            this.btnDeletarListaCompleta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeletarListaCompleta.Name = "btnDeletarListaCompleta";
            this.btnDeletarListaCompleta.Size = new System.Drawing.Size(128, 52);
            this.btnDeletarListaCompleta.TabIndex = 47;
            this.btnDeletarListaCompleta.Text = "Deletar Lista";
            this.btnDeletarListaCompleta.UseVisualStyleBackColor = true;
            this.btnDeletarListaCompleta.Visible = false;
            this.btnDeletarListaCompleta.Click += new System.EventHandler(this.BtnDeletarListaCompletaClick);
            // 
            // checkEditarCampoUnidade
            // 
            this.checkEditarCampoUnidade.AutoSize = true;
            this.checkEditarCampoUnidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkEditarCampoUnidade.Location = new System.Drawing.Point(48, 265);
            this.checkEditarCampoUnidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkEditarCampoUnidade.Name = "checkEditarCampoUnidade";
            this.checkEditarCampoUnidade.Size = new System.Drawing.Size(18, 17);
            this.checkEditarCampoUnidade.TabIndex = 49;
            this.checkEditarCampoUnidade.UseVisualStyleBackColor = true;
            this.checkEditarCampoUnidade.CheckedChanged += new System.EventHandler(this.CheckEditarCampoUnidadeCheckedChanged);
            // 
            // labelEditarCampoUnidade
            // 
            this.labelEditarCampoUnidade.AutoSize = true;
            this.labelEditarCampoUnidade.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelEditarCampoUnidade.Location = new System.Drawing.Point(69, 261);
            this.labelEditarCampoUnidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEditarCampoUnidade.Name = "labelEditarCampoUnidade";
            this.labelEditarCampoUnidade.Size = new System.Drawing.Size(199, 23);
            this.labelEditarCampoUnidade.TabIndex = 48;
            this.labelEditarCampoUnidade.Text = "Editar Campo \'Unidade\'?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(69, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "Detalhar Fatura?";
            // 
            // label_modoDiretorAtivado
            // 
            this.label_modoDiretorAtivado.AutoSize = true;
            this.label_modoDiretorAtivado.BackColor = System.Drawing.Color.Transparent;
            this.label_modoDiretorAtivado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_modoDiretorAtivado.ForeColor = System.Drawing.Color.Red;
            this.label_modoDiretorAtivado.Location = new System.Drawing.Point(432, 6);
            this.label_modoDiretorAtivado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_modoDiretorAtivado.Name = "label_modoDiretorAtivado";
            this.label_modoDiretorAtivado.Size = new System.Drawing.Size(185, 23);
            this.label_modoDiretorAtivado.TabIndex = 51;
            this.label_modoDiretorAtivado.Text = "Modo Diretor ativado";
            this.label_modoDiretorAtivado.Visible = false;
            // 
            // UcPendenciaFinanceiraInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_modoDiretorAtivado);
            this.Controls.Add(this.checkEditarCampoUnidade);
            this.Controls.Add(this.labelEditarCampoUnidade);
            this.Controls.Add(this.btnDeletarItemSelecionadoDaLista);
            this.Controls.Add(this.btnDeletarListaCompleta);
            this.Controls.Add(this.txtLabel_campoDeAviso);
            this.Controls.Add(this.comboBoxUnidadeComPendenciaFinanceira);
            this.Controls.Add(this.btnViewInvoiceDetails);
            this.Controls.Add(this.checkBoxDetalharFatura);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSaveAndCopy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UcPendenciaFinanceiraInformes";
            this.Size = new System.Drawing.Size(627, 468);
            this.Load += new System.EventHandler(this.UcPendenciaFinanceiraInformesLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
