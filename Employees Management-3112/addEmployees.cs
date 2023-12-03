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
    public partial class addEmployees : UserControl
    {
        public addEmployees()
        {
            InitializeComponent();

            //Displays data in text file to grid view 
            displayEmpData(); 
        }

        public void displayEmpData() 
        {
            EmployeeData empData = new EmployeeData();
            List<EmployeeData> listData = empData.employeesInfo();

            dataGridView1.DataSource = listData;

        }

        public void clearFields() 
        {
            employeeID.Text = "";
            first_name.Text = "";
            last_name.Text = "";
            salary.Text = "";
            phone_number.Text = "";
            email.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            string path = @""; //PLEASE ADD THE FILE PATH TO EMPLOYEE_INFO.TXT FILE 
        

            if (employeeID.Text == ""
                || first_name.Text == ""
                || last_name.Text == ""
                || salary.Text == ""
                || phone_number.Text == ""
                || email.Text == "")
            {
                MessageBox.Show("Please fill out all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            {
              EmployeeData emData = new EmployeeData();
              List<EmployeeData> listDatas = emData.employeesInfo();


                

               listDatas.Add(new EmployeeData { ID = employeeID.Text, FirstName = first_name.Text, LastName = last_name.Text, Email = email.Text, Phone = phone_number.Text, Salary = salary.Text, ClockIn = "false", ClockOut = "true", AvaToday = "false"  });
                
                List<string> outc = new List<string>();

                foreach(EmployeeData employee in listDatas)
                {
                    outc.Add(employee.ToString());

                }

                File.WriteAllLines(path, outc);

                displayEmpData();
                clearFields();
                
                
            }
        }
    }
}
