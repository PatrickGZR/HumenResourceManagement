using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Id, SubmissionId, CadidateId, InterviewDate, InterviewRound, 
//InterviewTypeId, InterviewStatusId, InterviewerId
namespace HRM.ApplicationCore.Entity
{
    public class Interview
    {
        public int Id { get; set; }
        public int SubmissionId { get; set; }
        public int CandidateId { get; set; }
        public DateTime InterviewDate { get; set; }
        public int InterviewRound { get; set; }
        public int InterviewTypeId { get; set; }
        public int InterviewStatusId { get; set; }
        public int InterviewerId { get; set; }

        //navigational properties
        public Submission Submission { get; set; }
        public Candidate Candidate { get; set; }
        public InterviewType InterviewType { get; set; }
        public InterviewStatus interviewStatus { get; set; }
    }
}
