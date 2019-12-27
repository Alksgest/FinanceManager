using FinanceManagerClient.Views;

namespace FinanceManagerClient
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
            this.MakeTransactionButton = new System.Windows.Forms.Button();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseUserRankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addTransactionReasonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSearchCriteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabPage = new System.Windows.Forms.TabPage();
            this.mainUserControl1 = new FinanceManagerClient.Controls.MainSettingsUserControl();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.AnnualFeeTabPage = new System.Windows.Forms.TabPage();
            this.ContributionTabPage = new System.Windows.Forms.TabPage();
            this.contributionToGluUserControl1 = new FinanceManagerClient.Controls.TransactionView(this);
            this.OtherIncomeTabPage = new System.Windows.Forms.TabPage();
            this.OtherOutcomeTabPage = new System.Windows.Forms.TabPage();
            this.BalanceTabPage = new System.Windows.Forms.TabPage();
            this.RegistryTabPage = new System.Windows.Forms.TabPage();
            this.MainMenuStrip.SuspendLayout();
            this.MainTabPage.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.ContributionTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MakeTransactionButton
            // 
            this.MakeTransactionButton.Location = new System.Drawing.Point(12, 415);
            this.MakeTransactionButton.Name = "MakeTransactionButton";
            this.MakeTransactionButton.Size = new System.Drawing.Size(162, 23);
            this.MakeTransactionButton.TabIndex = 0;
            this.MakeTransactionButton.Text = "MakeTransaction";
            this.MakeTransactionButton.UseVisualStyleBackColor = true;
            this.MakeTransactionButton.UseWaitCursor = true;
            this.MakeTransactionButton.Click += new System.EventHandler(this.MakeTransactionButtonClick);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.StatisticToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(562, 24);
            this.MainMenuStrip.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeTransactionToolStripMenuItem,
            this.toolStripSeparator1,
            this.addUserToolStripMenuItem,
            this.increaseUserRankToolStripMenuItem,
            this.toolStripSeparator2,
            this.addTransactionReasonToolStripMenuItem,
            this.addSearchCriteriaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // makeTransactionToolStripMenuItem
            // 
            this.makeTransactionToolStripMenuItem.Name = "makeTransactionToolStripMenuItem";
            this.makeTransactionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.makeTransactionToolStripMenuItem.Text = "Make Transaction";
            this.makeTransactionToolStripMenuItem.Click += new System.EventHandler(this.MakeTransactionToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.AddUserToolStripMenuItemClick);
            // 
            // increaseUserRankToolStripMenuItem
            // 
            this.increaseUserRankToolStripMenuItem.Name = "increaseUserRankToolStripMenuItem";
            this.increaseUserRankToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.increaseUserRankToolStripMenuItem.Text = "Increase User Rank";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // addTransactionReasonToolStripMenuItem
            // 
            this.addTransactionReasonToolStripMenuItem.Name = "addTransactionReasonToolStripMenuItem";
            this.addTransactionReasonToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.addTransactionReasonToolStripMenuItem.Text = "Add Transaction Reason";
            this.addTransactionReasonToolStripMenuItem.Click += new System.EventHandler(this.AddTransactionReasonToolStripMenuItemClick);
            // 
            // addSearchCriteriaToolStripMenuItem
            // 
            this.addSearchCriteriaToolStripMenuItem.Name = "addSearchCriteriaToolStripMenuItem";
            this.addSearchCriteriaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.addSearchCriteriaToolStripMenuItem.Text = "Add Search Criteria";
            this.addSearchCriteriaToolStripMenuItem.Click += new System.EventHandler(this.AddSearchCriteriaToolStripMenuItemClick);
            // 
            // StatisticToolStripMenuItem
            // 
            this.StatisticToolStripMenuItem.Name = "StatisticToolStripMenuItem";
            this.StatisticToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.StatisticToolStripMenuItem.Text = "Statistic";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.pDFToolStripMenuItem.Text = "PDF";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // MainTabPage
            // 
            this.MainTabPage.Controls.Add(this.mainUserControl1);
            this.MainTabPage.Location = new System.Drawing.Point(4, 22);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabPage.Size = new System.Drawing.Size(529, 355);
            this.MainTabPage.TabIndex = 0;
            this.MainTabPage.Text = "Main";
            this.MainTabPage.UseVisualStyleBackColor = true;
            // 
            // mainUserControl1
            // 
            this.mainUserControl1.Location = new System.Drawing.Point(0, 0);
            this.mainUserControl1.MaximumSize = new System.Drawing.Size(529, 355);
            this.mainUserControl1.MinimumSize = new System.Drawing.Size(529, 355);
            this.mainUserControl1.Name = "mainUserControl1";
            this.mainUserControl1.Size = new System.Drawing.Size(529, 355);
            this.mainUserControl1.TabIndex = 0;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.MainTabPage);
            this.MainTabControl.Controls.Add(this.AnnualFeeTabPage);
            this.MainTabControl.Controls.Add(this.ContributionTabPage);
            this.MainTabControl.Controls.Add(this.OtherIncomeTabPage);
            this.MainTabControl.Controls.Add(this.OtherOutcomeTabPage);
            this.MainTabControl.Controls.Add(this.BalanceTabPage);
            this.MainTabControl.Controls.Add(this.RegistryTabPage);
            this.MainTabControl.Location = new System.Drawing.Point(13, 28);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(537, 381);
            this.MainTabControl.TabIndex = 3;
            // 
            // AnnualFeeTabPage
            // 
            this.AnnualFeeTabPage.Location = new System.Drawing.Point(4, 22);
            this.AnnualFeeTabPage.Name = "AnnualFeeTabPage";
            this.AnnualFeeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AnnualFeeTabPage.Size = new System.Drawing.Size(529, 355);
            this.AnnualFeeTabPage.TabIndex = 1;
            this.AnnualFeeTabPage.Text = "Annual Fee";
            this.AnnualFeeTabPage.UseVisualStyleBackColor = true;
            // 
            // ContributionTabPage
            // 
            this.ContributionTabPage.Controls.Add(this.contributionToGluUserControl1);
            this.ContributionTabPage.Location = new System.Drawing.Point(4, 22);
            this.ContributionTabPage.Name = "ContributionTabPage";
            this.ContributionTabPage.Size = new System.Drawing.Size(529, 355);
            this.ContributionTabPage.TabIndex = 2;
            this.ContributionTabPage.Text = "Contribution to the GLoU";
            this.ContributionTabPage.UseVisualStyleBackColor = true;
            // 
            // contributionToGluUserControl1
            // 
            this.contributionToGluUserControl1.TransactionsDataSource = null;
            this.contributionToGluUserControl1.Location = new System.Drawing.Point(-3, 0);
            this.contributionToGluUserControl1.MaximumSize = new System.Drawing.Size(529, 355);
            this.contributionToGluUserControl1.MinimumSize = new System.Drawing.Size(529, 355);
            this.contributionToGluUserControl1.Name = "contributionToGluUserControl1";
            this.contributionToGluUserControl1.Size = new System.Drawing.Size(529, 355);
            this.contributionToGluUserControl1.TabIndex = 0;
            // 
            // OtherIncomeTabPage
            // 
            this.OtherIncomeTabPage.Location = new System.Drawing.Point(4, 22);
            this.OtherIncomeTabPage.Name = "OtherIncomeTabPage";
            this.OtherIncomeTabPage.Size = new System.Drawing.Size(529, 355);
            this.OtherIncomeTabPage.TabIndex = 3;
            this.OtherIncomeTabPage.Text = "Other Income";
            this.OtherIncomeTabPage.UseVisualStyleBackColor = true;
            // 
            // OtherOutcomeTabPage
            // 
            this.OtherOutcomeTabPage.Location = new System.Drawing.Point(4, 22);
            this.OtherOutcomeTabPage.Name = "OtherOutcomeTabPage";
            this.OtherOutcomeTabPage.Size = new System.Drawing.Size(529, 355);
            this.OtherOutcomeTabPage.TabIndex = 4;
            this.OtherOutcomeTabPage.Text = "Other Outcome";
            this.OtherOutcomeTabPage.UseVisualStyleBackColor = true;
            // 
            // BalanceTabPage
            // 
            this.BalanceTabPage.Location = new System.Drawing.Point(4, 22);
            this.BalanceTabPage.Name = "BalanceTabPage";
            this.BalanceTabPage.Size = new System.Drawing.Size(529, 355);
            this.BalanceTabPage.TabIndex = 5;
            this.BalanceTabPage.Text = "Balance";
            this.BalanceTabPage.UseVisualStyleBackColor = true;
            // 
            // RegistryTabPage
            // 
            this.RegistryTabPage.Location = new System.Drawing.Point(4, 22);
            this.RegistryTabPage.Name = "RegistryTabPage";
            this.RegistryTabPage.Size = new System.Drawing.Size(529, 355);
            this.RegistryTabPage.TabIndex = 6;
            this.RegistryTabPage.Text = "Registry";
            this.RegistryTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.MakeTransactionButton);
            this.Controls.Add(this.MainMenuStrip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pdks";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainTabPage.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.ContributionTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MakeTransactionButton;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseUserRankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StatisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addTransactionReasonToolStripMenuItem;
        private System.Windows.Forms.TabPage MainTabPage;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage AnnualFeeTabPage;
        private System.Windows.Forms.TabPage ContributionTabPage;
        private System.Windows.Forms.TabPage OtherIncomeTabPage;
        private System.Windows.Forms.TabPage OtherOutcomeTabPage;
        private System.Windows.Forms.TabPage BalanceTabPage;
        private System.Windows.Forms.TabPage RegistryTabPage;
        private Controls.MainSettingsUserControl mainUserControl1;
        private Controls.TransactionView contributionToGluUserControl1;
        private System.Windows.Forms.ToolStripMenuItem addSearchCriteriaToolStripMenuItem;
    }
}

