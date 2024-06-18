namespace QLTV
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            this.txt_Password.PasswordChar = '*';
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (this.txt_UserName.Text == "Admin")
            {
                if (this.txt_Password.Text == "123")
                {
                    this.form2.Show();
                    MessageBox.Show("Welcome Admin!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password. Please enter again to login!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }
    }
}
