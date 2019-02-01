using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CascadingDropDownList.App_Classes
{
    [Table("Sehirler")]
    public class Sehir
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Ad { get; set; }

        ICollection<Ilce> Ilceler { get; set; }
    }
}