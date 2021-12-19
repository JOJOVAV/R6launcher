namespace r6Launcher.Forms
{
    partial class FormAddSiege
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
            this.buttonAddr6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAddSiege = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonAddr6
            // 
            this.buttonAddr6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddr6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAddr6.FlatAppearance.BorderSize = 3;
            this.buttonAddr6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonAddr6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddr6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddr6.ForeColor = System.Drawing.Color.White;
            this.buttonAddr6.Location = new System.Drawing.Point(161, 195);
            this.buttonAddr6.MinimumSize = new System.Drawing.Size(154, 64);
            this.buttonAddr6.Name = "buttonAddr6";
            this.buttonAddr6.Size = new System.Drawing.Size(154, 64);
            this.buttonAddr6.TabIndex = 0;
            this.buttonAddr6.Text = "Add Siege";
            this.buttonAddr6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "The name of the Operation";
            // 
            // comboBoxAddSiege
            // 
            this.comboBoxAddSiege.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxAddSiege.BackColor = System.Drawing.Color.Gray;
            this.comboBoxAddSiege.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAddSiege.ForeColor = System.Drawing.Color.White;
            this.comboBoxAddSiege.FormattingEnabled = true;
            this.comboBoxAddSiege.Items.AddRange(new object[] {
            "Y1S0 Vanilla",
            "Y1S1 Black Ice",
            "Y1S2 Dust LIne",
            "Y1S3 Skull Rain",
            "Y1S4 Red Crow",
            "Y2S1 Velvet Shell",
            "Y2S2 Health",
            "Y2S3 Blood Orchid",
            "Y2S4 White Noise",
            "Y3S1 Chimera",
            "Y3S2 Para Bellum",
            "Y3S3 Grim Sky",
            "Y3S4 Wind Bastion",
            "Y4S1 Burnt Horizon",
            "Y4S2 Phantom Sigh",
            "Y4S3 Ember Rise",
            "Y4S4 Shifting Tides",
            "Y5S1 Void Edge",
            "Y5S2 Steel Wave",
            "Y5S3 Shadow Legacy",
            "Y5S4 Neon Dawn",
            "Y6S1 Crimson Heist",
            "Y6S2 North Star",
            "Y6S3 Crystal Guard",
            "Y6S4 High Calibre"});
            this.comboBoxAddSiege.Location = new System.Drawing.Point(239, 21);
            this.comboBoxAddSiege.Name = "comboBoxAddSiege";
            this.comboBoxAddSiege.Size = new System.Drawing.Size(275, 24);
            this.comboBoxAddSiege.TabIndex = 4;
            this.comboBoxAddSiege.SelectedIndexChanged += new System.EventHandler(this.comboBoxAddSiege_SelectedIndexChanged);
            // 
            // FormAddSiege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(539, 370);
            this.Controls.Add(this.comboBoxAddSiege);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddr6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(555, 409);
            this.Name = "FormAddSiege";
            this.Text = "Add your Operation";
            this.Load += new System.EventHandler(this.FormAddSiege_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddr6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAddSiege;
    }
}