using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PokemonStore.Business;

namespace PokemonStore.Models {

    public class PokemonModel {

        public int ID { get; set; }
        public String Type { get; set; }
        public String Name { get; set; }
        public List<Pokemon> ListPokemon { get; set; }

        public PokemonModel() {
            ListPokemon = (List<Pokemon>) PokemonStore.Business.Pokemon.GetAllPokemons();
        }
    }
}