using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace BusinessLayer
{
    public interface IGetData
    {
        public Employees GetEmployees();
        public Managers GetManagers();
        public Tickets GetTickets();
    }
}