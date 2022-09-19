using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Transparent_Form
{
    public partial class LoginForm : Form
    {
        StudentClass student = new StudentClass();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_usrname.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Need login data", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string uname = textBox_usrname.Text;
                string pass = textBox_password.Text;
                DataTable table = student.getList(new MySqlCommand("SELECT * FROM `user` WHERE `username`= '" + uname + "' AND `password`='" + pass + "' AND `role`='admin'"));
                if (table.Rows.Count > 0)
                {

                    MainForm main = new MainForm();
                    this.Hide();
                    main.Show();

                }
                else
                {
                    MessageBox.Show("Your username and password are not exists", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_usrname_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegisterForm userRegister = new UserRegisterForm();
            this.Hide();
            userRegister.Show();
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
