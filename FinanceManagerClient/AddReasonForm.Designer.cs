namespace FinanceManagerClient
{
    partial class AddReasonForm
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
            this.CreateButton = new System.Windows.Forms.Button();
            this.ShortDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.LongDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ShortDescriptionLabel = new System.Windows.Forms.Label();
            this.LongDescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(11, 185);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButtonClick);
            // 
            // ShortDescriptionTextBox
            // 
            this.ShortDescriptionTextBox.Location = new System.Drawing.Point(11, 25);
            this.ShortDescriptionTextBox.MaxLength = 20;
            this.ShortDescriptionTextBox.Name = "ShortDescriptionTextBox";
            this.ShortDescriptionTextBox.Size = new System.Drawing.Size(174, 20);
            this.ShortDescriptionTextBox.TabIndex = 1;
            // 
            // LongDescriptionTextBox
            // 
            this.LongDescriptionTextBox.Location = new System.Drawing.Point(11, 64);
            this.LongDescriptionTextBox.Multiline = true;
            this.LongDescriptionTextBox.Name = "LongDescriptionTextBox";
            this.LongDescriptionTextBox.Size = new System.Drawing.Size(174, 115);
            this.LongDescriptionTextBox.TabIndex = 2;
            // 
            // ShortDescriptionLabel
            // 
            this.ShortDescriptionLabel.AutoSize = true;
            this.ShortDescriptionLabel.Location = new System.Drawing.Point(8, 9);
            this.ShortDescriptionLabel.Name = "ShortDescriptionLabel";
            this.ShortDescriptionLabel.Size = new System.Drawing.Size(88, 13);
            this.ShortDescriptionLabel.TabIndex = 3;
            this.ShortDescriptionLabel.Text = "Short Description";
            // 
            // LongDescriptionLabel
            // 
            this.LongDescriptionLabel.AutoSize = true;
            this.LongDescriptionLabel.Location = new System.Drawing.Point(9, 48);
            this.LongDescriptionLabel.Name = "LongDescriptionLabel";
            this.LongDescriptionLabel.Size = new System.Drawing.Size(87, 13);
            this.LongDescriptionLabel.TabIndex = 4;
            this.LongDescriptionLabel.Text = "Long Description";
            // 
            // AddReasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 211);
            this.Controls.Add(this.LongDescriptionLabel);
            this.Controls.Add(this.ShortDescriptionLabel);
            this.Controls.Add(this.LongDescriptionTextBox);
            this.Controls.Add(this.ShortDescriptionTextBox);
            this.Controls.Add(this.CreateButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(220, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(220, 250);
            this.Name = "AddReasonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Reason";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox ShortDescriptionTextBox;
        private System.Windows.Forms.TextBox LongDescriptionTextBox;
        private System.Windows.Forms.Label ShortDescriptionLabel;
        private System.Windows.Forms.Label LongDescriptionLabel;
    }
}