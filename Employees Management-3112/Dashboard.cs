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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            displayEmpData();
            displayTotal();
            displayTotalActive();
            displayTotalInactive();
        }

        public void displayEmpData()
        {
            EmployeeData empData = new EmployeeData();
            List<EmployeeData> listData = empData.employeesInfo();

            dataGridView1.DataSource = listData;

        }

        public void displayTotal()
        {
            EmployeeData empData = new EmployeeData();
            List<EmployeeData> listData = empData.employeesInfo();
            int count = listData.Count;
            dash_total.Text = count.ToString();
        }

        public void displayTotalActive()
        {
            EmployeeData empData = new EmployeeData();
            List<EmployeeData> listData = empData.employeesInfo();
            int count = 0;
            for (int i = 0; i < listData.Count; i++)
            {
                if (listData[i].ClockIn.Equals("true"))
                {
                    count += 1;
                }
            }
            dash_active.Text = count.ToString();
        }

        public void displayTotalInactive()
        {
            EmployeeData empData = new EmployeeData();
            List<EmployeeData> listData = empData.employeesInfo();
            int count = 0;
            for (int i = 0; i < listData.Count; i++)
            {
                if (listData[i].ClockOut.Equals("true"))
                {
                    count += 1;
                }
            }
            dash_inactive.Text = count.ToString();
        }
    }
}
