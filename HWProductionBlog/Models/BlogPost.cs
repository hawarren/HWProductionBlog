using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HWProductionBlog.Models
{
    using System.ComponentModel.DataAnnotations;

    public class BlogPost
    {
        //new blog post and this sets up data structure to hold all the comments using a hashset
        public BlogPost()
        {
            this.Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy hh:mmtt}", ApplyFormatInEditMode = true)]
        public DateTimeOffset Created { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy hh:mmtt}", ApplyFormatInEditMode = true)]
        public DateTimeOffset Updated { get; set; }

        [AllowHtml]
        public string Title { get; set; }
        public string Slug { get; set; }

        [AllowHtml]
        public string Body { get; set; }
        public string MediaUrl { get; set; }
        public bool Published { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

            }
}