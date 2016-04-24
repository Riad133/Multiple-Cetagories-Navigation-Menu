using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManuBar.Models
{
    public class CatagoryView
    {
        public string  CategoryName { get; set; }
        public List<string> SubCatagoryList { get; set; } 
    }
}