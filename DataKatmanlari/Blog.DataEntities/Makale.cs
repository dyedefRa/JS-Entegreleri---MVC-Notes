using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataEntities
{
    [Table("Makale")]
  public  class Makale
    {
       [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MakaleID { get; set; }
        [Required, StringLength(50)]
        public string Baslik { get; set; }
        [Required, StringLength(250)]
        public string Icerik { get; set; }
    }
}
