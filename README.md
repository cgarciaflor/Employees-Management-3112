# Employees Management-3112
By: Cristian Garcia Flores 

This is a Windows Form App made in Visual Studio 2022 for ITCS-3112-051-Dsgn & Imp Object-oriented Sys Fall 2023. 

When you first start the app, you will see a login screen which will accept username and password from the EMPLOYEE_LOGIN.TXT (user: user, password: password) file. 
  When logged in you will be logged in as Aaron Lee (just to keep the system simple).
  While logged in see a few options, clock in, clock out, and available today, clicking each will update Aaron Lee's info which can be see in the supervisor window. 
  To see the updates simply log out and sign in as a supervisor using the button at the bottom left to switch to the supervisor login portal or just open the Employee_Info.txt file. 


If you switch from to Supervisor Login you will need to sign in using the username and password provided by the EMPLOYER_LOGIN.TXT (user: admin, password: password) file.
Once in, you have to option to select the dashboard, add employee, and salary. 

Dashboard: 
This screen allows you to view current employyees and you can see a counter on the top indicating total employees(everyone in the employee_info.txt file), active (so those who are clocked in) and inactive(so those who are clocked out). 

Add Employee: 
Selecting this will bring up a screen which will have multiple text boxes which you can fill out to add a new employee to the text file. 

Salary: 
Selecting this will bring up a screen which requires you to press a cell on the grid and it will autofill all text boxes. 
The only text box you can change is the salary one and clicking update will update the salary on that person.

All Windows have a X button at the top right which will exit the app. 

#IMPORTANT*****

Please Add the Employee_Info.txt file path to the following: 
  Under addEmployees.cs, 
  go to method "add_click" and input the file path to string path: "".

  Under the class EmployeeData.cs, 
  go to the method "employeesInfo" and input the file path to string path: "".

  Under employeeForm.cs, 
  go to methods clck_out_btn. clck_in_btn, ava_yes_btn, and ava_no_btn and input the file path to string path: "".

  Under Salary.cs, 
  go to method update_btn and input the file path to string path: "".


Please add the  EMPLOYEE_LOGIN.TXT file path to the following: 
  under Form1.cs, 
  go to method Form1_Load and input the file path to string path: "".

Please add the  EMPLOYER_LOGIN.TXT file path to the following: 
  Under employer_Login, 
  go to method employer_Login_Load and input the file path to string path: "".
