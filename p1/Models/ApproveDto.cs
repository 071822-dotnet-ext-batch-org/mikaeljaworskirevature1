using System;
namespace Models
{
    public class ApproveDto
    {
            public ApproveDto(Tickets approved, Managers m, int status)
        {
            this.managerid = m.UserId;
            this.requestid = approved.RequestId;
            this.approvedstatus = status;
        }

     

        public Guid managerid { get; set; }
        public Guid requestid { get; set; }
        public int approvedstatus { get; set; }
    }
}

