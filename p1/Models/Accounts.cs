using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Accounts
    {
        //these types are instantiated to match the core attributes of the accounts on the db.
        // i chose to have a guid as a user id rather than a the primary key because i wanted to treat it like a "special" identifier
        // in a corporate setting. I kept the primary key as an int just for ease of finding the total employees in the db.
        // Hindsight, would make more sense to have the guid as a primary key and use queries to get employee total instead.
        public string Fname { get; set;}
        public string Lname { get; set;}
        public string Username { get; set;}
        public string PW { get; set;}
        public Guid UserId { get; set;} = Guid.NewGuid();

    }
}