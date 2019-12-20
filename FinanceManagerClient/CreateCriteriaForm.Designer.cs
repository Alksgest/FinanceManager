namespace FinanceManagerClient
{
    partial class CreateCriteriaForm
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
            this.AmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DateFromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ReasonComboBox = new System.Windows.Forms.ComboBox();
            this.TransactionOwnerComboBox = new System.Windows.Forms.ComboBox();
            this.CurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.BrotherLabel = new System.Windows.Forms.Label();
            this.ReasonLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.DateFromLabel = new System.Windows.Forms.Label();
            this.CreateCriteriaButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DateToLabel = new System.Windows.Forms.Label();
            this.DateToTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // AmountNumericUpDown
            // 
            this.AmountNumericUpDown.Location = new System.Drawing.Point(10, 65);
            this.AmountNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.AmountNumericUpDown.Name = "AmountNumericUpDown";
            this.AmountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.AmountNumericUpDown.TabIndex = 0;
            this.AmountNumericUpDown.Tag = "";
            // 
            // DateFromTimePicker
            // 
            this.DateFromTimePicker.Location = new System.Drawing.Point(158, 65);
            this.DateFromTimePicker.Name = "DateFromTimePicker";
            this.DateFromTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateFromTimePicker.TabIndex = 1;
            // 
            // ReasonComboBox
            // 
            this.ReasonComboBox.FormattingEnabled = true;
            this.ReasonComboBox.Location = new System.Drawing.Point(154, 144);
            this.ReasonComboBox.Name = "ReasonComboBox";
            this.ReasonComboBox.Size = new System.Drawing.Size(121, 21);
            this.ReasonComboBox.TabIndex = 3;
            // 
            // TransactionOwnerComboBox
            // 
            this.TransactionOwnerComboBox.FormattingEnabled = true;
            this.TransactionOwnerComboBox.Location = new System.Drawing.Point(10, 144);
            this.TransactionOwnerComboBox.Name = "TransactionOwnerComboBox";
            this.TransactionOwnerComboBox.Size = new System.Drawing.Size(121, 21);
            this.TransactionOwnerComboBox.TabIndex = 4;
            // 
            // CurrencyComboBox
            // 
            this.CurrencyComboBox.FormattingEnabled = true;
            this.CurrencyComboBox.Location = new System.Drawing.Point(10, 104);
            this.CurrencyComboBox.Name = "CurrencyComboBox";
            this.CurrencyComboBox.Size = new System.Drawing.Size(121, 21);
            this.CurrencyComboBox.TabIndex = 5;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(158, 24);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.TypeComboBox.TabIndex = 6;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(7, 49);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(43, 13);
            this.AmountLabel.TabIndex = 7;
            this.AmountLabel.Text = "Amount";
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Location = new System.Drawing.Point(7, 89);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(49, 13);
            this.CurrencyLabel.TabIndex = 8;
            this.CurrencyLabel.Text = "Currency";
            // 
            // BrotherLabel
            // 
            this.BrotherLabel.AutoSize = true;
            this.BrotherLabel.Location = new System.Drawing.Point(7, 128);
            this.BrotherLabel.Name = "BrotherLabel";
            this.BrotherLabel.Size = new System.Drawing.Size(94, 13);
            this.BrotherLabel.TabIndex = 9;
            this.BrotherLabel.Text = "TransactionOwner";
            // 
            // ReasonLabel
            // 
            this.ReasonLabel.AutoSize = true;
            this.ReasonLabel.Location = new System.Drawing.Point(155, 128);
            this.ReasonLabel.Name = "ReasonLabel";
            this.ReasonLabel.Size = new System.Drawing.Size(44, 13);
            this.ReasonLabel.TabIndex = 10;
            this.ReasonLabel.Text = "Reason";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(154, 8);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(31, 13);
            this.TypeLabel.TabIndex = 11;
            this.TypeLabel.Text = "Type";
            // 
            // DateFromLabel
            // 
            this.DateFromLabel.AutoSize = true;
            this.DateFromLabel.Location = new System.Drawing.Point(155, 48);
            this.DateFromLabel.Name = "DateFromLabel";
            this.DateFromLabel.Size = new System.Drawing.Size(56, 13);
            this.DateFromLabel.TabIndex = 12;
            this.DateFromLabel.Text = "Date From";
            // 
            // CreateCriteriaButton
            // 
            this.CreateCriteriaButton.Location = new System.Drawing.Point(312, 142);
            this.CreateCriteriaButton.Name = "CreateCriteriaButton";
            this.CreateCriteriaButton.Size = new System.Drawing.Size(118, 23);
            this.CreateCriteriaButton.TabIndex = 13;
            this.CreateCriteriaButton.Text = "Create Criteria";
            this.CreateCriteriaButton.UseVisualStyleBackColor = true;
            this.CreateCriteriaButton.Click += new System.EventHandler(this.OnCreateCriteriaButtonClick);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(10, 26);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 15;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(7, 10);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(70, 13);
            this.NameLabel.TabIndex = 16;
            this.NameLabel.Text = "Criteria Name";
            // 
            // DateToLabel
            // 
            this.DateToLabel.AutoSize = true;
            this.DateToLabel.Location = new System.Drawing.Point(155, 89);
            this.DateToLabel.Name = "DateToLabel";
            this.DateToLabel.Size = new System.Drawing.Size(30, 13);
            this.DateToLabel.TabIndex = 18;
            this.DateToLabel.Text = "Date";
            // 
            // DateToTimePicker
            // 
            this.DateToTimePicker.Location = new System.Drawing.Point(156, 105);
            this.DateToTimePicker.Name = "DateToTimePicker";
            this.DateToTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateToTimePicker.TabIndex = 17;
            // 
            // CreateCriteriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 171);
            this.Controls.Add(this.DateToLabel);
            this.Controls.Add(this.DateToTimePicker);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CreateCriteriaButton);
            this.Controls.Add(this.DateFromLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.ReasonLabel);
            this.Controls.Add(this.BrotherLabel);
            this.Controls.Add(this.CurrencyLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.CurrencyComboBox);
            this.Controls.Add(this.TransactionOwnerComboBox);
            this.Controls.Add(this.ReasonComboBox);
            this.Controls.Add(this.DateFromTimePicker);
            this.Controls.Add(this.AmountNumericUpDown);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(475, 210);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(475, 210);
            this.Name = "CreateCriteriaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MakeTransactionForm";
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown AmountNumericUpDown;
        private System.Windows.Forms.DateTimePicker DateFromTimePicker;
        private System.Windows.Forms.ComboBox ReasonComboBox;
        private System.Windows.Forms.ComboBox TransactionOwnerComboBox;
        private System.Windows.Forms.ComboBox CurrencyComboBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.Label BrotherLabel;
        private System.Windows.Forms.Label ReasonLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label DateFromLabel;
        private System.Windows.Forms.Button CreateCriteriaButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label DateToLabel;
        private System.Windows.Forms.DateTimePicker DateToTimePicker;
    }
}