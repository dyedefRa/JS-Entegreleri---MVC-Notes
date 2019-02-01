using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ActionFilterAttribute.Models
{
    public class CTX:DbContext
    {
        public CTX():base("CTXConStr")
        {

        }
       public  DbSet<Logging> logger { get; set; }
    }
}