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
    public partial class TakeABook : Form
    {
        Library _library;
        public TakeABook(Library library)
        {
            InitializeComponent();
            _library = library;
        }

        private void buttonTakeTake_Click(object sender, EventArgs e)
        {
            string title = textBoxTakeTitle.Text;
            string author = textBoxTakeAuthor.Text;
            string genre = textBoxTakeGenre.Text;
            string year = textBoxTakeYear.Text;

            _library.RemoveBook(title, author, genre, year);

            Close();
        }
    }
}
