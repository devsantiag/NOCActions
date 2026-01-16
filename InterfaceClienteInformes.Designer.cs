﻿namespace NOC_Actions
{
	partial class InterfaceClienteInformes
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnAlarmeLinkIndisponivel;
		private System.Windows.Forms.Button btnChamadoRegistrado;
		private System.Windows.Forms.Button btnLibAcessoSemPrevisao;
		private System.Windows.Forms.Button btnLibAcessoComPrevisao;
		private System.Windows.Forms.Button btnAnaliseEnergia;

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel painelInterface;
		private System.Windows.Forms.Label label_login_username;
		private System.Windows.Forms.Button btnPendenciaFinanceira;
		private System.Windows.Forms.Button btnNoTicket;

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
            this.btnAlarmeLinkIndisponivel = new System.Windows.Forms.Button();
            this.btnChamadoRegistrado = new System.Windows.Forms.Button();
            this.btnLibAcessoSemPrevisao = new System.Windows.Forms.Button();
            this.btnLibAcessoComPrevisao = new System.Windows.Forms.Button();
            this.btnAnaliseEnergia = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnNoTicket = new System.Windows.Forms.Button();
            this.btnPendenciaFinanceira = new System.Windows.Forms.Button();
            this.label_login_username = new System.Windows.Forms.Label();
            this.painelInterface = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlarmeLinkIndisponivel
            // 
            this.btnAlarmeLinkIndisponivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlarmeLinkIndisponivel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlarmeLinkIndisponivel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAlarmeLinkIndisponivel.Location = new System.Drawing.Point(0, 0);
            this.btnAlarmeLinkIndisponivel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlarmeLinkIndisponivel.Name = "btnAlarmeLinkIndisponivel";
            this.btnAlarmeLinkIndisponivel.Size = new System.Drawing.Size(357, 33);
            this.btnAlarmeLinkIndisponivel.TabIndex = 0;
            this.btnAlarmeLinkIndisponivel.Text = "Alarme de Link Indisponível";
            this.btnAlarmeLinkIndisponivel.Click += new System.EventHandler(this.BtnAlarmeLinkIndisponivel_Click);
            // 
            // btnChamadoRegistrado
            // 
            this.btnChamadoRegistrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChamadoRegistrado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChamadoRegistrado.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnChamadoRegistrado.Location = new System.Drawing.Point(0, 33);
            this.btnChamadoRegistrado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChamadoRegistrado.Name = "btnChamadoRegistrado";
            this.btnChamadoRegistrado.Size = new System.Drawing.Size(357, 33);
            this.btnChamadoRegistrado.TabIndex = 1;
            this.btnChamadoRegistrado.Text = "Chamado Registrado";
            this.btnChamadoRegistrado.Click += new System.EventHandler(this.BtnChamadoRegistrado_Click);
            // 
            // btnLibAcessoSemPrevisao
            // 
            this.btnLibAcessoSemPrevisao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibAcessoSemPrevisao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibAcessoSemPrevisao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnLibAcessoSemPrevisao.Location = new System.Drawing.Point(0, 66);
            this.btnLibAcessoSemPrevisao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLibAcessoSemPrevisao.Name = "btnLibAcessoSemPrevisao";
            this.btnLibAcessoSemPrevisao.Size = new System.Drawing.Size(357, 33);
            this.btnLibAcessoSemPrevisao.TabIndex = 2;
            this.btnLibAcessoSemPrevisao.Text = "Liberação de Acesso (Sem Previsão)";
            this.btnLibAcessoSemPrevisao.Click += new System.EventHandler(this.BtnLibAcessoSemPrevisao_Click);
            // 
            // btnLibAcessoComPrevisao
            // 
            this.btnLibAcessoComPrevisao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibAcessoComPrevisao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibAcessoComPrevisao.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnLibAcessoComPrevisao.Location = new System.Drawing.Point(0, 99);
            this.btnLibAcessoComPrevisao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLibAcessoComPrevisao.Name = "btnLibAcessoComPrevisao";
            this.btnLibAcessoComPrevisao.Size = new System.Drawing.Size(357, 33);
            this.btnLibAcessoComPrevisao.TabIndex = 3;
            this.btnLibAcessoComPrevisao.Text = "Liberação de Acesso (Com Previsão)";
            this.btnLibAcessoComPrevisao.Click += new System.EventHandler(this.BtnLibAcessoComPrevisao_Click);
            // 
            // btnAnaliseEnergia
            // 
            this.btnAnaliseEnergia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnaliseEnergia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnaliseEnergia.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAnaliseEnergia.Location = new System.Drawing.Point(0, 132);
            this.btnAnaliseEnergia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnaliseEnergia.Name = "btnAnaliseEnergia";
            this.btnAnaliseEnergia.Size = new System.Drawing.Size(357, 33);
            this.btnAnaliseEnergia.TabIndex = 4;
            this.btnAnaliseEnergia.Text = "Análise de Energia";
            this.btnAnaliseEnergia.Click += new System.EventHandler(this.BtnAnaliseEnergia_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Panel1.Controls.Add(this.btnNoTicket);
            this.splitContainer1.Panel1.Controls.Add(this.btnPendenciaFinanceira);
            this.splitContainer1.Panel1.Controls.Add(this.label_login_username);
            this.splitContainer1.Panel1.Controls.Add(this.btnAnaliseEnergia);
            this.splitContainer1.Panel1.Controls.Add(this.btnLibAcessoComPrevisao);
            this.splitContainer1.Panel1.Controls.Add(this.btnLibAcessoSemPrevisao);
            this.splitContainer1.Panel1.Controls.Add(this.btnChamadoRegistrado);
            this.splitContainer1.Panel1.Controls.Add(this.btnAlarmeLinkIndisponivel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.painelInterface);
            this.splitContainer1.Size = new System.Drawing.Size(993, 468);
            this.splitContainer1.SplitterDistance = 357;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnNoTicket
            // 
            this.btnNoTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNoTicket.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnNoTicket.Location = new System.Drawing.Point(0, 198);
            this.btnNoTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNoTicket.Name = "btnNoTicket";
            this.btnNoTicket.Size = new System.Drawing.Size(357, 33);
            this.btnNoTicket.TabIndex = 6;
            this.btnNoTicket.Text = "No-Ticket";
            this.btnNoTicket.Click += new System.EventHandler(this.BtnRegistroDeFalhaInternaClienteClick);
            // 
            // btnPendenciaFinanceira
            // 
            this.btnPendenciaFinanceira.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPendenciaFinanceira.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPendenciaFinanceira.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnPendenciaFinanceira.Location = new System.Drawing.Point(0, 165);
            this.btnPendenciaFinanceira.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPendenciaFinanceira.Name = "btnPendenciaFinanceira";
            this.btnPendenciaFinanceira.Size = new System.Drawing.Size(357, 33);
            this.btnPendenciaFinanceira.TabIndex = 5;
            this.btnPendenciaFinanceira.Text = "Pendência Financeira";
            this.btnPendenciaFinanceira.Click += new System.EventHandler(this.BtnPendenciaFinanceiraClick);
            // 
            // label_login_username
            // 
            this.label_login_username.AutoSize = true;
            this.label_login_username.BackColor = System.Drawing.Color.Transparent;
            this.label_login_username.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_login_username.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label_login_username.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_login_username.Location = new System.Drawing.Point(0, 445);
            this.label_login_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_login_username.Name = "label_login_username";
            this.label_login_username.Size = new System.Drawing.Size(88, 23);
            this.label_login_username.TabIndex = 0;
            this.label_login_username.Text = "userName";
            // 
            // painelInterface
            // 
            this.painelInterface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelInterface.Location = new System.Drawing.Point(0, 0);
            this.painelInterface.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.painelInterface.Name = "painelInterface";
            this.painelInterface.Size = new System.Drawing.Size(631, 468);
            this.painelInterface.TabIndex = 0;
            // 
            // InterfaceClienteInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(993, 468);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InterfaceClienteInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterfaceClienteInformes";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
	}
}
