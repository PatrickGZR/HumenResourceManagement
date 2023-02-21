using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.ApllicationCore.Model.Response
{
    public class SubmissionResponseModel
    {
        public int id { get; set; }
        public int CandidateId { get; set; }
        public int JobRequredmentId { get; set; }
        public DateTime AppliedOn { get; set; }
    }
}
