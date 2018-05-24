using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agility.Models
{
    public class Equipes
    {
        public Equipes()
        {
            Participacoes = new HashSet<Inscricoes>();
            ParticipacoesMangas = new HashSet<Resultados>();
        }

        [Key, Column(Order = 1)]
        [ForeignKey("Condutor")]
        public int CondutorFK { get; set; }
        public virtual Condutores Condutor { get; set; }

        [Key, Column(Order = 2)]
        [ForeignKey("Cao")]
        public int CaoFK { get; set; }
        public virtual Caes Cao { get; set; }

        public virtual ICollection<Inscricoes> Participacoes { get; set; }
        public virtual ICollection<Resultados> ParticipacoesMangas { get; set; }
    }
}