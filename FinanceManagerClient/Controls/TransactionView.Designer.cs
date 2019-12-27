namespace FinanceManagerClient.Controls
{
    partial class TransactionView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ContributionDataGridView = new System.Windows.Forms.DataGridView();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EditCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ContributionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ContributionDataGridView
            // 
            this.ContributionDataGridView.AutoGenerateColumns = false;
            this.ContributionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContributionDataGridView.DataSource = this.transactionBindingSource;
            this.ContributionDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ContributionDataGridView.Name = "ContributionDataGridView";
            this.ContributionDataGridView.Size = new System.Drawing.Size(523, 266);
            this.ContributionDataGridView.TabIndex = 0;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(FinanceManagerSDK.Models.Transaction);
            // 
            // EditCheckBox
            // 
            this.EditCheckBox.AutoSize = true;
            this.EditCheckBox.Location = new System.Drawing.Point(21, 295);
            this.EditCheckBox.Name = "EditCheckBox";
            this.EditCheckBox.Size = new System.Drawing.Size(73, 17);
            this.EditCheckBox.TabIndex = 1;
            this.EditCheckBox.Text = "Edit mode";
            this.EditCheckBox.UseVisualStyleBackColor = true;
            this.EditCheckBox.CheckedChanged += new System.EventHandler(this.EditCheckBoxCheckedChanged);
            // 
            // ContributionToGluUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EditCheckBox);
            this.Controls.Add(this.ContributionDataGridView);
            this.MaximumSize = new System.Drawing.Size(529, 355);
            this.MinimumSize = new System.Drawing.Size(529, 355);
            this.Name = "ContributionToGluUserControl";
            this.Size = new System.Drawing.Size(529, 355);
            ((System.ComponentModel.ISupportInitialize)(this.ContributionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ContributionDataGridView;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.CheckBox EditCheckBox;
    }
}
