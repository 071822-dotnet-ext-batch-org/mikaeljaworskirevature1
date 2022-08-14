using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace p1
{
    public class Users
    {
        //use this class to make the connection to the database with both managers and employees
        //refer to mark's players in RpsConsole
        public Guid UserId { get; set;} = Guid.NewGuid();
        public string Fname { get; set;}
        public string Lname { get; set;}
        public DateTime Dob { get; set;}
        public string Address { get; set;}
        public int AptSuite { get; set;}
        public string City { get; set;}
        public string State { get; set;}
        public string Country {get; set;}
        
    }
}