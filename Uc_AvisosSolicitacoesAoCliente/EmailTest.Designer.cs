namespace NOC_Actions.Uc_AvisosSolicitacoesAoCliente
{
    partial class EmailTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalvarValidar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.listBoxMostrarEmails = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvarValidar
            // 
            this.btnSalvarValidar.Location = new System.Drawing.Point(541, 485);
            this.btnSalvarValidar.Name = "btnSalvarValidar";
            this.btnSalvarValidar.Size = new System.Drawing.Size(247, 41);
            this.btnSalvarValidar.TabIndex = 0;
            this.btnSalvarValidar.Text = "Salvar";
            this.btnSalvarValidar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(288, 485);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(247, 41);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // listBoxMostrarEmails
            // 
            this.listBoxMostrarEmails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMostrarEmails.FormattingEnabled = true;
            this.listBoxMostrarEmails.ItemHeight = 21;
            this.listBoxMostrarEmails.Location = new System.Drawing.Point(101, 164);
            this.listBoxMostrarEmails.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMostrarEmails.Name = "listBoxMostrarEmails";
            this.listBoxMostrarEmails.Size = new System.Drawing.Size(625, 151);
            this.listBoxMostrarEmails.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-mail recebido na caixa de entrada";
            // 
            // EmailTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMostrarEmails);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvarValidar);
            this.Name = "EmailTest";
            this.Text = "EmailTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarValidar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ListBox listBoxMostrarEmails;
        private System.Windows.Forms.Label label1;
    }
}