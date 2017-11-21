using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AuthDeneme.Models
{
    public class Entry
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }

        //Mapping

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }
    }
}