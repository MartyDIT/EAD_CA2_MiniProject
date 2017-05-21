using EAD_CA2_MiniProject.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EAD_CA2_MiniProject
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
            : base("SchoolContext")
        {

        }

        public DbSet<EAD_CA2_MiniProject.Model.Student> Students { get; set; }
        public DbSet<EAD_CA2_MiniProject.Model.Standard> Standards { get; set; }

    }
}