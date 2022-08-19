using Models;
using RepoLayer;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BusinessLayer

{
    public class DoBusiness
    {
        private readonly Dbs_Access _repo;
        public DoBusiness()
        {
            this._repo = new Dbs_Access();
        }

        public async Task<List<Tickets>> GetTicketStatusAsync(int status)
        {
            List<Tickets> list = await this._repo.GetTicketStatusAsync(status);
            return list;
        }

        //TODOtakes the types from managers and tickets class objects and returns data from the ticket status app method in the repo
        // allows us to update the ticket status to approved if user is using a manager's account.
        public async Task<ApproveDto> TicketStatusAppAsync(ApproveDto approve)
        {
            if (await this._repo.GetManagerAsync(approve.managerid))
            {
                ApproveDto approvedticket = await this._repo.TicketStatusAppAsync(approve.ticketid, approve.approvedstatus);
                return approvedticket;
            }
            else return null;
        }

        ////takes the types from managers and tickets class objects and returns data from the ticket status app method in the repo
        //// allows us to update the ticket status to denied if user is using a manager's account.

        ////TODO create a new dto with the folowing methods 
        public async Task<DeniedDto> TicketStatusDenAsync(DeniedDto deny)
        {
            if (await this._repo.GetManagerAsync(deny.managerid))
            {
                DeniedDto approvedticket = await this._repo.TicketStatusDenAsync(deny.ticketid, deny.deniedstatus);
                return approvedticket;
            }
            else return null;
        }

        //takes the ticket class object and inputs its types into the method from the db class object
        //allows us to create a new ticket query through this async method.
        public async Task<Tickets> CreateTicketQueryAsync(Tickets ticket)
        {
            Tickets newticket = await this._repo.CreateTicketQueryAsync(ticket);
            return newticket;
        }
    
        //takes the login class object and inputs its types in the the get login method from the dbs class
        //allows us to login to an account with an existing or new account.
        public async Task<Login> GetLoginAsync(Login newentry)
        {
            Login login = await this._repo.GetLoginAsync(newentry);
            return login;
        }

        //takes the employees class object and inputs its types in the the get create new user method from the dbs class
        //allows us to create a new account.
        //public async Task<Employees> NewUserEmpAsync(Employees newentry)
        //{
        //    Employees login = await this._repo.NewUserEmpAsync(newentry);
        //    return login;
        //}

        //takes the managers class object and inputs its types in the the get create new user method from the dbs class
        //allows us to create a new account.
        public async Task<Managers> NewUserAsync(Managers newentry)
        {
            Managers login = await this._repo.NewUserAsync(newentry);
            return login;
        }

    }
}