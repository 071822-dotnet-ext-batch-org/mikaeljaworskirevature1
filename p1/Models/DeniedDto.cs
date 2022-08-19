using System;
namespace Models
{
    public class DeniedDto
    {
            public DeniedDto(Tickets denied, Managers m)
            {
                this.managerid = m.UserId;
                this.ticketid = denied.RequestId;
                this.deniedstatus = denied.TicketStatus;
            }

            public Guid managerid { get; set; }
            public Guid ticketid { get; set; }
            public int deniedstatus { get; set; }
    }
}
