using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PokemonStore.DAL {
    public class PokemonInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PokemonContext> {
        protected override void Seed(PokemonContext context) {
            var pokemons = new List<Pokemon>
            {
            new Pokemon{Name="Louxy",Type="Psy"},
            new Pokemon{Name="Lamantine",Type="Glace"},
            new Pokemon{Name="Magneti",Type="Electrik"}
            };

            pokemons.ForEach(s => context.Pokemons.Add(s));
            context.SaveChanges();

        }
    }
}