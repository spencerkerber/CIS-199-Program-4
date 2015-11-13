namespace Program_4
{
    partial class Form1
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
            this.addbookGroupbox = new System.Windows.Forms.GroupBox();
            this.yourBooksGroupbox = new System.Windows.Forms.GroupBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.callnumberLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.copyrightTextBox = new System.Windows.Forms.TextBox();
            this.callNumberTextBox = new System.Windows.Forms.TextBox();
            this.addBookButton = new System.Windows.Forms.Button();
            this.bookListBox = new System.Windows.Forms.ListBox();
            this.detailsButton = new System.Windows.Forms.Button();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.addbookGroupbox.SuspendLayout();
            this.yourBooksGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addbookGroupbox
            // 
            this.addbookGroupbox.Controls.Add(this.addBookButton);
            this.addbookGroupbox.Controls.Add(this.callNumberTextBox);
            this.addbookGroupbox.Controls.Add(this.copyrightTextBox);
            this.addbookGroupbox.Controls.Add(this.publisherTextBox);
            this.addbookGroupbox.Controls.Add(this.authorTextBox);
            this.addbookGroupbox.Controls.Add(this.titleTextBox);
            this.addbookGroupbox.Controls.Add(this.callnumberLabel);
            this.addbookGroupbox.Controls.Add(this.copyrightLabel);
            this.addbookGroupbox.Controls.Add(this.publisherLabel);
            this.addbookGroupbox.Controls.Add(this.authorLabel);
            this.addbookGroupbox.Controls.Add(this.titleLabel);
            this.addbookGroupbox.Location = new System.Drawing.Point(12, 12);
            this.addbookGroupbox.Name = "addbookGroupbox";
            this.addbookGroupbox.Size = new System.Drawing.Size(256, 196);
            this.addbookGroupbox.TabIndex = 0;
            this.addbookGroupbox.TabStop = false;
            this.addbookGroupbox.Text = "Add Book";
            // 
            // yourBooksGroupbox
            // 
            this.yourBooksGroupbox.Controls.Add(this.returnButton);
            this.yourBooksGroupbox.Controls.Add(this.checkOutButton);
            this.yourBooksGroupbox.Controls.Add(this.detailsButton);
            this.yourBooksGroupbox.Controls.Add(this.bookListBox);
            this.yourBooksGroupbox.Location = new System.Drawing.Point(274, 12);
            this.yourBooksGroupbox.Name = "yourBooksGroupbox";
            this.yourBooksGroupbox.Size = new System.Drawing.Size(254, 196);
            this.yourBooksGroupbox.TabIndex = 1;
            this.yourBooksGroupbox.TabStop = false;
            this.yourBooksGroupbox.Text = "Your Books";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(58, 22);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(47, 48);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author:";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(35, 74);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(53, 13);
            this.publisherLabel.TabIndex = 2;
            this.publisherLabel.Text = "Publisher:";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(34, 100);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(54, 13);
            this.copyrightLabel.TabIndex = 3;
            this.copyrightLabel.Text = "Copyright:";
            // 
            // callnumberLabel
            // 
            this.callnumberLabel.AutoSize = true;
            this.callnumberLabel.Location = new System.Drawing.Point(21, 126);
            this.callnumberLabel.Name = "callnumberLabel";
            this.callnumberLabel.Size = new System.Drawing.Size(67, 13);
            this.callnumberLabel.TabIndex = 4;
            this.callnumberLabel.Text = "Call Number:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(94, 19);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 5;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(94, 45);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(100, 20);
            this.authorTextBox.TabIndex = 6;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(94, 71);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(100, 20);
            this.publisherTextBox.TabIndex = 7;
            // 
            // copyrightTextBox
            // 
            this.copyrightTextBox.Location = new System.Drawing.Point(94, 97);
            this.copyrightTextBox.Name = "copyrightTextBox";
            this.copyrightTextBox.Size = new System.Drawing.Size(100, 20);
            this.copyrightTextBox.TabIndex = 8;
            // 
            // callNumberTextBox
            // 
            this.callNumberTextBox.Location = new System.Drawing.Point(94, 123);
            this.callNumberTextBox.Name = "callNumberTextBox";
            this.callNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.callNumberTextBox.TabIndex = 9;
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(83, 158);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(75, 23);
            this.addBookButton.TabIndex = 10;
            this.addBookButton.Text = "Add Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookListBox
            // 
            this.bookListBox.FormattingEnabled = true;
            this.bookListBox.Location = new System.Drawing.Point(16, 19);
            this.bookListBox.Name = "bookListBox";
            this.bookListBox.Size = new System.Drawing.Size(222, 121);
            this.bookListBox.TabIndex = 0;
            this.bookListBox.SelectedIndexChanged += new System.EventHandler(this.bookListBox_SelectedIndexChanged);
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(6, 158);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(75, 23);
            this.detailsButton.TabIndex = 1;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(87, 158);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(75, 23);
            this.checkOutButton.TabIndex = 2;
            this.checkOutButton.Text = "Check Out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(168, 158);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 220);
            this.Controls.Add(this.yourBooksGroupbox);
            this.Controls.Add(this.addbookGroupbox);
            this.Name = "Form1";
            this.Text = "Program 4";
            this.addbookGroupbox.ResumeLayout(false);
            this.addbookGroupbox.PerformLayout();
            this.yourBooksGroupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addbookGroupbox;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.TextBox callNumberTextBox;
        private System.Windows.Forms.TextBox copyrightTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label callnumberLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox yourBooksGroupbox;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.ListBox bookListBox;
    }
}

