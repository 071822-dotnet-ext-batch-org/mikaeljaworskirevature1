using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Models
{
    public class Employees
    {
       //use this class object to define Employees
        public string Fname { get; set;}
        public string Lname { get; set;}
        public DateTime Dob { get; set;}
        public string Address { get; set;}
        public int AptSuite { get; set;}
        public string City { get; set;}
        public string State { get; set;}
        public string Country {get; set;}
         
        
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