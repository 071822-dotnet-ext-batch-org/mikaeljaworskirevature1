using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Managers : Accounts
    {
        public Override Managers (string IsManager)
        {
            IsManager = "Manager";
        }
    }
}