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
using lab4.Views;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateTreeList();
            //DataBrowser.UpdateBook(new Book {Id = 2 , Author = "Kernigan", Title = "Learn C", Publisher = "MS Press", Year = 2014});
        }

        public void UpdateTreeList()
        {
            if (null == treeList)
            {
                return;
            }

            treeList.Nodes.Clear();

            TreeNode booksNode = new TreeNode("Books");
            var books = DataBrowser.Books.GetAll();
            foreach (var book in books)
            {
                var bookNode = new TreeNode(book.Title);
                bookNode.Nodes.Add("Author - " + book.Author);
                bookNode.Nodes.Add("Publisher - " + book.Publisher);
                bookNode.Nodes.Add("Year - " + book.Year);
                booksNode.Nodes.Add(bookNode);
            }

            TreeNode authorsNode = new TreeNode("Authors");
            var authors = DataBrowser.Authors.GetAll();
            foreach (var author in authors)
            {
                var authorNode = new TreeNode(author.Name);
                authorsNode.Nodes.Add(authorNode);
            }

            TreeNode publishersNode = new TreeNode("Publishers");
            var publishers = DataBrowser.Publishers.GetAll();
            foreach (var pub in publishers)
            {
                var pubNode = new TreeNode(pub.Name);
                publishersNode.Nodes.Add(pubNode);
            }

            TreeNode main = new TreeNode("DB");
            main.Nodes.Add(booksNode);
            main.Nodes.Add(authorsNode);
            main.Nodes.Add(publishersNode);
            treeList.Nodes.Add(main);

            treeList.NodeMouseDoubleClick += TreeListOnNodeMouseDoubleClick;
        }

        private void TreeListOnNodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs treeNodeMouseClickEventArgs)
        {
            if (treeNodeMouseClickEventArgs == null)
            {
                return;
            }
            if (treeNodeMouseClickEventArgs.Node.Parent == null)
            {
                return;
            }

            if (treeNodeMouseClickEventArgs.Node.Parent.Text == "Books")
            {
                BookForm bf = new BookForm(); 
                bf.OpenMode = OpenMode.Update;
                var books = DataBrowser.Books.GetAll();
                if (books == null)
                {
                    return;
                }
                int index = treeNodeMouseClickEventArgs.Node.Parent.Nodes.IndexOf(treeNodeMouseClickEventArgs.Node);

                if (index < 0 || index > books.Count)
                {
                    return;
                }

                bf.FillData(books[index]);
                bf.action = UpdateTreeList;
                bf.Show();
            }
            else if (treeNodeMouseClickEventArgs.Node.Parent.Text == "Authors")
            {
                AuthorAndPublisherForm bf = new AuthorAndPublisherForm();
                bf.OpenMode = OpenMode.Update;
                bf.SettterMode = Mode.Author;
                var authors = DataBrowser.Authors.GetAll();
                if (authors == null)
                {
                    return;
                }
                int index = treeNodeMouseClickEventArgs.Node.Parent.Nodes.IndexOf(treeNodeMouseClickEventArgs.Node);

                if (index < 0 || index > authors.Count)
                {
                    return;
                }

                bf.FillData(authors[index]);
                bf.action = UpdateTreeList;
                bf.Show();
            }
            else if (treeNodeMouseClickEventArgs.Node.Parent.Text == "Publishers")
            {
                AuthorAndPublisherForm bf = new AuthorAndPublisherForm();
                bf.OpenMode = OpenMode.Update;
                bf.SettterMode = Mode.Publisher;
                var publishers = DataBrowser.Publishers.GetAll();
                if (publishers == null)
                {
                    return;
                }
                int index = treeNodeMouseClickEventArgs.Node.Parent.Nodes.IndexOf(treeNodeMouseClickEventArgs.Node);

                if (index < 0 || index > publishers.Count)
                {
                    return;
                }

                bf.FillData(publishers[index]);
                bf.action = UpdateTreeList;
                bf.Show();
            }
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            BookForm bf = new BookForm();
            bf.OpenMode = OpenMode.Add;
            bf.action = UpdateTreeList;
            bf.Show();
        }

        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            AuthorAndPublisherForm bf = new AuthorAndPublisherForm();
            bf.OpenMode = OpenMode.Add;
            bf.SettterMode = Mode.Author;
            bf.action = UpdateTreeList;
            bf.Show();
        }

        private void addPublisherButton_Click(object sender, EventArgs e)
        {
            AuthorAndPublisherForm bf = new AuthorAndPublisherForm();
            bf.OpenMode = OpenMode.Add;
            bf.SettterMode = Mode.Publisher;
            bf.action = UpdateTreeList;
            bf.Show();
        }
    }
}
