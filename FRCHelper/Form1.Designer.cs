namespace FRCHelper
{
    partial class FRCHelperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRCHelperForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.eventNameBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.eventTab = new System.Windows.Forms.TabPage();
            this.getEventDataButton = new System.Windows.Forms.Button();
            this.eventEndDateBox = new System.Windows.Forms.TextBox();
            this.eventStartDateBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.eventLocationBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.eventVenueBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eventDistrictCodeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eventTypeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teamsTab = new System.Windows.Forms.TabPage();
            this.getTeamInfoButton = new System.Windows.Forms.Button();
            this.teamComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.teamRobotNameBox = new System.Windows.Forms.TextBox();
            this.teamRookieYearBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.teamLocationBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.teamNickNameBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.teamShortNameBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.teamFullNameBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.teamDistrictCodeBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.eventTab.SuspendLayout();
            this.teamsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(566, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // eventComboBox
            // 
            this.eventComboBox.FormattingEnabled = true;
            this.eventComboBox.Location = new System.Drawing.Point(76, 6);
            this.eventComboBox.Name = "eventComboBox";
            this.eventComboBox.Size = new System.Drawing.Size(82, 21);
            this.eventComboBox.TabIndex = 1;
            this.eventComboBox.SelectedIndexChanged += new System.EventHandler(this.eventComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Event Code";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // eventNameBox
            // 
            this.eventNameBox.Location = new System.Drawing.Point(164, 6);
            this.eventNameBox.Name = "eventNameBox";
            this.eventNameBox.Size = new System.Drawing.Size(313, 20);
            this.eventNameBox.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.eventTab);
            this.tabControl1.Controls.Add(this.teamsTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(566, 454);
            this.tabControl1.TabIndex = 5;
            // 
            // eventTab
            // 
            this.eventTab.BackColor = System.Drawing.Color.Transparent;
            this.eventTab.Controls.Add(this.getEventDataButton);
            this.eventTab.Controls.Add(this.eventEndDateBox);
            this.eventTab.Controls.Add(this.eventStartDateBox);
            this.eventTab.Controls.Add(this.label7);
            this.eventTab.Controls.Add(this.eventLocationBox);
            this.eventTab.Controls.Add(this.label6);
            this.eventTab.Controls.Add(this.eventVenueBox);
            this.eventTab.Controls.Add(this.label5);
            this.eventTab.Controls.Add(this.eventDistrictCodeBox);
            this.eventTab.Controls.Add(this.label4);
            this.eventTab.Controls.Add(this.eventTypeBox);
            this.eventTab.Controls.Add(this.label3);
            this.eventTab.Controls.Add(this.eventNameBox);
            this.eventTab.Controls.Add(this.label2);
            this.eventTab.Controls.Add(this.eventComboBox);
            this.eventTab.Controls.Add(this.label1);
            this.eventTab.Location = new System.Drawing.Point(4, 22);
            this.eventTab.Name = "eventTab";
            this.eventTab.Padding = new System.Windows.Forms.Padding(3);
            this.eventTab.Size = new System.Drawing.Size(558, 428);
            this.eventTab.TabIndex = 0;
            this.eventTab.Text = "Event";
            // 
            // getEventDataButton
            // 
            this.getEventDataButton.Location = new System.Drawing.Point(6, 33);
            this.getEventDataButton.Name = "getEventDataButton";
            this.getEventDataButton.Size = new System.Drawing.Size(213, 23);
            this.getEventDataButton.TabIndex = 5;
            this.getEventDataButton.Text = "Get Event Data";
            this.getEventDataButton.UseVisualStyleBackColor = true;
            this.getEventDataButton.Click += new System.EventHandler(this.getEventDataButton_Click);
            // 
            // eventEndDateBox
            // 
            this.eventEndDateBox.Location = new System.Drawing.Point(66, 192);
            this.eventEndDateBox.Name = "eventEndDateBox";
            this.eventEndDateBox.Size = new System.Drawing.Size(292, 20);
            this.eventEndDateBox.TabIndex = 4;
            // 
            // eventStartDateBox
            // 
            this.eventStartDateBox.Location = new System.Drawing.Point(69, 166);
            this.eventStartDateBox.Name = "eventStartDateBox";
            this.eventStartDateBox.Size = new System.Drawing.Size(289, 20);
            this.eventStartDateBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "End Date";
            // 
            // eventLocationBox
            // 
            this.eventLocationBox.Location = new System.Drawing.Point(62, 140);
            this.eventLocationBox.Name = "eventLocationBox";
            this.eventLocationBox.Size = new System.Drawing.Size(296, 20);
            this.eventLocationBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Start Date";
            // 
            // eventVenueBox
            // 
            this.eventVenueBox.Location = new System.Drawing.Point(52, 114);
            this.eventVenueBox.Name = "eventVenueBox";
            this.eventVenueBox.Size = new System.Drawing.Size(306, 20);
            this.eventVenueBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Location";
            // 
            // eventDistrictCodeBox
            // 
            this.eventDistrictCodeBox.Location = new System.Drawing.Point(81, 88);
            this.eventDistrictCodeBox.Name = "eventDistrictCodeBox";
            this.eventDistrictCodeBox.Size = new System.Drawing.Size(277, 20);
            this.eventDistrictCodeBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Venue";
            // 
            // eventTypeBox
            // 
            this.eventTypeBox.Location = new System.Drawing.Point(45, 62);
            this.eventTypeBox.Name = "eventTypeBox";
            this.eventTypeBox.Size = new System.Drawing.Size(313, 20);
            this.eventTypeBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "District Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // teamsTab
            // 
            this.teamsTab.Controls.Add(this.teamDistrictCodeBox);
            this.teamsTab.Controls.Add(this.teamRobotNameBox);
            this.teamsTab.Controls.Add(this.label15);
            this.teamsTab.Controls.Add(this.teamRookieYearBox);
            this.teamsTab.Controls.Add(this.label9);
            this.teamsTab.Controls.Add(this.teamLocationBox);
            this.teamsTab.Controls.Add(this.label10);
            this.teamsTab.Controls.Add(this.teamNickNameBox);
            this.teamsTab.Controls.Add(this.label11);
            this.teamsTab.Controls.Add(this.teamShortNameBox);
            this.teamsTab.Controls.Add(this.label12);
            this.teamsTab.Controls.Add(this.teamFullNameBox);
            this.teamsTab.Controls.Add(this.label13);
            this.teamsTab.Controls.Add(this.label14);
            this.teamsTab.Controls.Add(this.getTeamInfoButton);
            this.teamsTab.Controls.Add(this.teamComboBox);
            this.teamsTab.Controls.Add(this.label8);
            this.teamsTab.Location = new System.Drawing.Point(4, 22);
            this.teamsTab.Name = "teamsTab";
            this.teamsTab.Padding = new System.Windows.Forms.Padding(3);
            this.teamsTab.Size = new System.Drawing.Size(558, 428);
            this.teamsTab.TabIndex = 1;
            this.teamsTab.Text = "Teams";
            this.teamsTab.UseVisualStyleBackColor = true;
            // 
            // getTeamInfoButton
            // 
            this.getTeamInfoButton.Location = new System.Drawing.Point(13, 31);
            this.getTeamInfoButton.Name = "getTeamInfoButton";
            this.getTeamInfoButton.Size = new System.Drawing.Size(213, 23);
            this.getTeamInfoButton.TabIndex = 8;
            this.getTeamInfoButton.Text = "Get Team Info";
            this.getTeamInfoButton.UseVisualStyleBackColor = true;
            this.getTeamInfoButton.Click += new System.EventHandler(this.getTeamInfoButton_Click);
            // 
            // teamComboBox
            // 
            this.teamComboBox.FormattingEnabled = true;
            this.teamComboBox.Location = new System.Drawing.Point(60, 4);
            this.teamComboBox.Name = "teamComboBox";
            this.teamComboBox.Size = new System.Drawing.Size(100, 21);
            this.teamComboBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Team #";
            // 
            // teamRobotNameBox
            // 
            this.teamRobotNameBox.Location = new System.Drawing.Point(79, 196);
            this.teamRobotNameBox.Name = "teamRobotNameBox";
            this.teamRobotNameBox.Size = new System.Drawing.Size(277, 20);
            this.teamRobotNameBox.TabIndex = 15;
            // 
            // teamRookieYearBox
            // 
            this.teamRookieYearBox.Location = new System.Drawing.Point(78, 170);
            this.teamRookieYearBox.Name = "teamRookieYearBox";
            this.teamRookieYearBox.Size = new System.Drawing.Size(278, 20);
            this.teamRookieYearBox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Robot Name";
            // 
            // teamLocationBox
            // 
            this.teamLocationBox.Location = new System.Drawing.Point(60, 144);
            this.teamLocationBox.Name = "teamLocationBox";
            this.teamLocationBox.Size = new System.Drawing.Size(296, 20);
            this.teamLocationBox.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Rookie Year";
            // 
            // teamNickNameBox
            // 
            this.teamNickNameBox.Location = new System.Drawing.Point(67, 118);
            this.teamNickNameBox.Name = "teamNickNameBox";
            this.teamNickNameBox.Size = new System.Drawing.Size(289, 20);
            this.teamNickNameBox.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Location";
            // 
            // teamShortNameBox
            // 
            this.teamShortNameBox.Location = new System.Drawing.Point(79, 92);
            this.teamShortNameBox.Name = "teamShortNameBox";
            this.teamShortNameBox.Size = new System.Drawing.Size(277, 20);
            this.teamShortNameBox.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Nickname";
            // 
            // teamFullNameBox
            // 
            this.teamFullNameBox.Location = new System.Drawing.Point(60, 66);
            this.teamFullNameBox.Name = "teamFullNameBox";
            this.teamFullNameBox.Size = new System.Drawing.Size(296, 20);
            this.teamFullNameBox.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Short Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Full Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "District Code";
            // 
            // teamDistrictCodeBox
            // 
            this.teamDistrictCodeBox.Location = new System.Drawing.Point(78, 222);
            this.teamDistrictCodeBox.Name = "teamDistrictCodeBox";
            this.teamDistrictCodeBox.Size = new System.Drawing.Size(278, 20);
            this.teamDistrictCodeBox.TabIndex = 15;
            // 
            // FRCHelperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 545);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRCHelperForm";
            this.Text = "FRC Helper";
            this.Load += new System.EventHandler(this.FRCHelperForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.eventTab.ResumeLayout(false);
            this.eventTab.PerformLayout();
            this.teamsTab.ResumeLayout(false);
            this.teamsTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ComboBox eventComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TextBox eventNameBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage eventTab;
        private System.Windows.Forms.Button getEventDataButton;
        private System.Windows.Forms.TextBox eventEndDateBox;
        private System.Windows.Forms.TextBox eventStartDateBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox eventLocationBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox eventVenueBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eventDistrictCodeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox eventTypeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage teamsTab;
        private System.Windows.Forms.Button getTeamInfoButton;
        private System.Windows.Forms.ComboBox teamComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox teamDistrictCodeBox;
        private System.Windows.Forms.TextBox teamRobotNameBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox teamRookieYearBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox teamLocationBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox teamNickNameBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox teamShortNameBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox teamFullNameBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

