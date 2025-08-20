using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountNamespace
{
    public  class UserAccount
    {
        protected string username;
        protected string password;
        private string fullName;
        protected string department;

        public UserAccount(string username, string password, string fullName, string department)
        {
            this.username = username;
            this.password = password;
            this.fullName = fullName;
            this.department = department;
        }

        public bool ValidateLogin(string inputUser, string inputPass)
        {
            return username == inputUser && password == inputPass;
        }
        public string GetFullName() => fullName;
        public string GetDepartment() => department;
    }
}
