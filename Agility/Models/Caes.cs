using Foolproof;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Agility.Models
{   
    public class Caes
    {
        public Caes()=> Equipes = new HashSet<Equipes>();

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get;set; }
        
        [Required]
        public String Nome { get; set; }

        public String NomeOficial { get; set; }

        [Required]
        public String Raca { get; set; }

        public Gender? Sexo { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DataNascimento  { get; set; }

        [Required]
        public Grau Grau { get; set; }

        [Required]
        public Size Size { get; set; }

 
        [RequiredIf("Grau", Operator.NotEqualTo, dependentValue: Grau.PreAgility)]
        public String NumeroCaderneta { get; set; }

        [RequiredIf("Grau", Operator.NotEqualTo, dependentValue: Grau.PreAgility)]
        public DateTime? DataLicenca { get; set; }

        [RequiredIf("Grau", Operator.NotEqualTo, dependentValue: Grau.PreAgility)]
        public String NumeroRegisto { get; set; }

        public virtual ICollection<Equipes> Equipes { get; set; }
    }
}