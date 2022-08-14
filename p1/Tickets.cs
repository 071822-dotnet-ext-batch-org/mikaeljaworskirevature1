using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace p1
{
    public class Tickets
    {
        public Guid TickedId { get; set;}
        public string TicketType { get; set;}
        public DateTime TicketDate { get; set;}
        public float TicketAmount { get; set;}
        public string Notes { get; set;}
        public Guid E_Id { get; set;}
        public Guid M_Id { get; set;}


    }
}