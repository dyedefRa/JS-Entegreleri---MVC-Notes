using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataEntities
{
    [Table("Yazar")]
  public  class Yazar
    {[Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int YazarID { get; set; }

        [Required,StringLength(250)]
        public string Adi { get; set; }
        [Required, StringLength(250)]
        public string Soyadi { get; set; }
      
        public int MyProperty { get; set; }
    }
}
