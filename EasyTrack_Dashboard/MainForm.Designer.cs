﻿namespace EasyTrack_Dashboard
{
    partial class MainForm
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
            this.appTopBarPanel = new System.Windows.Forms.Panel();
            this.toggleFeaturesButton = new System.Windows.Forms.Button();
            this.appTitleLabel = new System.Windows.Forms.Label();
            this.rootSplitContaner = new System.Windows.Forms.SplitContainer();
            this.feedbacksButton = new System.Windows.Forms.Button();
            this.logsButton = new System.Windows.Forms.Button();
            this.userStatsButton = new System.Windows.Forms.Button();
            this.campaignsButton = new System.Windows.Forms.Button();
            this.rootTabControl = new System.Windows.Forms.TabControl();
            this.campaignsTabPage = new System.Windows.Forms.TabPage();
            this.campaignsTopBarPanel = new System.Windows.Forms.Panel();
            this.campaignListLabel = new System.Windows.Forms.Label();
            this.campaignsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.userStatsTabPage = new System.Windows.Forms.TabPage();
            this.logsTabPage = new System.Windows.Forms.TabPage();
            this.feedbacksTabPage = new System.Windows.Forms.TabPage();
            this.userStatsTopBarPanel = new System.Windows.Forms.Panel();
            this.userStatsLabel = new System.Windows.Forms.Label();
            this.userStatsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.logsTopBarPanel = new System.Windows.Forms.Panel();
            this.logsLabel = new System.Windows.Forms.Label();
            this.logsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.feedbacksTopBarPanel = new System.Windows.Forms.Panel();
            this.feedbacksLabel = new System.Windows.Forms.Label();
            this.createNewCampaignButton = new System.Windows.Forms.Button();
            this.experimenterProfile = new EasyTrack_Dashboard.ExperimenterProfile();
            this.appTopBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootSplitContaner)).BeginInit();
            this.rootSplitContaner.Panel1.SuspendLayout();
            this.rootSplitContaner.Panel2.SuspendLayout();
            this.rootSplitContaner.SuspendLayout();
            this.rootTabControl.SuspendLayout();
            this.campaignsTabPage.SuspendLayout();
            this.campaignsTopBarPanel.SuspendLayout();
            this.userStatsTabPage.SuspendLayout();
            this.logsTabPage.SuspendLayout();
            this.feedbacksTabPage.SuspendLayout();
            this.userStatsTopBarPanel.SuspendLayout();
            this.logsTopBarPanel.SuspendLayout();
            this.feedbacksTopBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // appTopBarPanel
            // 
            this.appTopBarPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.appTopBarPanel.Controls.Add(this.toggleFeaturesButton);
            this.appTopBarPanel.Controls.Add(this.appTitleLabel);
            this.appTopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.appTopBarPanel.Name = "appTopBarPanel";
            this.appTopBarPanel.Size = new System.Drawing.Size(1384, 44);
            this.appTopBarPanel.TabIndex = 1;
            // 
            // toggleFeaturesButton
            // 
            this.toggleFeaturesButton.BackColor = System.Drawing.Color.Transparent;
            this.toggleFeaturesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleFeaturesButton.FlatAppearance.BorderSize = 0;
            this.toggleFeaturesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.toggleFeaturesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleFeaturesButton.Image = global::EasyTrack_Dashboard.Properties.Resources.menu;
            this.toggleFeaturesButton.Location = new System.Drawing.Point(12, 9);
            this.toggleFeaturesButton.Name = "toggleFeaturesButton";
            this.toggleFeaturesButton.Size = new System.Drawing.Size(24, 24);
            this.toggleFeaturesButton.TabIndex = 1;
            this.toggleFeaturesButton.TabStop = false;
            this.toggleFeaturesButton.UseVisualStyleBackColor = false;
            this.toggleFeaturesButton.Click += new System.EventHandler(this.toggleFeaturesButton_Click);
            // 
            // appTitleLabel
            // 
            this.appTitleLabel.AutoSize = true;
            this.appTitleLabel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold);
            this.appTitleLabel.ForeColor = System.Drawing.Color.White;
            this.appTitleLabel.Location = new System.Drawing.Point(42, 9);
            this.appTitleLabel.Name = "appTitleLabel";
            this.appTitleLabel.Size = new System.Drawing.Size(114, 27);
            this.appTitleLabel.TabIndex = 0;
            this.appTitleLabel.Text = "EasyTrack";
            // 
            // rootSplitContaner
            // 
            this.rootSplitContaner.BackColor = System.Drawing.Color.DodgerBlue;
            this.rootSplitContaner.IsSplitterFixed = true;
            this.rootSplitContaner.Location = new System.Drawing.Point(0, 45);
            this.rootSplitContaner.Name = "rootSplitContaner";
            // 
            // rootSplitContaner.Panel1
            // 
            this.rootSplitContaner.Panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.rootSplitContaner.Panel1.Controls.Add(this.feedbacksButton);
            this.rootSplitContaner.Panel1.Controls.Add(this.logsButton);
            this.rootSplitContaner.Panel1.Controls.Add(this.userStatsButton);
            this.rootSplitContaner.Panel1.Controls.Add(this.campaignsButton);
            this.rootSplitContaner.Panel1.Controls.Add(this.experimenterProfile);
            this.rootSplitContaner.Panel1.Margin = new System.Windows.Forms.Padding(10);
            // 
            // rootSplitContaner.Panel2
            // 
            this.rootSplitContaner.Panel2.Controls.Add(this.rootTabControl);
            this.rootSplitContaner.Size = new System.Drawing.Size(1384, 716);
            this.rootSplitContaner.SplitterDistance = 300;
            this.rootSplitContaner.SplitterWidth = 1;
            this.rootSplitContaner.TabIndex = 2;
            // 
            // feedbacksButton
            // 
            this.feedbacksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feedbacksButton.FlatAppearance.BorderSize = 0;
            this.feedbacksButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.feedbacksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedbacksButton.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.feedbacksButton.ForeColor = System.Drawing.Color.White;
            this.feedbacksButton.Location = new System.Drawing.Point(19, 389);
            this.feedbacksButton.Name = "feedbacksButton";
            this.feedbacksButton.Size = new System.Drawing.Size(260, 50);
            this.feedbacksButton.TabIndex = 11;
            this.feedbacksButton.Text = "Feedbacks";
            this.feedbacksButton.UseVisualStyleBackColor = true;
            this.feedbacksButton.Click += new System.EventHandler(this.feedbacksButton_Click);
            // 
            // logsButton
            // 
            this.logsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logsButton.FlatAppearance.BorderSize = 0;
            this.logsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.logsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logsButton.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.logsButton.ForeColor = System.Drawing.Color.White;
            this.logsButton.Location = new System.Drawing.Point(19, 318);
            this.logsButton.Name = "logsButton";
            this.logsButton.Size = new System.Drawing.Size(260, 50);
            this.logsButton.TabIndex = 10;
            this.logsButton.Text = "Logs";
            this.logsButton.UseVisualStyleBackColor = true;
            this.logsButton.Click += new System.EventHandler(this.logsButton_Click);
            // 
            // userStatsButton
            // 
            this.userStatsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userStatsButton.FlatAppearance.BorderSize = 0;
            this.userStatsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.userStatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userStatsButton.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.userStatsButton.ForeColor = System.Drawing.Color.White;
            this.userStatsButton.Location = new System.Drawing.Point(19, 247);
            this.userStatsButton.Name = "userStatsButton";
            this.userStatsButton.Size = new System.Drawing.Size(260, 50);
            this.userStatsButton.TabIndex = 9;
            this.userStatsButton.Text = "User stats";
            this.userStatsButton.UseVisualStyleBackColor = true;
            this.userStatsButton.Click += new System.EventHandler(this.userStatsButton_Click);
            // 
            // campaignsButton
            // 
            this.campaignsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.campaignsButton.FlatAppearance.BorderSize = 0;
            this.campaignsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.campaignsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.campaignsButton.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold);
            this.campaignsButton.ForeColor = System.Drawing.Color.White;
            this.campaignsButton.Location = new System.Drawing.Point(19, 176);
            this.campaignsButton.Name = "campaignsButton";
            this.campaignsButton.Size = new System.Drawing.Size(260, 50);
            this.campaignsButton.TabIndex = 8;
            this.campaignsButton.Text = "Campaigns";
            this.campaignsButton.UseVisualStyleBackColor = true;
            this.campaignsButton.Click += new System.EventHandler(this.campaignsButton_Click);
            // 
            // rootTabControl
            // 
            this.rootTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rootTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.rootTabControl.Controls.Add(this.campaignsTabPage);
            this.rootTabControl.Controls.Add(this.userStatsTabPage);
            this.rootTabControl.Controls.Add(this.logsTabPage);
            this.rootTabControl.Controls.Add(this.feedbacksTabPage);
            this.rootTabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.rootTabControl.Location = new System.Drawing.Point(-5, -5);
            this.rootTabControl.Name = "rootTabControl";
            this.rootTabControl.SelectedIndex = 0;
            this.rootTabControl.Size = new System.Drawing.Size(1090, 725);
            this.rootTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.rootTabControl.TabIndex = 1;
            // 
            // campaignsTabPage
            // 
            this.campaignsTabPage.BackColor = System.Drawing.Color.DodgerBlue;
            this.campaignsTabPage.Controls.Add(this.campaignsTopBarPanel);
            this.campaignsTabPage.Controls.Add(this.campaignsFlowLayoutPanel);
            this.campaignsTabPage.Location = new System.Drawing.Point(4, 5);
            this.campaignsTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.campaignsTabPage.Name = "campaignsTabPage";
            this.campaignsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.campaignsTabPage.Size = new System.Drawing.Size(1082, 716);
            this.campaignsTabPage.TabIndex = 0;
            this.campaignsTabPage.Text = "tabPage1";
            // 
            // campaignsTopBarPanel
            // 
            this.campaignsTopBarPanel.Controls.Add(this.createNewCampaignButton);
            this.campaignsTopBarPanel.Controls.Add(this.campaignListLabel);
            this.campaignsTopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.campaignsTopBarPanel.Location = new System.Drawing.Point(3, 3);
            this.campaignsTopBarPanel.Name = "campaignsTopBarPanel";
            this.campaignsTopBarPanel.Size = new System.Drawing.Size(1076, 37);
            this.campaignsTopBarPanel.TabIndex = 3;
            // 
            // campaignListLabel
            // 
            this.campaignListLabel.AutoSize = true;
            this.campaignListLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.campaignListLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.campaignListLabel.ForeColor = System.Drawing.Color.White;
            this.campaignListLabel.Location = new System.Drawing.Point(0, 0);
            this.campaignListLabel.Name = "campaignListLabel";
            this.campaignListLabel.Padding = new System.Windows.Forms.Padding(0, 6, 6, 0);
            this.campaignListLabel.Size = new System.Drawing.Size(186, 31);
            this.campaignListLabel.TabIndex = 0;
            this.campaignListLabel.Text = "CAMPAIGNS LIST";
            // 
            // campaignsFlowLayoutPanel
            // 
            this.campaignsFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.campaignsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.campaignsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.campaignsFlowLayoutPanel.Location = new System.Drawing.Point(3, 46);
            this.campaignsFlowLayoutPanel.Name = "campaignsFlowLayoutPanel";
            this.campaignsFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.campaignsFlowLayoutPanel.Size = new System.Drawing.Size(1076, 667);
            this.campaignsFlowLayoutPanel.TabIndex = 2;
            // 
            // userStatsTabPage
            // 
            this.userStatsTabPage.BackColor = System.Drawing.Color.DodgerBlue;
            this.userStatsTabPage.Controls.Add(this.userStatsTopBarPanel);
            this.userStatsTabPage.Controls.Add(this.userStatsFlowLayoutPanel);
            this.userStatsTabPage.Location = new System.Drawing.Point(4, 5);
            this.userStatsTabPage.Name = "userStatsTabPage";
            this.userStatsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userStatsTabPage.Size = new System.Drawing.Size(1082, 716);
            this.userStatsTabPage.TabIndex = 1;
            this.userStatsTabPage.Text = "tabPage2";
            // 
            // logsTabPage
            // 
            this.logsTabPage.BackColor = System.Drawing.Color.DodgerBlue;
            this.logsTabPage.Controls.Add(this.logsTopBarPanel);
            this.logsTabPage.Controls.Add(this.logsFlowLayoutPanel);
            this.logsTabPage.Location = new System.Drawing.Point(4, 5);
            this.logsTabPage.Name = "logsTabPage";
            this.logsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.logsTabPage.Size = new System.Drawing.Size(1082, 716);
            this.logsTabPage.TabIndex = 2;
            this.logsTabPage.Text = "tabPage1";
            // 
            // feedbacksTabPage
            // 
            this.feedbacksTabPage.BackColor = System.Drawing.Color.DodgerBlue;
            this.feedbacksTabPage.Controls.Add(this.feedbacksTopBarPanel);
            this.feedbacksTabPage.Location = new System.Drawing.Point(4, 5);
            this.feedbacksTabPage.Name = "feedbacksTabPage";
            this.feedbacksTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.feedbacksTabPage.Size = new System.Drawing.Size(1082, 716);
            this.feedbacksTabPage.TabIndex = 3;
            this.feedbacksTabPage.Text = "tabPage2";
            // 
            // userStatsTopBarPanel
            // 
            this.userStatsTopBarPanel.Controls.Add(this.userStatsLabel);
            this.userStatsTopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userStatsTopBarPanel.Location = new System.Drawing.Point(3, 3);
            this.userStatsTopBarPanel.Name = "userStatsTopBarPanel";
            this.userStatsTopBarPanel.Size = new System.Drawing.Size(1076, 32);
            this.userStatsTopBarPanel.TabIndex = 5;
            // 
            // userStatsLabel
            // 
            this.userStatsLabel.AutoSize = true;
            this.userStatsLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.userStatsLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userStatsLabel.ForeColor = System.Drawing.Color.White;
            this.userStatsLabel.Location = new System.Drawing.Point(0, 0);
            this.userStatsLabel.Name = "userStatsLabel";
            this.userStatsLabel.Size = new System.Drawing.Size(185, 25);
            this.userStatsLabel.TabIndex = 0;
            this.userStatsLabel.Text = "USER STATISTICS";
            // 
            // userStatsFlowLayoutPanel
            // 
            this.userStatsFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.userStatsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userStatsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.userStatsFlowLayoutPanel.Location = new System.Drawing.Point(3, 46);
            this.userStatsFlowLayoutPanel.Name = "userStatsFlowLayoutPanel";
            this.userStatsFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.userStatsFlowLayoutPanel.Size = new System.Drawing.Size(1076, 667);
            this.userStatsFlowLayoutPanel.TabIndex = 4;
            // 
            // logsTopBarPanel
            // 
            this.logsTopBarPanel.Controls.Add(this.logsLabel);
            this.logsTopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logsTopBarPanel.Location = new System.Drawing.Point(3, 3);
            this.logsTopBarPanel.Name = "logsTopBarPanel";
            this.logsTopBarPanel.Size = new System.Drawing.Size(1076, 32);
            this.logsTopBarPanel.TabIndex = 7;
            // 
            // logsLabel
            // 
            this.logsLabel.AutoSize = true;
            this.logsLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.logsLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logsLabel.ForeColor = System.Drawing.Color.White;
            this.logsLabel.Location = new System.Drawing.Point(0, 0);
            this.logsLabel.Name = "logsLabel";
            this.logsLabel.Size = new System.Drawing.Size(64, 25);
            this.logsLabel.TabIndex = 0;
            this.logsLabel.Text = "LOGS";
            // 
            // logsFlowLayoutPanel
            // 
            this.logsFlowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.logsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.logsFlowLayoutPanel.Location = new System.Drawing.Point(3, 46);
            this.logsFlowLayoutPanel.Name = "logsFlowLayoutPanel";
            this.logsFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.logsFlowLayoutPanel.Size = new System.Drawing.Size(1076, 667);
            this.logsFlowLayoutPanel.TabIndex = 6;
            // 
            // feedbacksTopBarPanel
            // 
            this.feedbacksTopBarPanel.Controls.Add(this.feedbacksLabel);
            this.feedbacksTopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.feedbacksTopBarPanel.Location = new System.Drawing.Point(3, 3);
            this.feedbacksTopBarPanel.Name = "feedbacksTopBarPanel";
            this.feedbacksTopBarPanel.Size = new System.Drawing.Size(1076, 32);
            this.feedbacksTopBarPanel.TabIndex = 7;
            // 
            // feedbacksLabel
            // 
            this.feedbacksLabel.AutoSize = true;
            this.feedbacksLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.feedbacksLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feedbacksLabel.ForeColor = System.Drawing.Color.White;
            this.feedbacksLabel.Location = new System.Drawing.Point(0, 0);
            this.feedbacksLabel.Name = "feedbacksLabel";
            this.feedbacksLabel.Size = new System.Drawing.Size(129, 25);
            this.feedbacksLabel.TabIndex = 0;
            this.feedbacksLabel.Text = "FEEDBACKS";
            // 
            // createNewCampaignButton
            // 
            this.createNewCampaignButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createNewCampaignButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.createNewCampaignButton.FlatAppearance.BorderSize = 0;
            this.createNewCampaignButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.createNewCampaignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewCampaignButton.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold);
            this.createNewCampaignButton.ForeColor = System.Drawing.Color.Lime;
            this.createNewCampaignButton.Image = global::EasyTrack_Dashboard.Properties.Resources.new_campaign;
            this.createNewCampaignButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createNewCampaignButton.Location = new System.Drawing.Point(776, 0);
            this.createNewCampaignButton.Name = "createNewCampaignButton";
            this.createNewCampaignButton.Size = new System.Drawing.Size(300, 37);
            this.createNewCampaignButton.TabIndex = 2;
            this.createNewCampaignButton.Text = "CREATE NEW CAMPAIGN";
            this.createNewCampaignButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createNewCampaignButton.UseVisualStyleBackColor = true;
            // 
            // experimenterProfile
            // 
            this.experimenterProfile.BackColor = System.Drawing.Color.SteelBlue;
            this.experimenterProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.experimenterProfile.Location = new System.Drawing.Point(0, 0);
            this.experimenterProfile.Margin = new System.Windows.Forms.Padding(5);
            this.experimenterProfile.Name = "experimenterProfile";
            this.experimenterProfile.Padding = new System.Windows.Forms.Padding(5);
            this.experimenterProfile.Size = new System.Drawing.Size(300, 64);
            this.experimenterProfile.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.rootSplitContaner);
            this.Controls.Add(this.appTopBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyTrack: Large-scale Mobile User Study Monitoring Platform";
            this.appTopBarPanel.ResumeLayout(false);
            this.appTopBarPanel.PerformLayout();
            this.rootSplitContaner.Panel1.ResumeLayout(false);
            this.rootSplitContaner.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rootSplitContaner)).EndInit();
            this.rootSplitContaner.ResumeLayout(false);
            this.rootTabControl.ResumeLayout(false);
            this.campaignsTabPage.ResumeLayout(false);
            this.campaignsTopBarPanel.ResumeLayout(false);
            this.campaignsTopBarPanel.PerformLayout();
            this.userStatsTabPage.ResumeLayout(false);
            this.logsTabPage.ResumeLayout(false);
            this.feedbacksTabPage.ResumeLayout(false);
            this.userStatsTopBarPanel.ResumeLayout(false);
            this.userStatsTopBarPanel.PerformLayout();
            this.logsTopBarPanel.ResumeLayout(false);
            this.logsTopBarPanel.PerformLayout();
            this.feedbacksTopBarPanel.ResumeLayout(false);
            this.feedbacksTopBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel appTopBarPanel;
        private System.Windows.Forms.Label appTitleLabel;
        private System.Windows.Forms.Button toggleFeaturesButton;
        private System.Windows.Forms.SplitContainer rootSplitContaner;
        private System.Windows.Forms.TabControl rootTabControl;
        private System.Windows.Forms.TabPage campaignsTabPage;
        private System.Windows.Forms.TabPage userStatsTabPage;
        private System.Windows.Forms.TabPage logsTabPage;
        private System.Windows.Forms.TabPage feedbacksTabPage;
        private System.Windows.Forms.Label campaignListLabel;
        private System.Windows.Forms.FlowLayoutPanel campaignsFlowLayoutPanel;
        private System.Windows.Forms.Panel campaignsTopBarPanel;
        private ExperimenterProfile experimenterProfile;
        private System.Windows.Forms.Button campaignsButton;
        private System.Windows.Forms.Button userStatsButton;
        private System.Windows.Forms.Button logsButton;
        private System.Windows.Forms.Button feedbacksButton;
        private System.Windows.Forms.Panel userStatsTopBarPanel;
        private System.Windows.Forms.Label userStatsLabel;
        private System.Windows.Forms.FlowLayoutPanel userStatsFlowLayoutPanel;
        private System.Windows.Forms.Panel logsTopBarPanel;
        private System.Windows.Forms.Label logsLabel;
        private System.Windows.Forms.FlowLayoutPanel logsFlowLayoutPanel;
        private System.Windows.Forms.Panel feedbacksTopBarPanel;
        private System.Windows.Forms.Label feedbacksLabel;
        private System.Windows.Forms.Button createNewCampaignButton;
    }
}

