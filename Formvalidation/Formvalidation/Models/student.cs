using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Formvalidation.Models
{
    public class student
    {

        [Required]

        public string Name { get; set; }
        public string ID { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Dob { get; set; }
        public string pass { get; set; }

        public string conpass { get; set; }



    }
}