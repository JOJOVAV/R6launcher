namespace r6Launcher
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.buttonSelectSiege = new System.Windows.Forms.Button();
            this.buttonAddSiege = new System.Windows.Forms.Button();
            this.buttonDownloadSiege = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMainPanel = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panelSideMenu.Controls.Add(this.buttonClose);
            this.panelSideMenu.Controls.Add(this.buttonPlay);
            this.panelSideMenu.Controls.Add(this.panelSubMenu);
            this.panelSideMenu.Controls.Add(this.buttonMenu);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(125, 450);
            this.panelSideMenu.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(0, 208);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(125, 41);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.ForeColor = System.Drawing.Color.White;
            this.buttonPlay.Location = new System.Drawing.Point(0, 167);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(125, 41);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panelSubMenu.Controls.Add(this.buttonSelectSiege);
            this.panelSubMenu.Controls.Add(this.buttonAddSiege);
            this.panelSubMenu.Controls.Add(this.buttonDownloadSiege);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 41);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(125, 126);
            this.panelSubMenu.TabIndex = 1;
            // 
            // buttonSelectSiege
            // 
            this.buttonSelectSiege.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSelectSiege.FlatAppearance.BorderSize = 0;
            this.buttonSelectSiege.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectSiege.ForeColor = System.Drawing.Color.White;
            this.buttonSelectSiege.Location = new System.Drawing.Point(0, 82);
            this.buttonSelectSiege.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectSiege.Name = "buttonSelectSiege";
            this.buttonSelectSiege.Size = new System.Drawing.Size(125, 41);
            this.buttonSelectSiege.TabIndex = 3;
            this.buttonSelectSiege.Text = "Select Siege";
            this.buttonSelectSiege.UseVisualStyleBackColor = true;
            this.buttonSelectSiege.Click += new System.EventHandler(this.buttonSelectSiege_Click);
            // 
            // buttonAddSiege
            // 
            this.buttonAddSiege.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddSiege.FlatAppearance.BorderSize = 0;
            this.buttonAddSiege.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSiege.ForeColor = System.Drawing.Color.White;
            this.buttonAddSiege.Location = new System.Drawing.Point(0, 41);
            this.buttonAddSiege.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddSiege.Name = "buttonAddSiege";
            this.buttonAddSiege.Size = new System.Drawing.Size(125, 41);
            this.buttonAddSiege.TabIndex = 2;
            this.buttonAddSiege.Text = "Add Siege";
            this.buttonAddSiege.UseVisualStyleBackColor = true;
            this.buttonAddSiege.Click += new System.EventHandler(this.buttonAddSiege_Click);
            // 
            // buttonDownloadSiege
            // 
            this.buttonDownloadSiege.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDownloadSiege.FlatAppearance.BorderSize = 0;
            this.buttonDownloadSiege.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownloadSiege.ForeColor = System.Drawing.Color.White;
            this.buttonDownloadSiege.Location = new System.Drawing.Point(0, 0);
            this.buttonDownloadSiege.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDownloadSiege.Name = "buttonDownloadSiege";
            this.buttonDownloadSiege.Size = new System.Drawing.Size(125, 41);
            this.buttonDownloadSiege.TabIndex = 4;
            this.buttonDownloadSiege.Text = "Download Siege";
            this.buttonDownloadSiege.UseVisualStyleBackColor = true;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.ForeColor = System.Drawing.Color.White;
            this.buttonMenu.Location = new System.Drawing.Point(0, 0);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(125, 41);
            this.buttonMenu.TabIndex = 0;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.White;
            this.panelTitleBar.Location = new System.Drawing.Point(125, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(555, 41);
            this.panelTitleBar.TabIndex = 1;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.AutoEllipsis = true;
            this.btnCloseChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(41, 41);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Visible = false;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(175, 5);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(227, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Rainbow Six Launcher";
            // 
            // panelMainPanel
            // 
            this.panelMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panelMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainPanel.Location = new System.Drawing.Point(125, 41);
            this.panelMainPanel.Name = "panelMainPanel";
            this.panelMainPanel.Size = new System.Drawing.Size(555, 409);
            this.panelMainPanel.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.panelMainPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button buttonSelectSiege;
        private System.Windows.Forms.Button buttonAddSiege;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMainPanel;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button buttonDownloadSiege;
    }
}

