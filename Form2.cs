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
    public partial class Form2 : Form
    {
        private string logValue;

        public Form2(string login)
        {
            InitializeComponent();
            logValue = login;
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = $"Welcome {logValue}";
        }
    }
}
