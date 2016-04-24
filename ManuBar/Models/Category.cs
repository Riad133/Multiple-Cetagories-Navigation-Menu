using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManuBar.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Display(Name = "Category")]
        public string CategoryName { get; set; }

    }
}