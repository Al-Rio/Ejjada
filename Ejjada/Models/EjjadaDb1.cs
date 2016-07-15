using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ejjada.Models
{
    public class EjjadaDb1 : DbContext
    {
        public EjjadaDb1() : base("name=DefaultConnection1")
        {

        }
        public DbSet<CBenefit> Benefits { get; set; }
        public DbSet<CService> Services { get; set; }
        public DbSet<Why> WhyUs { get; set; }
        public DbSet<ServiceDiscript> Discriptions { get; set; }
        public DbSet<AboutDiscript> Discriptions1 { get; set; }
        //public DbSet<News> NewsL { get; set; }
    }
}