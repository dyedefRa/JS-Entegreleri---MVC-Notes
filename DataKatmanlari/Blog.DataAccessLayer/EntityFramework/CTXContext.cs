using Blog.DataEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.EntityFramework
{
  public  class CTXContext:DbContext
    {
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Makale> Makaleler { get; set; }
    }
}
