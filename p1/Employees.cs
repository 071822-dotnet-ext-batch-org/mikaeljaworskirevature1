using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace p1
{
    public class Employees : Users
    {
       //use this class object to define Employees
       //refer to mark's playters in RpsConsoleApp;   
        public Employees (string fname, string lname, string address, 
                        string city, string state, string country)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Country = country;
        }
   

  
    }
}