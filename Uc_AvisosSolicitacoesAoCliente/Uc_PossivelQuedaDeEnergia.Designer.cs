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
	partial class Uc_PossivelQuedaDeEnergia
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGerarAlerta;
		private System.Windows.Forms.Button btnCloseWindow;
		private System.Windows.Forms.Button btnSalvarECopiar;
		private System.Windows.Forms.Button btnApagarCampos;
		private System.Windows.Forms.Label labelUnidade;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MaskedTextBox maskedTextBox2;
		private System.Windows.Forms.Label labelMensagemASerEncaminhada;
		private System.Windows.Forms.RichTextBox richTextBox_MensagemASerEncaminhadaAoCliente;
		private System.Windows.Forms.Label label8;
		
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
			this.btnGerarAlerta = new System.Windows.Forms.Button();
			this.btnCloseWindow = new System.Windows.Forms.Button();
			this.btnSalvarECopiar = new System.Windows.Forms.Button();
			this.btnApagarCampos = new System.Windows.Forms.Button();
			this.labelUnidade = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
			this.labelMensagemASerEncaminhada = new System.Windows.Forms.Label();
			this.richTextBox_MensagemASerEncaminhadaAoCliente = new System.Windows.Forms.RichTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 17);
			this.label1.TabIndex = 45;
			this.label1.Text = "Mensagem - Possível queda de energia";
			// 
			// btnGerarAlerta
			// 
			this.btnGerarAlerta.BackColor = System.Drawing.Color.Transparent;
			this.btnGerarAlerta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGerarAlerta.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnGerarAlerta.ForeColor = System.Drawing.Color.Black;
			this.btnGerarAlerta.Location = new System.Drawing.Point(258, 320);
			this.btnGerarAlerta.Name = "btnGerarAlerta";
			this.btnGerarAlerta.Size = new System.Drawing.Size(96, 44);
			this.btnGerarAlerta.TabIndex = 49;
			this.btnGerarAlerta.Text = "Gerar";
			this.btnGerarAlerta.UseVisualStyleBackColor = false;
			// 
			// btnCloseWindow
			// 
			this.btnCloseWindow.BackColor = System.Drawing.Color.Transparent;
			this.btnCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCloseWindow.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnCloseWindow.ForeColor = System.Drawing.Color.Black;
			this.btnCloseWindow.Location = new System.Drawing.Point(36, 320);
			this.btnCloseWindow.Name = "btnCloseWindow";
			this.btnCloseWindow.Size = new System.Drawing.Size(96, 44);
			this.btnCloseWindow.TabIndex = 48;
			this.btnCloseWindow.Text = "Fechar";
			this.btnCloseWindow.UseVisualStyleBackColor = false;
			// 
			// btnSalvarECopiar
			// 
			this.btnSalvarECopiar.BackColor = System.Drawing.Color.Transparent;
			this.btnSalvarECopiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvarECopiar.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnSalvarECopiar.ForeColor = System.Drawing.Color.Black;
			this.btnSalvarECopiar.Location = new System.Drawing.Point(360, 320);
			this.btnSalvarECopiar.Name = "btnSalvarECopiar";
			this.btnSalvarECopiar.Size = new System.Drawing.Size(96, 44);
			this.btnSalvarECopiar.TabIndex = 46;
			this.btnSalvarECopiar.Text = "Gravar e Copiar";
			this.btnSalvarECopiar.UseVisualStyleBackColor = false;
			// 
			// btnApagarCampos
			// 
			this.btnApagarCampos.BackColor = System.Drawing.Color.Transparent;
			this.btnApagarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnApagarCampos.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnApagarCampos.ForeColor = System.Drawing.Color.Black;
			this.btnApagarCampos.Location = new System.Drawing.Point(138, 320);
			this.btnApagarCampos.Name = "btnApagarCampos";
			this.btnApagarCampos.Size = new System.Drawing.Size(114, 44);
			this.btnApagarCampos.TabIndex = 47;
			this.btnApagarCampos.Text = "Apagar campos";
			this.btnApagarCampos.UseVisualStyleBackColor = false;
			// 
			// labelUnidade
			// 
			this.labelUnidade.AutoSize = true;
			this.labelUnidade.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.labelUnidade.Location = new System.Drawing.Point(12, 34);
			this.labelUnidade.Name = "labelUnidade";
			this.labelUnidade.Size = new System.Drawing.Size(57, 17);
			this.labelUnidade.TabIndex = 50;
			this.labelUnidade.Text = "Unidade";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(12, 54);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(171, 25);
			this.comboBox1.TabIndex = 51;
			// 
			// comboBox2
			// 
			this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(189, 54);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(267, 25);
			this.comboBox2.TabIndex = 53;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label2.Location = new System.Drawing.Point(189, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 17);
			this.label2.TabIndex = 52;
			this.label2.Text = "Endereço";
			// 
			// comboBox3
			// 
			this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(12, 104);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(171, 25);
			this.comboBox3.TabIndex = 55;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label3.Location = new System.Drawing.Point(12, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 17);
			this.label3.TabIndex = 54;
			this.label3.Text = "Operadora(as)";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label4.Location = new System.Drawing.Point(189, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 17);
			this.label4.TabIndex = 56;
			this.label4.Text = "Hr. Queda";
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.maskedTextBox1.Location = new System.Drawing.Point(189, 104);
			this.maskedTextBox1.Mask = "00:00";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(100, 25);
			this.maskedTextBox1.TabIndex = 58;
			this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label5.Location = new System.Drawing.Point(295, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 17);
			this.label5.TabIndex = 59;
			this.label5.Text = "DataRef";
			// 
			// maskedTextBox2
			// 
			this.maskedTextBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.maskedTextBox2.Location = new System.Drawing.Point(295, 104);
			this.maskedTextBox2.Mask = "00/00/0000";
			this.maskedTextBox2.Name = "maskedTextBox2";
			this.maskedTextBox2.Size = new System.Drawing.Size(161, 25);
			this.maskedTextBox2.TabIndex = 60;
			this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
			// 
			// labelMensagemASerEncaminhada
			// 
			this.labelMensagemASerEncaminhada.AutoSize = true;
			this.labelMensagemASerEncaminhada.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.labelMensagemASerEncaminhada.Location = new System.Drawing.Point(12, 149);
			this.labelMensagemASerEncaminhada.Name = "labelMensagemASerEncaminhada";
			this.labelMensagemASerEncaminhada.Size = new System.Drawing.Size(187, 17);
			this.labelMensagemASerEncaminhada.TabIndex = 62;
			this.labelMensagemASerEncaminhada.Text = "Mensagem a ser encaminhada";
			// 
			// richTextBox_MensagemASerEncaminhadaAoCliente
			// 
			this.richTextBox_MensagemASerEncaminhadaAoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.richTextBox_MensagemASerEncaminhadaAoCliente.Location = new System.Drawing.Point(12, 172);
			this.richTextBox_MensagemASerEncaminhadaAoCliente.Name = "richTextBox_MensagemASerEncaminhadaAoCliente";
			this.richTextBox_MensagemASerEncaminhadaAoCliente.Size = new System.Drawing.Size(444, 111);
			this.richTextBox_MensagemASerEncaminhadaAoCliente.TabIndex = 61;
			this.richTextBox_MensagemASerEncaminhadaAoCliente.Text = "";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label8.Location = new System.Drawing.Point(1, 286);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(468, 17);
			this.label8.TabIndex = 63;
			this.label8.Text = "_________________________________________________________________________________" +
	"___________";
			// 
			// Uc_PossivelQuedaDeEnergia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.label8);
			this.Controls.Add(this.labelMensagemASerEncaminhada);
			this.Controls.Add(this.richTextBox_MensagemASerEncaminhadaAoCliente);
			this.Controls.Add(this.maskedTextBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.labelUnidade);
			this.Controls.Add(this.btnGerarAlerta);
			this.Controls.Add(this.btnCloseWindow);
			this.Controls.Add(this.btnSalvarECopiar);
			this.Controls.Add(this.btnApagarCampos);
			this.Controls.Add(this.label1);
			this.Name = "Uc_PossivelQuedaDeEnergia";
			this.Size = new System.Drawing.Size(470, 380);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
