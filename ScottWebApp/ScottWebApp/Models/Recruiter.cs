using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AzureRecruit.Models
{
    public class Recruiter
    {
        public int RecruiterID { get; set; }

        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public int Tel { get; set; }

        public virtual List<Job> Jobs { get; set; }
    }
}