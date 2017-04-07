using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HWProductionBlog.Models
{
    public class EmailModel
    {
        [Required, Display(Name = "Name")]
        public string FromName { get; set; }

        [Required, Display(Name = "Email"), EmailAddress]
        public string FromEmail { get; set; }

        [Required]
        public string Body { get; set; }

    }
}