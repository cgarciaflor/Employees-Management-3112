using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Employees_Management_3112
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
        }

        List<string> users = new List<string>();
        List<string> pass = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @""; //PLEASE ADD THE FILE PATH TO EMPLOYEE_LOGIN.TXT FILE
            StreamReader sr = new StreamReader(path);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]);
                pass.Add(components[1]);
            }

        }
    

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void employeeLogin_Click(object sender, EventArgs e)
        {
            employer_Login employerFrom = new employer_Login();
            employerFrom.Show();
            this.Hide();
        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            enterPassword.PasswordChar = checkPassword.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (users.Contains(enterUser.Text) && pass.Contains(enterPassword.Text) && Array.IndexOf(users.ToArray(), enterUser.Text) == Array.IndexOf(pass.ToArray(), enterPassword.Text))
            {
               
                employeeForm emp = new employeeForm();
                emp.Show();
                this.Hide();
              
            }
            else
            {
                MessageBox.Show("The username and/or password is incorrect");
            }
        }

        private void enterUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
