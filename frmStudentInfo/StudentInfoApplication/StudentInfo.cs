using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoApplication
{
    
        public class StudentInfo
        {
            private int studentId;
            private string lastname;
            private string firstname;
            public StudentInfo()
            {
                studentId = 0;
                lastname = "";
                firstname = "";
            }
            public StudentInfo(int studentId, string lastname, string firstname)
            {
                this.studentId = studentId;
                this.lastname = lastname;
                this.firstname = firstname;
            }
            public int StudentId
            {
                get { return studentId; }
                set { studentId = value; }
            }
            public string Lastname
            {
                get { return lastname; }
                set { lastname = value; }
            }
            public string Firstname
            {
                get { return firstname; }
                set { firstname = value; }
            }
            public override string ToString()
            {
                return $"{studentId} - {firstname} {lastname}";
            }
        }
    }

