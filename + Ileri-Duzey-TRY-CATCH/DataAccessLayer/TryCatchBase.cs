using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
  public  class TryCatchBase
    {
      

            public void UpperTRYCATCH(Action delege)
            {
                try
                {
                    delege();
                }
                catch (Exception ex)
                {

                    //NLOG ile loglama yapmak
                }

            }
        
    }
}
