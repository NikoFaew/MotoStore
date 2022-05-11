using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MotoStore.Models;

namespace MotoStore.Models
{
    public class MotoContext : DbContext
    {
       public DbSet<Motobike> Motobikes { get; set; }
        public MotoContext() :
      base("DefaultConnection")
        { }
        public DbSet<Purchase> Purchases { get; set; }

    }
}