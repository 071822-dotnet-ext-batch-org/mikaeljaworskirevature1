using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace Models
{
    public class Accounts
    {
        //use this class to make the connection to the database with both managers and employees
        //TODO re-write the accounts class to create methods that create new accounts. call the methods from pw, m, and e.
        //refer to mark's players and Round classes in RpsConsole
        public Guid UserId { get; set;} = Guid.NewGuid();
        
        public Accounts(Employees e1, Passwords p1)
        {
            this.E1 = e1;
            this.P1 = p1;
        }

        public Accounts(Managers m1, Passwords p2)
        {
            this.M1 = m1;
            this.P2 = p2;
        }
        
    
        public Employees E1 {get; set;} = null;
        public Managers M1 {get; set;} = null;
        public Passwords P1 {get; set;} = null;
        public Passwords P2 {get; set;} = null;

    }
}