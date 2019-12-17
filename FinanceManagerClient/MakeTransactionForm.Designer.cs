namespace FinanceManagerClient
{
    partial class MakeTransactionForm
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
            this.AmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.ReasonComboBox = new System.Windows.Forms.ComboBox();
            this.BrotherComboBox = new System.Windows.Forms.ComboBox();
            this.CurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.BrotherLabel = new System.Windows.Forms.Label();
            this.ReasonLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.MakeTrButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AmountNumericUpDown
            // 
            this.AmountNumericUpDown.Location = new System.Drawing.Point(11, 25);
            this.AmountNumericUpDown.Name = "AmountNumericUpDown";
            this.AmountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.AmountNumericUpDown.TabIndex = 0;
            this.AmountNumericUpDown.Tag = "";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(138, 65);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker.TabIndex = 1;
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(12, 171);
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(318, 102);
            this.CommentTextBox.TabIndex = 2;
            // 
            // ReasonComboBox
            // 
            this.ReasonComboBox.FormattingEnabled = true;
            this.ReasonComboBox.Location = new System.Drawing.Point(11, 144);
            this.ReasonComboBox.Name = "ReasonComboBox";
            this.ReasonComboBox.Size = new System.Drawing.Size(121, 21);
            this.ReasonComboBox.TabIndex = 3;
            // 
            // BrotherComboBox
            // 
            this.BrotherComboBox.FormattingEnabled = true;
            this.BrotherComboBox.Location = new System.Drawing.Point(11, 104);
            this.BrotherComboBox.Name = "BrotherComboBox";
            this.BrotherComboBox.Size = new System.Drawing.Size(121, 21);
            this.BrotherComboBox.TabIndex = 4;
            // 
            // CurrencyComboBox
            // 
            this.CurrencyComboBox.FormattingEnabled = true;
            this.CurrencyComboBox.Location = new System.Drawing.Point(11, 64);
            this.CurrencyComboBox.Name = "CurrencyComboBox";
            this.CurrencyComboBox.Size = new System.Drawing.Size(121, 21);
            this.CurrencyComboBox.TabIndex = 5;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(138, 24);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.TypeComboBox.TabIndex = 6;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(12, 9);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(43, 13);
            this.AmountLabel.TabIndex = 7;
            this.AmountLabel.Text = "Amount";
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Location = new System.Drawing.Point(12, 48);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(49, 13);
            this.CurrencyLabel.TabIndex = 8;
            this.CurrencyLabel.Text = "Currency";
            // 
            // BrotherLabel
            // 
            this.BrotherLabel.AutoSize = true;
            this.BrotherLabel.Location = new System.Drawing.Point(12, 88);
            this.BrotherLabel.Name = "BrotherLabel";
            this.BrotherLabel.Size = new System.Drawing.Size(94, 13);
            this.BrotherLabel.TabIndex = 9;
            this.BrotherLabel.Text = "TransactionOwner";
            // 
            // ReasonLabel
            // 
            this.ReasonLabel.AutoSize = true;
            this.ReasonLabel.Location = new System.Drawing.Point(12, 128);
            this.ReasonLabel.Name = "ReasonLabel";
            this.ReasonLabel.Size = new System.Drawing.Size(44, 13);
            this.ReasonLabel.TabIndex = 10;
            this.ReasonLabel.Text = "Reason";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(137, 9);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(31, 13);
            this.TypeLabel.TabIndex = 11;
            this.TypeLabel.Text = "Type";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(135, 48);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 12;
            this.DateLabel.Text = "Date";
            // 
            // MakeTrButton
            // 
            this.MakeTrButton.Location = new System.Drawing.Point(336, 248);
            this.MakeTrButton.Name = "MakeTrButton";
            this.MakeTrButton.Size = new System.Drawing.Size(118, 23);
            this.MakeTrButton.TabIndex = 13;
            this.MakeTrButton.Text = "Make Transaction";
            this.MakeTrButton.UseVisualStyleBackColor = true;
            this.MakeTrButton.Click += new System.EventHandler(this.MakeTrButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(336, 219);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 14;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // MakeTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 281);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.MakeTrButton);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.ReasonLabel);
            this.Controls.Add(this.BrotherLabel);
            this.Controls.Add(this.CurrencyLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.CurrencyComboBox);
            this.Controls.Add(this.BrotherComboBox);
            this.Controls.Add(this.ReasonComboBox);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.AmountNumericUpDown);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(475, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(475, 320);
            this.Name = "MakeTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MakeTransactionForm";
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown AmountNumericUpDown;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.ComboBox ReasonComboBox;
        private System.Windows.Forms.ComboBox BrotherComboBox;
        private System.Windows.Forms.ComboBox CurrencyComboBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.Label BrotherLabel;
        private System.Windows.Forms.Label ReasonLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button MakeTrButton;
        private System.Windows.Forms.Button ResetButton;
    }
}