/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 18/07/2025
 * Time: 10:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NOC_Actions
{
	partial class UcPossivelQuedaDeEnergia
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSaveAndCopy;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUnitName;
		private System.Windows.Forms.Button btnClearFields;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCloseWindow;
		
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
			this.label5 = new System.Windows.Forms.Label();
			this.btnSaveAndCopy = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUnitName = new System.Windows.Forms.TextBox();
			this.btnClearFields = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCloseWindow = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(44, 202);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(391, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "________________________________________________________________";
			// 
			// btnSaveAndCopy
			// 
			this.btnSaveAndCopy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveAndCopy.Location = new System.Drawing.Point(339, 316);
			this.btnSaveAndCopy.Name = "btnSaveAndCopy";
			this.btnSaveAndCopy.Size = new System.Drawing.Size(114, 33);
			this.btnSaveAndCopy.TabIndex = 1;
			this.btnSaveAndCopy.Text = "Gravar e Copiar";
			this.btnSaveAndCopy.UseVisualStyleBackColor = true;
			this.btnSaveAndCopy.Click += new System.EventHandler(this.BtnSaveAndCopyClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.label4.Location = new System.Drawing.Point(3, 1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Mensagem a ser exibida";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.label2.Location = new System.Drawing.Point(87, 151);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Unidade";
			// 
			// txtUnitName
			// 
			this.txtUnitName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.txtUnitName.Location = new System.Drawing.Point(148, 145);
			this.txtUnitName.Name = "txtUnitName";
			this.txtUnitName.Size = new System.Drawing.Size(241, 25);
			this.txtUnitName.TabIndex = 0;
			// 
			// btnClearFields
			// 
			this.btnClearFields.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClearFields.Location = new System.Drawing.Point(219, 316);
			this.btnClearFields.Name = "btnClearFields";
			this.btnClearFields.Size = new System.Drawing.Size(114, 33);
			this.btnClearFields.TabIndex = 2;
			this.btnClearFields.Text = "Apagar";
			this.btnClearFields.UseVisualStyleBackColor = true;
			this.btnClearFields.Click += new System.EventHandler(this.BtnClearFieldsClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.label1.Location = new System.Drawing.Point(3, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(464, 35);
			this.label1.TabIndex = 9;
			this.label1.Text = "Prezados, poderiam confirmar possível queda de energia na loja CE___? Constatamos" +
	" que ambos os links estão indisponíveis neste momento.";
			// 
			// btnCloseWindow
			// 
			this.btnCloseWindow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCloseWindow.Location = new System.Drawing.Point(44, 317);
			this.btnCloseWindow.Name = "btnCloseWindow";
			this.btnCloseWindow.Size = new System.Drawing.Size(114, 33);
			this.btnCloseWindow.TabIndex = 3;
			this.btnCloseWindow.Text = "Fechar";
			this.btnCloseWindow.UseVisualStyleBackColor = true;
			this.btnCloseWindow.Click += new System.EventHandler(this.BtnCloseWindowClick);
			// 
			// UcPossivelQuedaDeEnergia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnCloseWindow);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnSaveAndCopy);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUnitName);
			this.Controls.Add(this.btnClearFields);
			this.Controls.Add(this.label1);
			this.Name = "UcPossivelQuedaDeEnergia";
			this.Size = new System.Drawing.Size(470, 380);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
