using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees_Management_3112
{
    public partial class employeeForm : Form
    {
        public employeeForm()
        {
            InitializeComponent();
        }

        private void clck_in_btn_Click(object sender, EventArgs e)
        {
            EmployeeData empData = new EmployeeData();
            List<EmployeeData> listData = empData.employeesInfo();
            string path = @""; //PLEASE ADD THE FILE PATH TO EMPLOYEE_INFO.TXT FILE 

            for (int i = 0; i < listData.Count; i++)
            {
                if (listData[i].ID.Equals("801356"))
                {
                    listData[i].ClockIn = "true";
                    listData[i].ClockOut = "false";
                }
            }
            List<string> outc = new List<string>();

            foreach (EmployeeData employee in listData)
            {
                outc.Add(employee.ToString());
            }

            File.WriteAllLines(path, outc);
        }

        private void clck_out_btn_Click(object sender, EventArgs e)
        {
            EmployeeData empData = new EmployeeData();
            List<EmployeeData> listData = empData.employeesInfo();
            string path = @""; //PLEASE ADD THE FILE PATH TO EMPLOYEE_INFO.TXT FILE

            for (int i = 0; i < listData.Count; i++)
            {
                if (listData[i].ID.Equals("801356"))
                {
                    listData[i].ClockIn = "false";
                    listData[i].ClockOut = "true";
                }
            }
            List<string> outc = new List<string>();

            foreach (EmployeeData employee in listData)
            {
                outc.Add(employee.ToString());
            }

            File.WriteAllLines(path, outc);
        }

        private void ava_yes_btn_Click(object sender, EventArgs e)
        {
            EmployeeData empData = new EmployeeData();
            List<EmployeeData> listData = empData.employeesInfo();
            string path = @""; //PLEASE ADD THE FILE PATH TO EMPLOYEE_INFO.TXT FILE

            for (int i = 0; i < listData.Count; i++)
            {
                if (listData[i].ID.Equals("801356"))
                {
                    listData[i].AvaToday = "true";
                    
                }
            }
            List<string> outc = new List<string>();

            foreach (EmployeeData employee in listData)
            {
                outc.Add(employee.ToString());
            }

            File.WriteAllLines(path, outc);
        }

        private void ava_no_btn_Click(object sender, EventArgs e)
        {
            EmployeeData empData = new EmployeeData();
            List<EmployeeData> listData = empData.employeesInfo();
            string path = @""; //PLEASE ADD THE FILE PATH TO EMPLOYEE_INFO.TXT FILE

            for (int i = 0; i < listData.Count; i++)
            {
                if (listData[i].ID.Equals("801356"))
                {
                    listData[i].AvaToday = "false";
                }
            }
            List<string> outc = new List<string>();

            foreach (EmployeeData employee in listData)
            {
                outc.Add(employee.ToString());
            }

            File.WriteAllLines(path, outc);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();

            }
        }
    }
}
