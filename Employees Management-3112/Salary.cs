using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;

namespace Employees_Management_3112
{
    public partial class Salary : UserControl
    {
        public Salary()
        {
            InitializeComponent();
            displayEmpData();
            disableFields();
        }

        public void displayEmpData()
        {
            EmployeeData empData = new EmployeeData();
            List<EmployeeData> listData = empData.employeesInfo();

            dataGridView1.DataSource = listData;

        }

        public void disableFields()
        { 
            emp_id.Enabled = false;
            emp_name_txt.Enabled = false;   
        }

        public void clearFields()
        {
            emp_id.Text = "";
            emp_name_txt.Text = "";
            salary_input.Text = "";
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            EmployeeData empData = new EmployeeData();
            List<EmployeeData> listData = empData.employeesInfo();
            string path = @""; //PLEASE ADD THE FILE PATH TO EMPLOYEE_INFO.TXT FILE


            if (emp_id.Text == ""
                || emp_name_txt.Text == ""
                || salary_input.Text == "")
            {
                MessageBox.Show("Please fill out all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            { 
                for (int i = 0; i < listData.Count; i++)
                {
                    if (listData[i].ID.Equals(emp_id.Text))
                    {
                        listData[i].Salary = salary_input.Text;
                    }
                }
                List<string> outc = new List<string>();

                foreach (EmployeeData employee in listData)
                {
                    outc.Add(employee.ToString());

                }

                File.WriteAllLines(path, outc);

                displayEmpData();
                clearFields();
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                emp_id.Text = row.Cells[0].Value.ToString();
                emp_name_txt.Text = row.Cells[1].Value.ToString();
                salary_input.Text = row.Cells[5].Value.ToString();

            }

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
