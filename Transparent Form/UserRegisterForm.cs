using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transparent_Form
{
    public partial class UserRegisterForm : Form
    {
        UserClass user = new UserClass();
        public UserRegisterForm()
        {
            InitializeComponent();
        }

        private void UserRegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_login_Click(object sender, EventArgs e)
        {

        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if(textBox_fullName.Text == "" || textBox_UserName.Text == "" || textBox_Password.Text == "" || textBox_ConPassword.Text == "")
            {
                MessageBox.Show("Need register data", "Wrong Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox_Password.Text != textBox_ConPassword.Text)
            {
                MessageBox.Show("Password Not Mathch", "Wrong Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string fullName = textBox_fullName.Text;
                string userName = textBox_UserName.Text;
                string password = textBox_Password.Text;
                string conPassword = textBox_ConPassword.Text;

                bool result = user.insertUser(fullName, userName, password, conPassword);
                if (result)
                {
                    LoginForm login = new LoginForm();
                    this.Hide();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Registration Fail", "Wrong Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
