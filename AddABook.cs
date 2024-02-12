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
    public partial class AddABook : Form
    {
        Library _library;
        public AddABook(Library library)
        {
            InitializeComponent();
            _library = library;
        }

        private void buttonAddAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book(textBoxAddTitle.Text, 
                                 textBoxAddAuthor.Text,
                                 textBoxAddGenre.Text,
                                 textBoxAddYear.Text);
            _library.AddBook(book);
            MessageBox.Show("Book added");
            Close();
        }
    }
}
