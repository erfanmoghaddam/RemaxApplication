namespace projectRemaxPart2
{
    partial class frmClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.lblCriterias = new System.Windows.Forms.GroupBox();
            this.cboAgents = new System.Windows.Forms.ComboBox();
            this.cboProperties = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chkAgent = new System.Windows.Forms.CheckBox();
            this.chkProperty = new System.Windows.Forms.CheckBox();
            this.mainLabel = new System.Windows.Forms.Label();
            this.gridResults = new System.Windows.Forms.DataGridView();
            this.remaxPicture = new System.Windows.Forms.PictureBox();
            this.lblCriterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCriterias
            // 
            this.lblCriterias.Controls.Add(this.cboAgents);
            this.lblCriterias.Controls.Add(this.cboProperties);
            this.lblCriterias.Controls.Add(this.btnSearch);
            this.lblCriterias.Controls.Add(this.chkAgent);
            this.lblCriterias.Controls.Add(this.chkProperty);
            this.lblCriterias.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCriterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterias.Location = new System.Drawing.Point(34, 130);
            this.lblCriterias.Margin = new System.Windows.Forms.Padding(2);
            this.lblCriterias.Name = "lblCriterias";
            this.lblCriterias.Padding = new System.Windows.Forms.Padding(2);
            this.lblCriterias.Size = new System.Drawing.Size(440, 162);
            this.lblCriterias.TabIndex = 11;
            this.lblCriterias.TabStop = false;
            this.lblCriterias.Text = "Search Criterias";
            // 
            // cboAgents
            // 
            this.cboAgents.FormattingEnabled = true;
            this.cboAgents.Location = new System.Drawing.Point(127, 75);
            this.cboAgents.Margin = new System.Windows.Forms.Padding(2);
            this.cboAgents.Name = "cboAgents";
            this.cboAgents.Size = new System.Drawing.Size(133, 24);
            this.cboAgents.TabIndex = 6;
            // 
            // cboProperties
            // 
            this.cboProperties.FormattingEnabled = true;
            this.cboProperties.Location = new System.Drawing.Point(127, 41);
            this.cboProperties.Margin = new System.Windows.Forms.Padding(2);
            this.cboProperties.Name = "cboProperties";
            this.cboProperties.Size = new System.Drawing.Size(133, 24);
            this.cboProperties.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSearch.Location = new System.Drawing.Point(336, 41);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 54);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // chkAgent
            // 
            this.chkAgent.AutoSize = true;
            this.chkAgent.Location = new System.Drawing.Point(23, 75);
            this.chkAgent.Margin = new System.Windows.Forms.Padding(2);
            this.chkAgent.Name = "chkAgent";
            this.chkAgent.Size = new System.Drawing.Size(83, 21);
            this.chkAgent.TabIndex = 1;
            this.chkAgent.Text = "by Agent";
            this.chkAgent.UseVisualStyleBackColor = true;
            // 
            // chkProperty
            // 
            this.chkProperty.AutoSize = true;
            this.chkProperty.Location = new System.Drawing.Point(23, 41);
            this.chkProperty.Margin = new System.Windows.Forms.Padding(2);
            this.chkProperty.Name = "chkProperty";
            this.chkProperty.Size = new System.Drawing.Size(100, 21);
            this.chkProperty.TabIndex = 0;
            this.chkProperty.Text = "by Property";
            this.chkProperty.UseVisualStyleBackColor = true;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(52, 67);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(136, 29);
            this.mainLabel.TabIndex = 9;
            this.mainLabel.Text = "User Form";
            // 
            // gridResults
            // 
            this.gridResults.AllowUserToAddRows = false;
            this.gridResults.AllowUserToDeleteRows = false;
            this.gridResults.AllowUserToOrderColumns = true;
            this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResults.Location = new System.Drawing.Point(34, 313);
            this.gridResults.Margin = new System.Windows.Forms.Padding(2);
            this.gridResults.Name = "gridResults";
            this.gridResults.ReadOnly = true;
            this.gridResults.RowTemplate.Height = 28;
            this.gridResults.Size = new System.Drawing.Size(760, 184);
            this.gridResults.TabIndex = 8;
            // 
            // remaxPicture
            // 
            this.remaxPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("remaxPicture.BackgroundImage")));
            this.remaxPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.remaxPicture.InitialImage = null;
            this.remaxPicture.Location = new System.Drawing.Point(508, 12);
            this.remaxPicture.Name = "remaxPicture";
            this.remaxPicture.Size = new System.Drawing.Size(248, 280);
            this.remaxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.remaxPicture.TabIndex = 19;
            this.remaxPicture.TabStop = false;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(805, 517);
            this.Controls.Add(this.remaxPicture);
            this.Controls.Add(this.lblCriterias);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.gridResults);
            this.Name = "frmClient";
            this.Text = "frmClient";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.lblCriterias.ResumeLayout(false);
            this.lblCriterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remaxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox lblCriterias;
        private System.Windows.Forms.ComboBox cboAgents;
        private System.Windows.Forms.ComboBox cboProperties;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkAgent;
        private System.Windows.Forms.CheckBox chkProperty;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.DataGridView gridResults;
        private System.Windows.Forms.PictureBox remaxPicture;
    }
}