using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace Employees_Management_3112
{
    public class EmployeeData
    {
        List<EmployeeData> employees = new List<EmployeeData>();

        public EmployeeData(string iD, string firstName, string lastName, string email, string phone, string salary, string clckin, string clckout, string avatoday)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Salary = salary;
            ClockIn = clckin;
            ClockOut = clckout;
            AvaToday = avatoday;
        }

        public EmployeeData()
        {
            
        }

        public string ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
        
        public string Phone { get; set; }

        public string Salary { get; set; }

        public string ClockIn { get; set; }
        public string ClockOut { get; set; }

        public string AvaToday { get; set; }


        public override string ToString()
        {
            return ID + " " + FirstName + " " + LastName + " " + Email + " "+ Phone + " " + Salary + " " + ClockIn + " " + ClockOut + " " + AvaToday;
        }
        public List<EmployeeData> employeesInfo()
        {
            string path = @""; //PLEASE ADD THE FILE PATH TO EMPLOYEE_INFO.TXT FILE
            StreamReader sr = new StreamReader(path);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                EmployeeData employee = new EmployeeData(components[0], components[1], components[2], components[3], components[4], components[5], components[6], components[7], components[8]);
                ///employee.ID = components[0];
                ///employee.FirstName = components[1];
                ///employee.LastName = components[2];
                ///employee.Email = components[3];
                ///employee.Phone = components[4];
                ///employee.Salary = components[5];
                ///employee.ClockIn = components[6];
                ///employee.ClockOut = components[7];
                ///employee.AvaTadoay = components[8];


                employees.Add(employee);

            }

            sr.Close();

            return employees;

        }

    }

   

}
