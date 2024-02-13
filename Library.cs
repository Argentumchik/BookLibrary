using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibrary
{
    public partial class Library : Form
    {
        private static Library? instance;
        public static Library Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Library();
                }
                return instance;
            }
        }

        static List<Book> books = new List<Book>();
        public Library()
        {
            InitializeComponent();
        }

        public void ShowLibrary()
        {
            dataGridViewLibrary.DataSource = null;
            dataGridViewLibrary.DataSource = books;
            Show();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(string title, string author, string genre, string year)
        {
            Book bookToRemove = null;

            foreach (Book book in books)
            {
                if (book.Title == title && book.Author == author && book.Genre == genre && book.Year == year)
                {
                    bookToRemove = book;
                    break;
                }
            }

            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                MessageBox.Show("Book deleted successfully!");
            }
            else
            {
                MessageBox.Show("Book not found!");
            }
        }

        private void buttonClosed_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
