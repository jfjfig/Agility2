using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agility.Models
{
    public class ContactosEscola
    {
        [Key, Column(Order = 1)]
        [ForeignKey("Escola")]
        public int EscolaFK { get; set; }
        public virtual Escolas Escola { get; set; }

        [Key, Column(Order = 2)]
        public String Contacto { get; set; }

        public String Tipo { get; set; }
    }
}