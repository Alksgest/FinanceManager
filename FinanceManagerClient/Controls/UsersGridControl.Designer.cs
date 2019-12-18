namespace FinanceManagerClient.Controls
{
    partial class UsersGridControl
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
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.AutoGenerateColumns = false;
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.degreeDataGridViewTextBoxColumn,
            this.accountDataGridViewTextBoxColumn});
            this.UsersDataGridView.DataSource = this.userBindingSource;
            this.UsersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.ReadOnly = true;
            this.UsersDataGridView.Size = new System.Drawing.Size(523, 349);
            this.UsersDataGridView.TabIndex = 0;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FinanceManagerSDK.Models.User);
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.firstnameDataGridViewTextBoxColumn.Width = 110;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lastnameDataGridViewTextBoxColumn.Width = 110;
            // 
            // degreeDataGridViewTextBoxColumn
            // 
            this.degreeDataGridViewTextBoxColumn.DataPropertyName = "Degree";
            this.degreeDataGridViewTextBoxColumn.HeaderText = "Degree";
            this.degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
            this.degreeDataGridViewTextBoxColumn.ReadOnly = true;
            this.degreeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.degreeDataGridViewTextBoxColumn.Width = 110;
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "Account";
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            this.accountDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.accountDataGridViewTextBoxColumn.Width = 150;
            // 
            // UsersGridControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UsersDataGridView);
            this.MaximumSize = new System.Drawing.Size(529, 355);
            this.MinimumSize = new System.Drawing.Size(529, 355);
            this.Name = "UsersGridControl";
            this.Size = new System.Drawing.Size(529, 355);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
    }
}
