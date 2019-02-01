using Blog.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BusinessLayer
{
   public class Test
    {
        public Test()
        {
            CTXContext ctx = new CTXContext();
            ctx.Database.CreateIfNotExists();
        }
    }
}
