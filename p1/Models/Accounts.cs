using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Accounts
    {
        public string Fname { get; set;}
        public string Lname { get; set;}
        public string Username { get; set;}
        public int PW { get; set;}
        public Guid UserId { get; set;} = Guid.NewGuid();
        public string IsManager {get; set;}

        public Accounts(Employees e1)
        {
            this.E1 = e1;
        }

        public Accounts(Managers m1)
        {
            this.M1 = m1;
        }
        
    
        public Employees E1 {get; set;} = null;
        public Managers M1 {get; set;} = null;

    }
}