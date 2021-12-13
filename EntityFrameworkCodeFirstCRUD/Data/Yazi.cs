using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstCRUD.Data
{
    [Table("Yazilar")]
   public class Yazi
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public DateTime Zaman { get; set; } = DateTime.Now;
    }
}
