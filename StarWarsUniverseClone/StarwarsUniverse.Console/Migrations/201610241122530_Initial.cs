namespace StarwarsUniverse.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SWMovies",
                c => new
                    {
                        ResourceUri = c.String(nullable: false, maxLength: 128),
                        Title = c.String(),
                        Episode_ID = c.Int(nullable: false),
                        OpeningCrawl = c.String(),
                        Director = c.String(),
                        Producer = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Edited = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ResourceUri);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SWMovies");
        }
    }
}
