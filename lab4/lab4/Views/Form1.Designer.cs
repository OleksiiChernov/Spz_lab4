namespace lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeList = new System.Windows.Forms.TreeView();
            this.addBookButton = new System.Windows.Forms.Button();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.addPublisherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeList
            // 
            this.treeList.Location = new System.Drawing.Point(12, 81);
            this.treeList.Name = "treeList";
            this.treeList.Size = new System.Drawing.Size(251, 302);
            this.treeList.TabIndex = 0;
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(288, 81);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(132, 23);
            this.addBookButton.TabIndex = 1;
            this.addBookButton.Text = "Add book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.Location = new System.Drawing.Point(288, 110);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(132, 23);
            this.addAuthorButton.TabIndex = 2;
            this.addAuthorButton.Text = "Add author";
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // addPublisherButton
            // 
            this.addPublisherButton.Location = new System.Drawing.Point(288, 139);
            this.addPublisherButton.Name = "addPublisherButton";
            this.addPublisherButton.Size = new System.Drawing.Size(132, 23);
            this.addPublisherButton.TabIndex = 3;
            this.addPublisherButton.Text = "Add publisher";
            this.addPublisherButton.UseVisualStyleBackColor = true;
            this.addPublisherButton.Click += new System.EventHandler(this.addPublisherButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 395);
            this.Controls.Add(this.addPublisherButton);
            this.Controls.Add(this.addAuthorButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.treeList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeList;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button addAuthorButton;
        private System.Windows.Forms.Button addPublisherButton;
    }
}

