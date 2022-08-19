using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Employees : Accounts
    {
        //here i use a constructor to have local types that match the attributes in the accounts table on the db.
        public Employees(string fname, string lname, string username, string pw, Guid userid, string ismanager)
        {
            Fname = fname;
            Lname = lname;
            Username = username;
            PW = pw;
            UserId = userid;
            IsManager = ismanager;

        }

        // this adds another type locally through class inheritance and allows me to manipulate the account type.
        // default on the db is set to 'employee'.
        public string IsManager {get; set;}
        
        //a throw arguement to avoid redundancies in db or incorrect input. Truly unlikely to happen though.
        public static implicit operator Employees(Login l)
        {
            throw new NotImplementedException();
        }
    }
}