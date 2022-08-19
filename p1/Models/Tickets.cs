using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Tickets
    {
        public Tickets(float ticketamount, string ticketstatus, string notes, int user_fk, Guid requestid)
        {
            TicketAmount = ticketamount;
            TicketStatus = ticketstatus;
            Notes = notes;
            User_Fk = user_fk;
            RequestId = requestid;
        }
        
        //methods that coincide with the db tickets table's attributes.
        public float TicketAmount {get; set;}
        public string TicketStatus { get; set;}
        public string Notes { get; set;}
        public int User_Fk { get; set;}
        public Guid RequestId { get; set;} = Guid.NewGuid();

    }
}