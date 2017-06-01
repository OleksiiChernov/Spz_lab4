using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab4.Controllers;
using lab4.Models;

namespace lab4.Views
{
    public enum OpenMode
    {
        Add,
        Update,
        Delete
    }

    public partial class BookForm : Form
    {
        public OpenMode OpenMode;
        private int _bookId = -1;
        public Action action = null;
        public BookForm()
        {
            _bookId = -1;
            action = null;
            InitializeComponent();
            FormClosing += (sender, args) =>
            {
                action?.Invoke();
            };
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            deleteButton.Enabled = OpenMode == OpenMode.Update;
        }

        public void FillData(Book book)
        {
            if (null == book)
            {
                return;
            }
            titleField.Text = book.Title;
            authorField.Text = book.Author;
            publisherField.Text = book.Publisher;
            yearField.Text = book.Year.ToString();
            _bookId = book.Id;
            OpenMode = OpenMode.Update;
        }

        private void publisherLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (OpenMode == OpenMode.Update)
            {
                DataBrowser.Books.Update(new Book{Id = _bookId, Title = titleField.Text, Author = authorField.Text, Publisher = publisherField.Text, Year = Convert.ToInt32(yearField.Text)});
            }
            else
            {
                DataBrowser.Books.Add(new Book { Id = _bookId, Title = titleField.Text, Author = authorField.Text, Publisher = publisherField.Text, Year = Convert.ToInt32(yearField.Text) });
            }
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (OpenMode == OpenMode.Update)
            {
                DataBrowser.Books.Delete(new Book { Id = _bookId, Title = titleField.Text, Author = authorField.Text, Publisher = publisherField.Text, Year = Convert.ToInt32(yearField.Text) });
                Close();
            }
            
        }
    }
}
