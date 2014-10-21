namespace FRCHelper
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.GlobalSettingsTab = new System.Windows.Forms.TabPage();
            this.settingsTabControl = new System.Windows.Forms.TabControl();
            this.refreshEventCodesButton = new System.Windows.Forms.Button();
            this.GlobalSettingsTab.SuspendLayout();
            this.settingsTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(309, 424);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(390, 424);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // GlobalSettingsTab
            // 
            this.GlobalSettingsTab.Controls.Add(this.refreshEventCodesButton);
            this.GlobalSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.GlobalSettingsTab.Name = "GlobalSettingsTab";
            this.GlobalSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.GlobalSettingsTab.Size = new System.Drawing.Size(472, 380);
            this.GlobalSettingsTab.TabIndex = 0;
            this.GlobalSettingsTab.Text = "FRCHelper";
            this.GlobalSettingsTab.UseVisualStyleBackColor = true;
            // 
            // settingsTabControl
            // 
            this.settingsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsTabControl.Controls.Add(this.GlobalSettingsTab);
            this.settingsTabControl.Location = new System.Drawing.Point(0, 12);
            this.settingsTabControl.Name = "settingsTabControl";
            this.settingsTabControl.SelectedIndex = 0;
            this.settingsTabControl.Size = new System.Drawing.Size(480, 406);
            this.settingsTabControl.TabIndex = 0;
            // 
            // refreshEventCodesButton
            // 
            this.refreshEventCodesButton.Location = new System.Drawing.Point(9, 7);
            this.refreshEventCodesButton.Name = "refreshEventCodesButton";
            this.refreshEventCodesButton.Size = new System.Drawing.Size(185, 23);
            this.refreshEventCodesButton.TabIndex = 0;
            this.refreshEventCodesButton.Text = "Refresh Event Codes";
            this.refreshEventCodesButton.UseVisualStyleBackColor = true;
            this.refreshEventCodesButton.Click += new System.EventHandler(this.refreshEventCodesButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 454);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.settingsTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
            this.GlobalSettingsTab.ResumeLayout(false);
            this.settingsTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TabPage GlobalSettingsTab;
        private System.Windows.Forms.TabControl settingsTabControl;
        private System.Windows.Forms.Button refreshEventCodesButton;
    }
}