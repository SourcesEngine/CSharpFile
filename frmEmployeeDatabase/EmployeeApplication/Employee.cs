using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    public class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string position;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public Employee()
        {
            employeeId = 0;
            firstName = "N/A";
            lastName = "N/A";
            position = "N/A";
        }

        public Employee(int id, string fName, string lName, string pos)
        {
            employeeId = id;
            firstName = fName;
            lastName = lName;
            position = pos;
        }
        public string DisplayEmployeeDetails()
        {
            return $"Employee ID: {employeeId}\nFirst Name: {firstName}\nLast Name: {lastName}\nPosition: {position}";
        }
    }
}
