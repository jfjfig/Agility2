using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agility.Models
{
    public class TipoManga
    {   
        public TipoManga()
        {
            Mangas = new HashSet<Mangas>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public String Nome { get; set; }

        public virtual ICollection<Mangas> Mangas { get; set; }
    }
}