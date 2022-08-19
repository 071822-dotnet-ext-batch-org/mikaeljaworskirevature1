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

        //takes the types from managers and tickets class objects and returns data from the ticket status app method in the repo
        // allows us to update the ticket status to approved if user is using a manager's account.
        public async Task<Tickets> TicketStatusAppAsync(Tickets approved, Managers manager)
        {
            if (await this._repo.GetManagerAsync(manager.UserId))
            {
            Tickets approvedticket = await this._repo.TicketStatusAppAsync(approved);
            return approvedticket;
            }
            else return null;
        }

        //takes the types from managers and tickets class objects and returns data from the ticket status app method in the repo
        // allows us to update the ticket status to denied if user is using a manager's account.
        public async Task<Tickets> TicketStatusDenAsync(Tickets approved, Managers manager)
        {
            if (await this._repo.GetManagerAsync(manager.UserId))
            {
            Tickets approvedticket = await this._repo.TicketStatusDenAsync(approved);
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

    }
}