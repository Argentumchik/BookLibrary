namespace BookLibrary
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if(textBoxFirstName.Text !=  "" && textBoxLastName.Text != "") 
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }
    }
}
