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
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.Button btnAnaliseDeInfra;
		private System.Windows.Forms.Button btnPossivelQuedaDeEnergia;
		private System.Windows.Forms.Button btnLiberacaoDeAcesso;
		private System.Windows.Forms.Button btnBloqueioFinanceiro;
		private System.Windows.Forms.Label emojiConfig;
		private System.Windows.Forms.Label labelUsername;
		private System.Windows.Forms.Label emojiUser;
		
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
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.labelUsername = new System.Windows.Forms.Label();
			this.emojiUser = new System.Windows.Forms.Label();
			this.btnBloqueioFinanceiro = new System.Windows.Forms.Button();
			this.btnPossivelQuedaDeEnergia = new System.Windows.Forms.Button();
			this.btnLiberacaoDeAcesso = new System.Windows.Forms.Button();
			this.btnAnaliseDeInfra = new System.Windows.Forms.Button();
			this.emojiConfig = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.labelUsername);
			this.splitContainer.Panel1.Controls.Add(this.emojiUser);
			this.splitContainer.Panel1.Controls.Add(this.btnBloqueioFinanceiro);
			this.splitContainer.Panel1.Controls.Add(this.btnPossivelQuedaDeEnergia);
			this.splitContainer.Panel1.Controls.Add(this.btnLiberacaoDeAcesso);
			this.splitContainer.Panel1.Controls.Add(this.btnAnaliseDeInfra);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.splitContainer.Panel2.Controls.Add(this.emojiConfig);
			this.splitContainer.Size = new System.Drawing.Size(745, 380);
			this.splitContainer.SplitterDistance = 260;
			this.splitContainer.TabIndex = 0;
			// 
			// labelUsername
			// 
			this.labelUsername.AutoSize = true;
			this.labelUsername.Cursor = System.Windows.Forms.Cursors.Hand;
			this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.labelUsername.Location = new System.Drawing.Point(23, 358);
			this.labelUsername.Name = "labelUsername";
			this.labelUsername.Size = new System.Drawing.Size(68, 17);
			this.labelUsername.TabIndex = 0;
			this.labelUsername.Text = "userName";
			this.labelUsername.Click += new System.EventHandler(this.LabelUsernameClick);
			// 
			// emojiUser
			// 
			this.emojiUser.AutoSize = true;
			this.emojiUser.BackColor = System.Drawing.Color.Transparent;
			this.emojiUser.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.emojiUser.Location = new System.Drawing.Point(4, 358);
			this.emojiUser.Name = "emojiUser";
			this.emojiUser.Size = new System.Drawing.Size(26, 17);
			this.emojiUser.TabIndex = 66;
			this.emojiUser.Text = "🔐";
			// 
			// btnBloqueioFinanceiro
			// 
			this.btnBloqueioFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBloqueioFinanceiro.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnBloqueioFinanceiro.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnBloqueioFinanceiro.Location = new System.Drawing.Point(0, 81);
			this.btnBloqueioFinanceiro.Name = "btnBloqueioFinanceiro";
			this.btnBloqueioFinanceiro.Size = new System.Drawing.Size(260, 27);
			this.btnBloqueioFinanceiro.TabIndex = 3;
			this.btnBloqueioFinanceiro.Text = "Bloqueio Financeiro";
			this.btnBloqueioFinanceiro.UseVisualStyleBackColor = true;
			this.btnBloqueioFinanceiro.Click += new System.EventHandler(this.BtnBloqueioFinanceiroClick);
			// 
			// btnPossivelQuedaDeEnergia
			// 
			this.btnPossivelQuedaDeEnergia.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPossivelQuedaDeEnergia.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnPossivelQuedaDeEnergia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnPossivelQuedaDeEnergia.Location = new System.Drawing.Point(0, 54);
			this.btnPossivelQuedaDeEnergia.Name = "btnPossivelQuedaDeEnergia";
			this.btnPossivelQuedaDeEnergia.Size = new System.Drawing.Size(260, 27);
			this.btnPossivelQuedaDeEnergia.TabIndex = 2;
			this.btnPossivelQuedaDeEnergia.Text = "Possível queda de Energia";
			this.btnPossivelQuedaDeEnergia.UseVisualStyleBackColor = true;
			this.btnPossivelQuedaDeEnergia.Click += new System.EventHandler(this.BtnPossivelQuedaDeEnergiaClick);
			// 
			// btnLiberacaoDeAcesso
			// 
			this.btnLiberacaoDeAcesso.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLiberacaoDeAcesso.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnLiberacaoDeAcesso.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnLiberacaoDeAcesso.Location = new System.Drawing.Point(0, 27);
			this.btnLiberacaoDeAcesso.Name = "btnLiberacaoDeAcesso";
			this.btnLiberacaoDeAcesso.Size = new System.Drawing.Size(260, 27);
			this.btnLiberacaoDeAcesso.TabIndex = 1;
			this.btnLiberacaoDeAcesso.Text = "Liberação de Acesso";
			this.btnLiberacaoDeAcesso.UseVisualStyleBackColor = true;
			this.btnLiberacaoDeAcesso.Click += new System.EventHandler(this.BtnLiberacaoDeAcessoClick);
			// 
			// btnAnaliseDeInfra
			// 
			this.btnAnaliseDeInfra.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAnaliseDeInfra.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnAnaliseDeInfra.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.btnAnaliseDeInfra.Location = new System.Drawing.Point(0, 0);
			this.btnAnaliseDeInfra.Name = "btnAnaliseDeInfra";
			this.btnAnaliseDeInfra.Size = new System.Drawing.Size(260, 27);
			this.btnAnaliseDeInfra.TabIndex = 0;
			this.btnAnaliseDeInfra.Text = "Análise de Infra";
			this.btnAnaliseDeInfra.UseVisualStyleBackColor = true;
			this.btnAnaliseDeInfra.Click += new System.EventHandler(this.BtnAnaliseDeInfraClick);
			// 
			// emojiConfig
			// 
			this.emojiConfig.AutoSize = true;
			this.emojiConfig.BackColor = System.Drawing.Color.Transparent;
			this.emojiConfig.Cursor = System.Windows.Forms.Cursors.Hand;
			this.emojiConfig.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emojiConfig.ForeColor = System.Drawing.SystemColors.ControlText;
			this.emojiConfig.Location = new System.Drawing.Point(453, 1);
			this.emojiConfig.Name = "emojiConfig";
			this.emojiConfig.Size = new System.Drawing.Size(30, 20);
			this.emojiConfig.TabIndex = 65;
			this.emojiConfig.Text = "⚙️";
			// 
			// AvisosSolicitacoesAoCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(745, 380);
			this.Controls.Add(this.splitContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AvisosSolicitacoesAoCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AvisosSolicitacoesAoCliente";
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel1.PerformLayout();
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
