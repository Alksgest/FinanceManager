namespace FinanceManagerClient
{
    partial class CreateUserForm
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
            this.components = new System.ComponentModel.Container();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.DegreeComboBox = new System.Windows.Forms.ComboBox();
            this.FirstnameTextBox = new System.Windows.Forms.TextBox();
            this.LastnameTextBox = new System.Windows.Forms.TextBox();
            this.FirstnameLabel = new System.Windows.Forms.Label();
            this.LastnameLabel = new System.Windows.Forms.Label();
            this.DegreeLabel = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(12, 130);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 1;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButtonClicked);
            // 
            // DegreeComboBox
            // 
            this.DegreeComboBox.FormattingEnabled = true;
            this.DegreeComboBox.Location = new System.Drawing.Point(12, 103);
            this.DegreeComboBox.Name = "DegreeComboBox";
            this.DegreeComboBox.Size = new System.Drawing.Size(121, 21);
            this.DegreeComboBox.TabIndex = 2;
            // 
            // FirstnameTextBox
            // 
            this.FirstnameTextBox.Location = new System.Drawing.Point(12, 25);
            this.FirstnameTextBox.Name = "FirstnameTextBox";
            this.FirstnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstnameTextBox.TabIndex = 3;
            // 
            // LastnameTextBox
            // 
            this.LastnameTextBox.Location = new System.Drawing.Point(12, 64);
            this.LastnameTextBox.Name = "LastnameTextBox";
            this.LastnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastnameTextBox.TabIndex = 4;
            // 
            // FirstnameLabel
            // 
            this.FirstnameLabel.AutoSize = true;
            this.FirstnameLabel.Location = new System.Drawing.Point(12, 9);
            this.FirstnameLabel.Name = "FirstnameLabel";
            this.FirstnameLabel.Size = new System.Drawing.Size(52, 13);
            this.FirstnameLabel.TabIndex = 5;
            this.FirstnameLabel.Text = "Firstname";
            // 
            // LastnameLabel
            // 
            this.LastnameLabel.AutoSize = true;
            this.LastnameLabel.Location = new System.Drawing.Point(12, 48);
            this.LastnameLabel.Name = "LastnameLabel";
            this.LastnameLabel.Size = new System.Drawing.Size(53, 13);
            this.LastnameLabel.TabIndex = 6;
            this.LastnameLabel.Text = "Lastname";
            // 
            // DegreeLabel
            // 
            this.DegreeLabel.AutoSize = true;
            this.DegreeLabel.Location = new System.Drawing.Point(12, 87);
            this.DegreeLabel.Name = "DegreeLabel";
            this.DegreeLabel.Size = new System.Drawing.Size(42, 13);
            this.DegreeLabel.TabIndex = 7;
            this.DegreeLabel.Text = "Degree";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 161);
            this.Controls.Add(this.DegreeLabel);
            this.Controls.Add(this.LastnameLabel);
            this.Controls.Add(this.FirstnameLabel);
            this.Controls.Add(this.LastnameTextBox);
            this.Controls.Add(this.FirstnameTextBox);
            this.Controls.Add(this.DegreeComboBox);
            this.Controls.Add(this.SubmitButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(160, 200);
            this.Name = "CreateUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create User";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ComboBox DegreeComboBox;
        private System.Windows.Forms.TextBox FirstnameTextBox;
        private System.Windows.Forms.TextBox LastnameTextBox;
        private System.Windows.Forms.Label FirstnameLabel;
        private System.Windows.Forms.Label LastnameLabel;
        private System.Windows.Forms.Label DegreeLabel;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}