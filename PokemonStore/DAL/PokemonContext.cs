using PokemonStore.Models;
using PokemonStore.Business;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PokemonStore.DAL {
    
    public class PokemonContext : DbContext
    {
    
        public PokemonContext() : base("PokemonContext")
        {
            //Disable initializer
            Database.SetInitializer<PokemonContext>(null);
        }
        
        public virtual DbSet<Pokemon> Pokemons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        //    modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
        //}
    }
}
