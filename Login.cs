namespace BookLibrary
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != "" && textBoxLastName.Text != "")
            {
                string login = textBoxFirstName.Text;

                GeneralPage form2 = new GeneralPage(login);
                form2.Show();
                this.Hide();
            }
        }

    }
}
