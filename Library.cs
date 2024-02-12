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
                if (instance == null)
                {
                    instance = new Library();
                }
                return instance;
            }
        }

        List<Book> books = new List<Book>();
        public Library()
        {
            InitializeComponent();
            RefreshGrid();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            RefreshGrid();
            MessageBox.Show("Refresh");
        }

        public void RefreshGrid()
        {
            dataGridViewLibrary.DataSource = null;
            dataGridViewLibrary.DataSource = books;
        }
        private void dataGridViewLibrary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //AddABook addABookForm = new AddABook(this);
            //addABookForm.ShowDialog(); // Показуємо форму модально
        }
    }
}
