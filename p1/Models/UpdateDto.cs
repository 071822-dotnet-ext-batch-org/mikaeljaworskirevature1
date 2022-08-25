using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class UpdateDto
    {
        public UpdateDto(Guid ManagerId, Guid RequestId, int ApprovalStatus)
        {
            managerid = ManagerId;;
            approvalStatus = ApprovalStatus;
            requestid = RequestId;
        }

        public Guid managerid { get; set; }
        public Guid requestid { get; set; }
        public int approvalStatus { get; set; }
    }
}

