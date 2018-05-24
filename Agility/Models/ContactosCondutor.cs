using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agility.Models
{
    public class ContactosCondutor
    {
        [Key, Column(Order = 1)]
        [ForeignKey("Condutor")]
        public int CondutorFK { get; set; }
        public virtual Condutores Condutor { get; set; }

        [Key, Column(Order = 2)]
        public String Contacto { get; set; }

        public String Tipo { get; set; }
    }
}