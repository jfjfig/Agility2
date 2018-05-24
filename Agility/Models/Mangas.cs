using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agility.Models
{
    public class Mangas
    {
        Mangas()
        {
            Participantes = new HashSet<Resultados>();
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [ForeignKey("TipoManga")]
        public int Tipo { get; set; }

        public virtual TipoManga TipoManga { set; get; }

        [Required]
        [ForeignKey("Prova")]
        public int ProvaFK { get; set; }

        public virtual Provas Prova { set; get; }

        [Required]
        [ForeignKey("Juizes")]
        public int JuizesManga { get; set; }

        public virtual Juizes Juizes { set; get; }

        [Required]
        public float TempoMax { get; set; }

        [Required]
        public float TempoStandart { get; set; }

        [Required]
        public int NumOstaculos { get; set; }

        public virtual ICollection<Resultados> Participantes { get; set; }
    }
}