namespace StarwarsUniverse.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.SWPlanetSWMovies", newName: "MoviePlanets");
            RenameColumn(table: "dbo.MoviePlanets", name: "SWPlanet_ResourceUri", newName: "SWPlanet_ResourcesUri");
            RenameIndex(table: "dbo.MoviePlanets", name: "IX_SWPlanet_ResourceUri", newName: "IX_SWPlanet_ResourcesUri");
            DropPrimaryKey("dbo.MoviePlanets");
            AddPrimaryKey("dbo.MoviePlanets", new[] { "SWMovie_ResourceUri", "SWPlanet_ResourcesUri" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.MoviePlanets");
            AddPrimaryKey("dbo.MoviePlanets", new[] { "SWPlanet_ResourceUri", "SWMovie_ResourceUri" });
            RenameIndex(table: "dbo.MoviePlanets", name: "IX_SWPlanet_ResourcesUri", newName: "IX_SWPlanet_ResourceUri");
            RenameColumn(table: "dbo.MoviePlanets", name: "SWPlanet_ResourcesUri", newName: "SWPlanet_ResourceUri");
            RenameTable(name: "dbo.MoviePlanets", newName: "SWPlanetSWMovies");
        }
    }
}
