using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ManuBar.Models
{
    public class EFDBContext: DbContext 
    {

        public EFDBContext() : base("EFDBContext")
        {
            
        }
        
        public DbSet<Category> Category { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }

    }
}