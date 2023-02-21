using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.ApllicationCore.Model.Request
{
    public class SubmissionRequestModel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "CandidateId is required")]
        public int CandidateId { get; set; }
        [Required(ErrorMessage = "JobRequredmentId is required")]
        public int JobRequredmentId { get; set; }
        [Required(ErrorMessage = "AppliedOn is required")]
        public DateTime AppliedOn { get; set; }
    }
}
