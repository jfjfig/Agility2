using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agility.Models
{
    public class Provas
    {       
        public Provas()
        {
            Participantes = new HashSet<Inscricoes>();
            Mangas = new HashSet<Mangas>();
        }
    
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public DateTime DataProva { get; set; }

        [Required]
        public Tipo Tipo { get; set; }

        [Required]
        public String Local { get; set; }

        [NotMapped]
        public int NumParticipantes
        {
            get
            {
                return Participantes.Count();
            }
        }
        public virtual ICollection<Inscricoes> Participantes { get; set; }
        public virtual ICollection<Mangas> Mangas { get; set; }

        [ForeignKey("Escola")]
        [Required]
        public int EscolaFK { get; set; }
        public virtual Escolas Escola { get; set; }
    }
}