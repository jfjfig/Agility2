namespace Agility.Migrations
{
    using Agility.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Agility.Models.AgilityDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Agility.Models.AgilityDb context)
        {
            var tipoMangas = new List<TipoManga> {
            new TipoManga() {ID=1,Nome="Grau 1 - Mini - Agility_1"},
            new TipoManga() {ID=2,Nome="Grau 1 - Mini - Agility_2"},
            new TipoManga() {ID=3,Nome="Grau 1 - Midi - Agility_1"},
            new TipoManga() {ID=4,Nome="Grau 1 - Midi - Agility_2"},
            new TipoManga() {ID=5,Nome="Grau 1 - Standard - Agility_1"},
            new TipoManga() {ID=6,Nome="Grau 1 - Standard - Agility_2"},
            new TipoManga() {ID=7,Nome="Grau 2 - Mini - Agility"},
            new TipoManga() {ID=8,Nome="Grau 2 - Mini - Jumping"},
            new TipoManga() {ID=9,Nome="Grau 2 - Midi - Agility"},
            new TipoManga() {ID=10,Nome="Grau 2 - Midi - Jumping"},
            new TipoManga() {ID=11,Nome="Grau 2 - Standard - Agility"},
            new TipoManga() {ID=12,Nome="Grau 2 - Standard - Jumping"},
            new TipoManga() {ID=13,Nome="Grau 3 - Mini - Agility"},
            new TipoManga() {ID=14,Nome="Grau 3 - Mini - Jumping"},
            new TipoManga() {ID=15,Nome="Grau 3 - Midi - Agility"},
            new TipoManga() {ID=16,Nome="Grau 3 - Midi - Jumping"},
            new TipoManga() {ID=17,Nome="Grau 3 - Standard - Agility"},
            new TipoManga() {ID=18,Nome="Grau 3 - Standard - Jumping"},
            new TipoManga() {ID=19,Nome="Pré Agility - Mini - Manga 1"},
            new TipoManga() {ID=20,Nome="Pré Agility - Mini - Manga 2"},
            new TipoManga() {ID=21,Nome="Pré Agility - Midi - Manga 1"},
            new TipoManga() {ID=22,Nome="Pré Agility - Midi - Manga 2"},
            new TipoManga() {ID=23,Nome="Pré Agility - Standard - Manga 1"},
            new TipoManga() {ID=24,Nome="Pré Agility - Standard - Manga 2"},
            new TipoManga() {ID=25,Nome="Veteranos - Mini - Agility"},
            new TipoManga() {ID=26,Nome="Veteranos - Mini - Jumping"},
            new TipoManga() {ID=27,Nome="Veteranos - Midi - Agility"},
            new TipoManga() {ID=28,Nome="Veteranos - Midi - Jumping"},
            new TipoManga() {ID=29,Nome="Veteranos - Standard - Agility"},
            new TipoManga() {ID=30,Nome="Veteranos - Standard - Jumping"},
            new TipoManga() {ID=31,Nome="Prova Seletiva - Mini - Agility"},
            new TipoManga() {ID=32,Nome="Prova Seletiva - Mini - Jumping"},
            new TipoManga() {ID=33,Nome="Prova Seletiva - Midi - Agility"},
            new TipoManga() {ID=34,Nome="Prova Seletiva - Midi - Jumping"},
            new TipoManga() {ID=35,Nome="Prova Seletiva - Standard - Agility"},
            new TipoManga() {ID=36,Nome="Prova Seletiva - Standard - Jumping"},
            new TipoManga() {ID=37,Nome="Infantis - Mini - Agility_1"},
            new TipoManga() {ID=38,Nome="Infantis - Mini - Agility_2"},
            new TipoManga() {ID=39,Nome="Infantis - Midi - Agility_1"},
            new TipoManga() {ID=40,Nome="Infantis - Midi - Agility_2"},
            new TipoManga() {ID=41,Nome="Infantis - Standard - Agility_1"},
            new TipoManga() {ID=42,Nome="Infantis - Standard - Agility_2"}
};
            tipoMangas.ForEach(aa => context.TipoManga.AddOrUpdate(a => a.Nome, aa));
            context.SaveChanges();
        }
    }
}
