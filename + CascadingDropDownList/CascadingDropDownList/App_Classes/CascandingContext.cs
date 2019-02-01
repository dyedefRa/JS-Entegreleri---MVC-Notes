using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CascadingDropDownList.App_Classes
{
    public class CascandingContext : DbContext
    {
        public CascandingContext() : base("CascandingConStr")
        {

        }
        public DbSet<Ilce> Ilceler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }

    }
}
