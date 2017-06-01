using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4.Models;

namespace lab4.Controllers
{
    public static class DataBrowser
    {
        private static SQLiteConnection _sqlDbConnection = new SQLiteConnection("Data Source=E:\\projects\\spz_lab4\\books.db;Version=3;");

        public static class Books
        {
            public static List<Book> GetAll()
            {
                List<Book> result = new List<Book>();
                _sqlDbConnection.Open();
                string sql = "select * from books";
                SQLiteCommand command = new SQLiteCommand(sql, _sqlDbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Book { Id = reader.GetInt32(0), Title = reader.GetString(1), Author = reader.GetString(2), Publisher = reader.GetString(3), Year = reader.GetInt32(4) });
                }
                _sqlDbConnection.Close();
                return result;
            }

            public static void Add(Book book)
            {
                if (null == book)
                {
                    return;
                }
                _sqlDbConnection.Open();
                string sql = $"insert into books (title,author, publisher, year) values ('{book.Title}', '{book.Author}', '{book.Publisher}', '{book.Year}')";

                SQLiteCommand command = new SQLiteCommand(sql, _sqlDbConnection);
                command.ExecuteNonQuery();
                _sqlDbConnection.Close();
            }

            public static void Update(Book book)
            {
                if (null == book)
                {
                    return;
                }
                _sqlDbConnection.Open();
                string sql = $"update books set title = '{book.Title}', author = '{book.Author}', publisher = '{book.Publisher}', year = '{book.Year}' where id = {book.Id}";

                SQLiteCommand command = new SQLiteCommand(sql, _sqlDbConnection);
                command.ExecuteNonQuery();
                _sqlDbConnection.Close();
            }

            public static void Delete(Book book)
            {
                if (null == book)
                {
                    return;
                }
                _sqlDbConnection.Open();
                string sql = $"delete from books where id = {book.Id}";

                SQLiteCommand command = new SQLiteCommand(sql, _sqlDbConnection);
                command.ExecuteNonQuery();
                _sqlDbConnection.Close();
            }
        }

        public static class Authors
        {
            public static List<Author> GetAll()
            {
                List<Author> result = new List<Author>();
                _sqlDbConnection.Open();
                string sql = "select * from authors";
                SQLiteCommand command = new SQLiteCommand(sql, _sqlDbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Author {Id = reader.GetInt32(0), Name = reader.GetString(1)});
                }
                _sqlDbConnection.Close();
                return result;
            }

            public static void Add(Author author)
            {
                if (null == author)
                {
                    return;
                }
                _sqlDbConnection.Open();
                string sql = $"insert into authors (name) values ('{author.Name}')";

                SQLiteCommand command = new SQLiteCommand(sql, _sqlDbConnection);
                command.ExecuteNonQuery();
                _sqlDbConnection.Close();
            }

            public static void Update(Author author)
            {
                if (null == author)
                {
                    return;
                }
                _sqlDbConnection.Open();
                string sql = $"update authors set name = '{author.Name}' where id = {author.Id}";

                SQLiteCommand command = new SQLiteCommand(sql, _sqlDbConnection);
                command.ExecuteNonQuery();
                _sqlDbConnection.Close();
            }

            public static void Delete(Author author)
            {
                if (null == author)
                {
                    return;
                }
                _sqlDbConnection.Open();
                string sql = $"delete from authors where id = {author.Id}";

                SQLiteCommand command = new SQLiteCommand(sql, _sqlDbConnection);
                command.ExecuteNonQuery();
                _sqlDbConnection.Close();
            }
        }

        public static class Publishers
        {
            public static List<Publisher> GetAll()
            {
                List<Publisher> result = new List<Publisher>();
                _sqlDbConnection.Open();
                string sql = "select * from publishers";
                SQLiteCommand command = new SQLiteCommand(sql, _sqlDbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Publisher { Id = reader.GetInt32(0), Name = reader.GetString(1) });
                }
                _sqlDbConnection.Close();
                return result;
            }

            public static void Add(Publisher publisher)
            {
                if (null == publisher)
                {
                    return;
                }
                _sqlDbConnection.Open();
                string sql = $"insert into publishers (name) values ('{publisher.Name}')";

                SQLiteCommand command = new SQLiteCommand(sql, _sqlDbConnection);
                command.ExecuteNonQuery();
                _sqlDbConnection.Close();
            }

            public static void Update(Publisher publisher)
            {
                if (null == publisher)
                {
                    return;
                }
                _sqlDbConnection.Open();
                string sql = $"update publishers set name = '{publisher.Name}' where id = {publisher.Id}";

                SQLiteCommand command = new SQLiteCommand(sql, _sqlDbConnection);
                command.ExecuteNonQuery();
                _sqlDbConnection.Close();
            }

            public static void Delete(Publisher publisher)
            {
                if (null == publisher)
                {
                    return;
                }
                _sqlDbConnection.Open();
                string sql = $"delete from publishers where id = {publisher.Id}";

                SQLiteCommand command = new SQLiteCommand(sql, _sqlDbConnection);
                command.ExecuteNonQuery();
                _sqlDbConnection.Close();
            }
        }

    }
}
