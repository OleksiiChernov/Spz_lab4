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
    public enum Mode
    {
        Author,
        Publisher
    }
    public partial class AuthorAndPublisherForm : Form
    {
        public OpenMode OpenMode { get; set; }
        public Mode SettterMode { get; set; }
        public Action action = null;
        private int _id = -1;
        public AuthorAndPublisherForm()
        {
            _id = -1;
            action = null;
            InitializeComponent();
            FormClosing += (sender, args) => action?.Invoke();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            deleteButton.Enabled = OpenMode == OpenMode.Update;
        }

        public void FillData(Publisher obj)
        {
            if (null == obj)
            {
                return;
            }
            nameField.Text = obj.Name;
            _id = obj.Id;
            OpenMode = OpenMode.Update;
        }

        public void FillData(Author obj)
        {
            if (null == obj)
            {
                return;
            }
            nameField.Text = obj.Name;
            _id = obj.Id;
            OpenMode = OpenMode.Update;
        }

        private void publisherLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (SettterMode == Mode.Author)
            {
                if (OpenMode == OpenMode.Update)
                {
                    DataBrowser.Authors.Update(new Author {Id = _id, Name = nameField.Text});
                }
                else
                {
                    DataBrowser.Authors.Add(new Author {Id = _id, Name = nameField.Text});
                }
            }
            else if (SettterMode == Mode.Publisher)
            {
                if (OpenMode == OpenMode.Update)
                {
                    DataBrowser.Publishers.Update(new Publisher { Id = _id, Name = nameField.Text });
                }
                else
                {
                    DataBrowser.Publishers.Add(new Publisher { Id = _id, Name = nameField.Text });
                }
            }
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (SettterMode == Mode.Author)
            {
                if (OpenMode == OpenMode.Update)
                {
                    DataBrowser.Authors.Delete(new Author { Id = _id, Name = nameField.Text });
                    Close();
                }
            }
            else if (SettterMode == Mode.Publisher)
            {
                if (OpenMode == OpenMode.Update)
                {
                    DataBrowser.Publishers.Delete(new Publisher { Id = _id, Name = nameField.Text });
                    Close();
                }

            }
            
        }
    }
}
