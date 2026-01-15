namespace NOC_Actions.Uc_AvisosSolicitacoesAoCliente
{
    partial class WebForm
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
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.portaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.americaNet_toolTripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.embratel_toolTripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.vivo_toolTripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.config_toolTripMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Enabled = false;
            this.webView.Location = new System.Drawing.Point(153, 91);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(798, 370);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portaisToolStripMenuItem,
            this.config_toolTripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1381, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // portaisToolStripMenuItem
            // 
            this.portaisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.americaNet_toolTripMenu,
            this.embratel_toolTripMenu,
            this.vivo_toolTripMenu});
            this.portaisToolStripMenuItem.Name = "portaisToolStripMenuItem";
            this.portaisToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.portaisToolStripMenuItem.Text = "Portais";
            // 
            // americaNet_toolTripMenu
            // 
            this.americaNet_toolTripMenu.Name = "americaNet_toolTripMenu";
            this.americaNet_toolTripMenu.Size = new System.Drawing.Size(224, 26);
            this.americaNet_toolTripMenu.Text = "America Net";
            //this.americaNet_toolTripMenu.Click += new System.EventHandler(this.americaNet_toolTripMenu_Click_1);
            // 
            // embratel_toolTripMenu
            // 
            this.embratel_toolTripMenu.Name = "embratel_toolTripMenu";
            this.embratel_toolTripMenu.Size = new System.Drawing.Size(224, 26);
            this.embratel_toolTripMenu.Text = "Embratel";
            // 
            // vivo_toolTripMenu
            // 
            this.vivo_toolTripMenu.Name = "vivo_toolTripMenu";
            this.vivo_toolTripMenu.Size = new System.Drawing.Size(224, 26);
            this.vivo_toolTripMenu.Text = "Vivo";
            // 
            // config_toolTripMenu
            // 
            this.config_toolTripMenu.Checked = true;
            this.config_toolTripMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.config_toolTripMenu.Name = "config_toolTripMenu";
            this.config_toolTripMenu.Size = new System.Drawing.Size(67, 24);
            this.config_toolTripMenu.Text = "Config";
            // 
            // WebForm
            // 
            this.ClientSize = new System.Drawing.Size(1381, 720);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WebForm";
            this.Text = "Central NOC";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem portaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem americaNet_toolTripMenu;
        private System.Windows.Forms.ToolStripMenuItem embratel_toolTripMenu;
        private System.Windows.Forms.ToolStripMenuItem vivo_toolTripMenu;
        private System.Windows.Forms.ToolStripMenuItem config_toolTripMenu;
    }
}