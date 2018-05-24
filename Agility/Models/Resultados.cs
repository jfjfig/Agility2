using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agility.Models
{
    public class Resultados
    {
        [Key, Column(Order = 1)]
        [ForeignKey("Manga")]
        public int MangaFK { get; set; }
        public virtual Mangas Manga { get; set; }

        [Key, Column(Order = 2)]
        public int CondutorFK { get; set; }

        [Key, Column(Order = 3)]
        public int CaoFK { get; set; }


        [ForeignKey("CondutorFK,CaoFK")]
        public virtual Equipes Equipe { get; set; }

        public int? NumSaida { get; private set; }

        public int? Posicaofinal{get;set;}

        public int? Faltas { get; set; }

        public int? Recusas { get; set; }

        public int? ForaPer { get; set; }

        public int? Exesso { get; private set; }

        public int? Qualificacao { get; private set; }

        public int? Pontos { get; set; }

        public float? Tempo { get; set; }
    }
}