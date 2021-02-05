namespace projectRemaxPart2
{
    partial class frmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            this.menuStripRemax = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripRemax.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripRemax
            // 
            this.menuStripRemax.BackColor = System.Drawing.Color.Red;
            this.menuStripRemax.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            resources.ApplyResources(this.menuStripRemax, "menuStripRemax");
            this.menuStripRemax.Name = "menuStripRemax";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminFormToolStripMenuItem,
            this.employeePageToolStripMenuItem,
            this.clientPageToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            resources.ApplyResources(this.actionsToolStripMenuItem, "actionsToolStripMenuItem");
            // 
            // adminFormToolStripMenuItem
            // 
            this.adminFormToolStripMenuItem.Name = "adminFormToolStripMenuItem";
            resources.ApplyResources(this.adminFormToolStripMenuItem, "adminFormToolStripMenuItem");
            this.adminFormToolStripMenuItem.Click += new System.EventHandler(this.adminFormToolStripMenuItem_Click);
            // 
            // employeePageToolStripMenuItem
            // 
            this.employeePageToolStripMenuItem.Name = "employeePageToolStripMenuItem";
            resources.ApplyResources(this.employeePageToolStripMenuItem, "employeePageToolStripMenuItem");
            this.employeePageToolStripMenuItem.Click += new System.EventHandler(this.employeePageToolStripMenuItem_Click);
            // 
            // clientPageToolStripMenuItem
            // 
            this.clientPageToolStripMenuItem.Name = "clientPageToolStripMenuItem";
            resources.ApplyResources(this.clientPageToolStripMenuItem, "clientPageToolStripMenuItem");
            this.clientPageToolStripMenuItem.Click += new System.EventHandler(this.clientPageToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmHomePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::projectRemaxPart2.Properties.Resources.remaxLogo1;
            this.Controls.Add(this.menuStripRemax);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripRemax;
            this.Name = "frmHomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHomePage_Load);
            this.menuStripRemax.ResumeLayout(false);
            this.menuStripRemax.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripRemax;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}