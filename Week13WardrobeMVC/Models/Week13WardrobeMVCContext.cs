using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Week13WardrobeMVC.Models
{
    public class Week13WardrobeMVCContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Week13WardrobeMVCContext() : base("name=Week13WardrobeMVCContext")
        {
        }

        public System.Data.Entity.DbSet<Week13WardrobeMVC.Models.Top> Tops { get; set; }

        public System.Data.Entity.DbSet<Week13WardrobeMVC.Models.Bottom> Bottoms { get; set; }

        public System.Data.Entity.DbSet<Week13WardrobeMVC.Models.Accessory> Accessories { get; set; }

        public System.Data.Entity.DbSet<Week13WardrobeMVC.Models.Sho> Shoes { get; set; }
    }
}
