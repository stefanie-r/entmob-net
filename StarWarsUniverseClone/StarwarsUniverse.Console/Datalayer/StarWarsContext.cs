using System.Data.Entity;
using StarwarsUniverse.Model;

namespace StarwarsUniverse.Clone.DataLayer
{
    public class StarWarsContext : DbContext
    {
        public StarWarsContext() : base("StarWarsDB"){
        }
        public DbSet<SWMovie> Movies { get; set; }
        public DbSet<SWPlanet> Planets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SWMovie>()
                .HasMany(t => t.Planets)
                .WithMany(t => t.Films)
                .Map(m =>
            {
                m.ToTable("MoviePlanets");
                m.MapLeftKey("SWMovie_ResourceUri");
                m.MapRightKey("SWPlanet_ResourcesUri");
            });
        }
    }


}