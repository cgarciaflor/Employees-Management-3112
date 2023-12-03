using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Employees_Management_3112
{
    public partial class employer_Login : Form
    {
        public employer_Login()
        {
            InitializeComponent();
        }
        List<string> users = new List<string>();
        List<string> pass = new List<string>();
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void employee_login_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(users.Contains(enterUser.Text) && pass.Contains(enterPassword.Text) && Array.IndexOf(users.ToArray(), enterUser.Text) == Array.IndexOf(pass.ToArray(), enterPassword.Text))
            {
                SupervisorForm s1 = new SupervisorForm();
                s1.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("The username and/or password is incorrect");
            }
        }

        private void employer_Login_Load(object sender, EventArgs e)
        {
            string path = @""; //PLEASE ADD THE FILE PATH TO EMPLOYER_LOGIN.TXT FILE
            StreamReader sr = new StreamReader(path);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]);
                pass.Add(components[1]);    
            }

        }

        private void enterUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            enterPassword.PasswordChar = checkPassword.Checked ? '\0' : '*';
        }
    }
}
