namespace FinanceManagerClient.Controls
{
    partial class MainUserControl
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
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.CurrentYearButton = new System.Windows.Forms.Button();
            this.NextYearButton = new System.Windows.Forms.Button();
            this.TotalButton = new System.Windows.Forms.Button();
            this.TimeRangeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Location = new System.Drawing.Point(3, 3);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(526, 273);
            this.MainPictureBox.TabIndex = 0;
            this.MainPictureBox.TabStop = false;
            // 
            // CurrentYearButton
            // 
            this.CurrentYearButton.Location = new System.Drawing.Point(3, 329);
            this.CurrentYearButton.Name = "CurrentYearButton";
            this.CurrentYearButton.Size = new System.Drawing.Size(100, 23);
            this.CurrentYearButton.TabIndex = 1;
            this.CurrentYearButton.Text = "Programmaticaly changed";
            this.CurrentYearButton.UseVisualStyleBackColor = true;
            this.CurrentYearButton.Click += new System.EventHandler(this.CurrentYearButtonClick);
            // 
            // NextYearButton
            // 
            this.NextYearButton.Location = new System.Drawing.Point(109, 329);
            this.NextYearButton.Name = "NextYearButton";
            this.NextYearButton.Size = new System.Drawing.Size(100, 23);
            this.NextYearButton.TabIndex = 2;
            this.NextYearButton.Text = "Programmaticaly changed";
            this.NextYearButton.UseVisualStyleBackColor = true;
            this.NextYearButton.Click += new System.EventHandler(this.NextYearButtonClick);
            // 
            // TotalButton
            // 
            this.TotalButton.Location = new System.Drawing.Point(215, 329);
            this.TotalButton.Name = "TotalButton";
            this.TotalButton.Size = new System.Drawing.Size(100, 23);
            this.TotalButton.TabIndex = 3;
            this.TotalButton.Text = "Total";
            this.TotalButton.UseVisualStyleBackColor = true;
            this.TotalButton.Click += new System.EventHandler(this.TotalButtonClick);
            // 
            // TimeRangeLabel
            // 
            this.TimeRangeLabel.AutoSize = true;
            this.TimeRangeLabel.Location = new System.Drawing.Point(3, 313);
            this.TimeRangeLabel.Name = "TimeRangeLabel";
            this.TimeRangeLabel.Size = new System.Drawing.Size(68, 13);
            this.TimeRangeLabel.TabIndex = 4;
            this.TimeRangeLabel.Text = "Time Range ";
            // 
            // MainUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TimeRangeLabel);
            this.Controls.Add(this.TotalButton);
            this.Controls.Add(this.NextYearButton);
            this.Controls.Add(this.CurrentYearButton);
            this.Controls.Add(this.MainPictureBox);
            this.MaximumSize = new System.Drawing.Size(529, 355);
            this.MinimumSize = new System.Drawing.Size(529, 355);
            this.Name = "MainUserControl";
            this.Size = new System.Drawing.Size(529, 355);
            this.Load += new System.EventHandler(this.MainUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.Button CurrentYearButton;
        private System.Windows.Forms.Button NextYearButton;
        private System.Windows.Forms.Button TotalButton;
        private System.Windows.Forms.Label TimeRangeLabel;
    }
}
