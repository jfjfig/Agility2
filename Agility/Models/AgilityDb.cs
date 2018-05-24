using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Agility.Models
{
    public class AgilityDb:DbContext
    {
        public AgilityDb() : base("AgilityDbConS") { }
       
            public virtual DbSet<Condutores> Condutores { get; set; }
            public virtual DbSet<Caes> Caes { get; set; }
            public virtual DbSet<ContactosCondutor> ContactosCondutor { get; set; }
            public virtual DbSet<Equipes> Equipes { get; set; }
            public virtual DbSet<Escolas> Escolas { get; set; }
            public virtual DbSet<ContactosEscola> ContactosEscola { get; set; }
            public virtual DbSet<Provas> Provas { get; set; }
            public virtual DbSet<Inscricoes> Inscricoes { get; set; }
            public virtual DbSet<Mangas> Mangas { get; set; }
            public virtual DbSet<TipoManga> TipoManga { get; set; }
            public virtual DbSet<Juizes> Juizes { get; set; }
            public virtual DbSet<Resultados> Resultados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}