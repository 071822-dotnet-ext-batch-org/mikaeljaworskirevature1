using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace p1
{
    public class Passwords 
    {
        public Guid PassId { get; set;} = Guid.NewGuid();
        public Guid FkEmp { get; set;} = Guid.NewGuid();
        public Guid FkMan { get; set;} = Guid.NewGuid();

        
    }
}