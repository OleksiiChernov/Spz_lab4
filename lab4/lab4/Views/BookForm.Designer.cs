namespace lab4.Views
{
    partial class BookForm
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
            this.titleField = new System.Windows.Forms.TextBox();
            this.authorField = new System.Windows.Forms.TextBox();
            this.publisherField = new System.Windows.Forms.TextBox();
            this.yearField = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleField
            // 
            this.titleField.Location = new System.Drawing.Point(143, 72);
            this.titleField.Name = "titleField";
            this.titleField.Size = new System.Drawing.Size(100, 20);
            this.titleField.TabIndex = 0;
            // 
            // authorField
            // 
            this.authorField.Location = new System.Drawing.Point(143, 98);
            this.authorField.Name = "authorField";
            this.authorField.Size = new System.Drawing.Size(100, 20);
            this.authorField.TabIndex = 1;
            // 
            // publisherField
            // 
            this.publisherField.Location = new System.Drawing.Point(143, 124);
            this.publisherField.Name = "publisherField";
            this.publisherField.Size = new System.Drawing.Size(100, 20);
            this.publisherField.TabIndex = 2;
            // 
            // yearField
            // 
            this.yearField.Location = new System.Drawing.Point(143, 150);
            this.yearField.Name = "yearField";
            this.yearField.Size = new System.Drawing.Size(100, 20);
            this.yearField.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(59, 75);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Title";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(59, 101);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(38, 13);
            this.authorLabel.TabIndex = 5;
            this.authorLabel.Text = "Author";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(59, 127);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(50, 13);
            this.publisherLabel.TabIndex = 6;
            this.publisherLabel.Text = "Publisher";
            this.publisherLabel.Click += new System.EventHandler(this.publisherLabel_Click);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(59, 153);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 13);
            this.yearLabel.TabIndex = 7;
            this.yearLabel.Text = "Year";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(62, 226);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(155, 226);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.yearField);
            this.Controls.Add(this.publisherField);
            this.Controls.Add(this.authorField);
            this.Controls.Add(this.titleField);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleField;
        private System.Windows.Forms.TextBox authorField;
        private System.Windows.Forms.TextBox publisherField;
        private System.Windows.Forms.TextBox yearField;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
    }
}