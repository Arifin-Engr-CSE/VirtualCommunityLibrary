namespace VirtualCommunityLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itemlibrarylocation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemLibraryLocations",
                c => new
                    {
                        LibraryLocationID = c.Int(nullable: false, identity: true),
                        LibraryLocation = c.String(nullable: false, maxLength: 50),
                        LibraryLocationAddress = c.String(),
                        CreatedOn = c.DateTime(),
                        CreatedBy = c.String(maxLength: 100),
                        ModifiedOn = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 100),
                        ItemPartyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LibraryLocationID)
                .ForeignKey("dbo.ItemParties", t => t.ItemPartyID, cascadeDelete: true)
                .Index(t => t.ItemPartyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemLibraryLocations", "ItemPartyID", "dbo.ItemParties");
            DropIndex("dbo.ItemLibraryLocations", new[] { "ItemPartyID" });
            DropTable("dbo.ItemLibraryLocations");
        }
    }
}
