using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AzureRecruit.Models
{
    public class Job
    {
        public int JobID { get; set; }

        public int RecruiterID { get; set; }     
        public virtual Recruiter Recruiter { get; set; }

        [Required()]
        public string Title { get; set; }

        [Required()]
        public string Location { get; set; }

       [DisplayName("Date posted")]
        public string DatePosted { get; set; }
        
        public int Salary { get; set; }

        [Required()]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}