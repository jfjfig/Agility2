using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agility.Models
{
    public class Condutores
    {
        public Condutores()
        {
        Contactos = new HashSet<ContactosCondutor>();
        Equipes = new HashSet<Equipes>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public String Nome { get; set; }

        public String BI { get; set; }

        [ForeignKey("Escola")]
        public int? EscolaFK { get; set; }
        public virtual Escolas Escola { get; set; }

        public virtual ICollection<ContactosCondutor> Contactos { get; set; }
        public virtual ICollection<Equipes> Equipes { get; set; }

    }
}