using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ActionFilterAttribute.Models
{
    [Table("Logs")]
    public class Logging
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(150,ErrorMessage ="150 karakterden fazla olamaz")] [DisplayName("ActionNAME")]
     
        public string ActionName { get; set; }
        [DisplayName("ControllerNAME")]   [Required]
        public string ContollerName { get; set; }
        public DateTime CreatedTime { get; set; }
        public string Bilgi { get; set; }
    }
}