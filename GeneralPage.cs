﻿using System;
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
    public partial class GeneralPage : Form
    {
        static Library? library = Library.Instance;
        private string logValue;
        Login login1 = new Login();
        public GeneralPage(string login)
        {
            InitializeComponent();
            logValue = login;

        }

        private void GeneralPage_Load(object sender, EventArgs e)
        {   
            labelWelcome.Text = $"Welcome {logValue}";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AddABook>().Any())
            {
                Application.OpenForms.OfType<AddABook>().First().BringToFront();
            }
            else if (Application.OpenForms.OfType<Library>().Any())
            {
                Application.OpenForms.OfType<Library>().First().BringToFront();
            }
            else if (Application.OpenForms.OfType<TakeABook>().Any())
            {
                Application.OpenForms.OfType<TakeABook>().First().BringToFront();
            }
            else
            {
                
                if (library != null)
                {
                    AddABook addABook = new AddABook(library);
                    addABook.Show();
                }
                else
                {
                    MessageBox.Show("Library instance not found!");
                }
            }
        }
        private void GeneralPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<TakeABook>().Any())
            {
                Application.OpenForms.OfType<TakeABook>().First().BringToFront();
            }
            else if (Application.OpenForms.OfType<Library>().Any())
            {
                Application.OpenForms.OfType<Library>().First().BringToFront();
            }
            else if (Application.OpenForms.OfType<AddABook>().Any())
            {
                Application.OpenForms.OfType<AddABook>().First().BringToFront();
            }
            else
            {
                if (library != null)
                {
                    TakeABook take = new TakeABook(library);
                    take.Show();
                }
                else
                {
                    MessageBox.Show("Library instance not found!");
                }
            }
        }

        private void buttonLibrary_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Library>().Any())
            {
                Application.OpenForms.OfType<Library>().First().BringToFront();
            }
            else if (Application.OpenForms.OfType<TakeABook>().Any())
            {
                Application.OpenForms.OfType<TakeABook>().First().BringToFront();
            }
            else if (Application.OpenForms.OfType<AddABook>().Any())
            {
                Application.OpenForms.OfType<AddABook>().First().BringToFront();
            }
            else
            {

                library = null;
                library = Library.Instance;
                library.ShowLibrary();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AddABook>().Any())
            {
                Application.OpenForms.OfType<AddABook>().First().BringToFront();
            }
            else if (Application.OpenForms.OfType<Library>().Any())
            {
                Application.OpenForms.OfType<Library>().First().BringToFront();
            }
            else if (Application.OpenForms.OfType<TakeABook>().Any())
            {
                Application.OpenForms.OfType<TakeABook>().First().BringToFront();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
