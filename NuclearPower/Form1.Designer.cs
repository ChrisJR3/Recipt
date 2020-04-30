namespace NuclearPower
{
    partial class Background
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.explanationLabel1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.referanceNumberLabel = new System.Windows.Forms.Label();
            this.referanceNumberTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.linearSearchLabel = new System.Windows.Forms.Label();
            this.binarySearchLabel = new System.Windows.Forms.Label();
            this.binarySearchTextBox = new System.Windows.Forms.TextBox();
            this.linearSearchTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.underlineLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(147, 37);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(243, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Children\'s Classics";
            // 
            // explanationLabel1
            // 
            this.explanationLabel1.AutoSize = true;
            this.explanationLabel1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explanationLabel1.ForeColor = System.Drawing.Color.White;
            this.explanationLabel1.Location = new System.Drawing.Point(63, 84);
            this.explanationLabel1.Name = "explanationLabel1";
            this.explanationLabel1.Size = new System.Drawing.Size(388, 16);
            this.explanationLabel1.TabIndex = 1;
            this.explanationLabel1.Text = "Search for the requested book through it\'s referance number.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "We will complete a linear and binary search for the requested book.";
            // 
            // referanceNumberLabel
            // 
            this.referanceNumberLabel.AutoSize = true;
            this.referanceNumberLabel.Font = new System.Drawing.Font("Mongolian Baiti", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referanceNumberLabel.ForeColor = System.Drawing.Color.White;
            this.referanceNumberLabel.Location = new System.Drawing.Point(39, 166);
            this.referanceNumberLabel.Name = "referanceNumberLabel";
            this.referanceNumberLabel.Size = new System.Drawing.Size(148, 25);
            this.referanceNumberLabel.TabIndex = 3;
            this.referanceNumberLabel.Text = "Referance #:";
            // 
            // referanceNumberTextBox
            // 
            this.referanceNumberTextBox.Location = new System.Drawing.Point(218, 172);
            this.referanceNumberTextBox.Name = "referanceNumberTextBox";
            this.referanceNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.referanceNumberTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(230, 228);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(69, 30);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // linearSearchLabel
            // 
            this.linearSearchLabel.AutoSize = true;
            this.linearSearchLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearSearchLabel.ForeColor = System.Drawing.Color.White;
            this.linearSearchLabel.Location = new System.Drawing.Point(41, 296);
            this.linearSearchLabel.Name = "linearSearchLabel";
            this.linearSearchLabel.Size = new System.Drawing.Size(100, 16);
            this.linearSearchLabel.TabIndex = 6;
            this.linearSearchLabel.Text = "Linear Search:";
            // 
            // binarySearchLabel
            // 
            this.binarySearchLabel.AutoSize = true;
            this.binarySearchLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binarySearchLabel.ForeColor = System.Drawing.Color.White;
            this.binarySearchLabel.Location = new System.Drawing.Point(41, 338);
            this.binarySearchLabel.Name = "binarySearchLabel";
            this.binarySearchLabel.Size = new System.Drawing.Size(102, 16);
            this.binarySearchLabel.TabIndex = 7;
            this.binarySearchLabel.Text = "Binary Search:";
            // 
            // binarySearchTextBox
            // 
            this.binarySearchTextBox.Location = new System.Drawing.Point(199, 334);
            this.binarySearchTextBox.Name = "binarySearchTextBox";
            this.binarySearchTextBox.Size = new System.Drawing.Size(252, 20);
            this.binarySearchTextBox.TabIndex = 8;
            // 
            // linearSearchTextBox
            // 
            this.linearSearchTextBox.Location = new System.Drawing.Point(199, 292);
            this.linearSearchTextBox.Name = "linearSearchTextBox";
            this.linearSearchTextBox.Size = new System.Drawing.Size(252, 20);
            this.linearSearchTextBox.TabIndex = 9;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(314, 393);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(203, 20);
            this.outputTextBox.TabIndex = 10;
            // 
            // underlineLabel
            // 
            this.underlineLabel.AutoSize = true;
            this.underlineLabel.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineLabel.ForeColor = System.Drawing.Color.White;
            this.underlineLabel.Location = new System.Drawing.Point(-6, 338);
            this.underlineLabel.Name = "underlineLabel";
            this.underlineLabel.Size = new System.Drawing.Size(559, 34);
            this.underlineLabel.TabIndex = 11;
            this.underlineLabel.Text = "________________________________";
            // 
            // Background
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(529, 425);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.linearSearchTextBox);
            this.Controls.Add(this.binarySearchTextBox);
            this.Controls.Add(this.binarySearchLabel);
            this.Controls.Add(this.linearSearchLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.referanceNumberTextBox);
            this.Controls.Add(this.referanceNumberLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.explanationLabel1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.underlineLabel);
            this.Name = "Background";
            this.Load += new System.EventHandler(this.Background_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ReactorOneText;
        private System.Windows.Forms.Label Danger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label explanationLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label referanceNumberLabel;
        private System.Windows.Forms.TextBox referanceNumberTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label linearSearchLabel;
        private System.Windows.Forms.Label binarySearchLabel;
        private System.Windows.Forms.TextBox binarySearchTextBox;
        private System.Windows.Forms.TextBox linearSearchTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label underlineLabel;
    }
}

