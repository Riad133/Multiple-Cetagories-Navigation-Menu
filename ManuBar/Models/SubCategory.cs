using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ManuBar.Models
{
    public class SubCategory
    {
        public int SubCategoryID { get; set; }
        public string SubCategoryName { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

    }
}