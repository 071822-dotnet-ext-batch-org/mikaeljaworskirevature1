using System;
namespace Models
{
    public class ApproveDto
    {
            public ApproveDto(Tickets approved, Managers m)
        {
            this.managerid = m.UserId;
            this.ticketid = approved.RequestId;
            this.approvedstatus = approved.TicketStatus;
        }

        public Guid managerid { get; set; }
        public Guid ticketid { get; set; }
        public int approvedstatus { get; set; }
    }
}

