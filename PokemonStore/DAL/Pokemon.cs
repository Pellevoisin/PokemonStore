using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonStore.DAL {
    public class Pokemon {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }

        public Pokemon() {

        }
    }
}