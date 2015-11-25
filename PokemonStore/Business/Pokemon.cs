using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonStore.Business {
    public class Pokemon {

        public int ID { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }

        public Pokemon() {

        }

        public Pokemon(int id, String name, String type) {
            ID = id;
            Name = name;
            Type = type;
        }


        private static IQueryable<Pokemon> BaseQuery(PokemonStore.DAL.PokemonContext context) {
            var query = from p in context.Pokemons

                        select new  Pokemon {
                            ID = p.ID,
                            Name = p.Name,
                            Type = p.Type
                        };
            return query;
        }

        public static IEnumerable<Pokemon> GetAllPokemons() {
            using (var context = new PokemonStore.DAL.PokemonContext()) {
                var query = BaseQuery(context);
                return query.ToList();
            }
        }


    }
}