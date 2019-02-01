using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.EntityFramework
{
  public  class Initilaizer:CreateDatabaseIfNotExists<CTXContext>
    {
        protected override void Seed(CTXContext context)
        {
            base.Seed(context);
        }
    }
}
