namespace FinanceManagerClient
{
    partial class LoginForm
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DegreeComboBox = new System.Windows.Forms.ComboBox();
            this.LastnameLabel = new System.Windows.Forms.Label();
            this.DegreeLabel = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(12, 91);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Enter";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButtonClick);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 25);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(121, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // DegreeComboBox
            // 
            this.DegreeComboBox.FormattingEnabled = true;
            this.DegreeComboBox.Location = new System.Drawing.Point(12, 64);
            this.DegreeComboBox.Name = "DegreeComboBox";
            this.DegreeComboBox.Size = new System.Drawing.Size(121, 21);
            this.DegreeComboBox.TabIndex = 3;
            // 
            // LastnameLabel
            // 
            this.LastnameLabel.AutoSize = true;
            this.LastnameLabel.Location = new System.Drawing.Point(12, 9);
            this.LastnameLabel.Name = "LastnameLabel";
            this.LastnameLabel.Size = new System.Drawing.Size(53, 13);
            this.LastnameLabel.TabIndex = 4;
            this.LastnameLabel.Text = "Lastname";
            // 
            // DegreeLabel
            // 
            this.DegreeLabel.AutoSize = true;
            this.DegreeLabel.Location = new System.Drawing.Point(12, 48);
            this.DegreeLabel.Name = "DegreeLabel";
            this.DegreeLabel.Size = new System.Drawing.Size(42, 13);
            this.DegreeLabel.TabIndex = 5;
            this.DegreeLabel.Text = "Degree";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 121);
            this.Controls.Add(this.DegreeLabel);
            this.Controls.Add(this.LastnameLabel);
            this.Controls.Add(this.DegreeComboBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.LoginButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(170, 160);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox DegreeComboBox;
        private System.Windows.Forms.Label LastnameLabel;
        private System.Windows.Forms.Label DegreeLabel;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}