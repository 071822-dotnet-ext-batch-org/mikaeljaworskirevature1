using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Managers : Accounts
    {
        public Managers(string fname, string lname, string username, string pw, Guid userid, string ismanager)
        {
            Fname = fname;
            Lname = lname;
            Username = username;
            PW = pw;
            UserId = userid;
            IsManager = ismanager;
        }

        //similar to the employee class, only uses inheritance to change the account type to 'Manager'
        public string IsManager {get; set;} = "Manager";

        public static implicit operator Managers(Login l)
        {
            throw new NotImplementedException();
        }
    }
}