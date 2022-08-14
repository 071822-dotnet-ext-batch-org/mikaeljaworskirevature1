using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace p1
{
    public class Managers : Users
    {
        public Guid StaffId { get; set;} = Guid.NewGuid();
        
        public Managers(string fname, string lname, string address, 
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