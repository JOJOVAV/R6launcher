namespace r6Launcher.Forms
{
    partial class FormSelectSiege
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
            this.buttonSelectSiege = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSelectSiege = new System.Windows.Forms.ComboBox();
            this.useVulkanCheckBox = new System.Windows.Forms.CheckBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSelectSiege
            // 
            this.buttonSelectSiege.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSelectSiege.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSelectSiege.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSelectSiege.FlatAppearance.BorderSize = 3;
            this.buttonSelectSiege.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonSelectSiege.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectSiege.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectSiege.ForeColor = System.Drawing.Color.White;
            this.buttonSelectSiege.Location = new System.Drawing.Point(169, 293);
            this.buttonSelectSiege.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectSiege.MinimumSize = new System.Drawing.Size(154, 64);
            this.buttonSelectSiege.Name = "buttonSelectSiege";
            this.buttonSelectSiege.Size = new System.Drawing.Size(154, 64);
            this.buttonSelectSiege.TabIndex = 1;
            this.buttonSelectSiege.Text = "Select Operation";
            this.buttonSelectSiege.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "The name of the Operation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSelectSiege
            // 
            this.comboBoxSelectSiege.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSelectSiege.BackColor = System.Drawing.Color.Gray;
            this.comboBoxSelectSiege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectSiege.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSelectSiege.ForeColor = System.Drawing.Color.White;
            this.comboBoxSelectSiege.FormattingEnabled = true;
            this.comboBoxSelectSiege.Location = new System.Drawing.Point(239, 21);
            this.comboBoxSelectSiege.Name = "comboBoxSelectSiege";
            this.comboBoxSelectSiege.Size = new System.Drawing.Size(275, 24);
            this.comboBoxSelectSiege.TabIndex = 7;
            this.comboBoxSelectSiege.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectSiege_SelectedIndexChanged);
            // 
            // useVulkanCheckBox
            // 
            this.useVulkanCheckBox.AutoSize = true;
            this.useVulkanCheckBox.ForeColor = System.Drawing.Color.White;
            this.useVulkanCheckBox.Location = new System.Drawing.Point(367, 338);
            this.useVulkanCheckBox.Name = "useVulkanCheckBox";
            this.useVulkanCheckBox.Size = new System.Drawing.Size(159, 20);
            this.useVulkanCheckBox.TabIndex = 8;
            this.useVulkanCheckBox.Text = "Use Vulkan If possible";
            this.useVulkanCheckBox.UseVisualStyleBackColor = true;
            this.useVulkanCheckBox.CheckedChanged += new System.EventHandler(this.VulkanCheckChanged);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.resetButton.FlatAppearance.BorderSize = 3;
            this.resetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(15, 293);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.MinimumSize = new System.Drawing.Size(120, 40);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(120, 64);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetClicked);
            // 
            // FormSelectSiege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(539, 370);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.useVulkanCheckBox);
            this.Controls.Add(this.comboBoxSelectSiege);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSelectSiege);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(555, 409);
            this.Name = "FormSelectSiege";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select your operation to play";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectSiege;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectSiege;
        private System.Windows.Forms.CheckBox useVulkanCheckBox;
        private System.Windows.Forms.Button resetButton;
    }
}