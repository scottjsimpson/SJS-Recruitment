using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzureRecruit.Models
{
    public class Job
    {
        public int JobID { get; set; }

        public int Recruiter { get; set; }
        public virtual Recruiter RecruiterID { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }

        public int Salary { get; set; }

        public string Description { get; set; }
        
    }
}