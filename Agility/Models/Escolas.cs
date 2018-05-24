using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agility.Models
{
    public class Escolas
    {
        public Escolas()
        {
            Contactos = new HashSet<ContactosEscola>();
            Membros = new HashSet<Condutores>();
            Provas = new HashSet<Provas>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get;set; }

        [Required]
        public String Nome { get; set; }

        public String Morada { get; set; }

        [Required]
        public String Localidade { get; set; }

        public virtual ICollection<Condutores> Membros { get; set; }
        public virtual ICollection<ContactosEscola> Contactos { get; set; }
        public virtual ICollection<Provas> Provas { get; set; }
    }
}