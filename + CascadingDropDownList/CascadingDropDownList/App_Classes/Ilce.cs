using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CascadingDropDownList.App_Classes
{
    
    [Table("Ilceler")]
    public class Ilce
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    
        public int SehirId { get; set; }
        [MaxLength(50)]
        public string Adi { get; set; }
        public Sehir Sehri { get; set; }

    }
}