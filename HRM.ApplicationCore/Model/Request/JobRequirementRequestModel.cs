using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.ApllicationCore.Model.Request
{
    public class JobRequirementRequestModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "IsActive is required")]
        public bool IsActive { get; set; }
    }
}

