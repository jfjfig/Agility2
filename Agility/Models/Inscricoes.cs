using Foolproof;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agility.Models
{
    public class Inscricoes
    {
        [Key, Column(Order = 1)]
        [ForeignKey("Prova")]
        public int ProvaCondFK { get; set; }
        public virtual Provas Prova { get; set; }

        [Required]
        [Key, Column(Order = 2)]
        public int CondutorFK { get; set; }

        [Required]
        [Key, Column(Order = 3)]
        public int CaoFK { get; set; }

        [RequiredIf("Estado", Operator.NotEqualTo, dependentValue: Estado.Pendente)]
        public int numeroDorcal { get; set; }

        [Required]
        public Estado estado { get; set; }

        [ForeignKey("CondutorFK,CaoFK")]
        public virtual Equipes Equipe { get; set; }
    }
}