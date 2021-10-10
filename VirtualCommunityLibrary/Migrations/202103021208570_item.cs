namespace VirtualCommunityLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class item : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemID = c.Int(nullable: false, identity: true),
                        ItemName = c.String(nullable: false, maxLength: 50),
                        ItemLocationID = c.Int(),
                        ItemOwnerID = c.Int(),
                        ItemMaker = c.String(maxLength: 50),
                        ItemProducer = c.String(maxLength: 50),
                        ItemTypeID = c.Int(),
                        ItemHasPhoto = c.Boolean(nullable: false),
                        ItemBorrowStatusID = c.Int(),
                        LibraryLocationID = c.Int(),
                        ItemConditionWhenRegistered = c.String(maxLength: 1000),
                        AdditionalNote = c.String(maxLength: 1000),
                        CreatedOn = c.DateTime(),
                        CreatedBy = c.String(maxLength: 100),
                        ModifiedOn = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ItemID)
                .ForeignKey("dbo.ItemBorrowStatus", t => t.ItemBorrowStatusID)
                .ForeignKey("dbo.ItemLibraryLocations", t => t.LibraryLocationID)
                .ForeignKey("dbo.ItemParties", t => t.ItemOwnerID)
                .ForeignKey("dbo.ItemPartyTypes", t => t.ItemLocationID)
                .ForeignKey("dbo.ItemTypes", t => t.ItemTypeID)
                .Index(t => t.ItemLocationID)
                .Index(t => t.ItemOwnerID)
                .Index(t => t.ItemTypeID)
                .Index(t => t.ItemBorrowStatusID)
                .Index(t => t.LibraryLocationID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "ItemTypeID", "dbo.ItemTypes");
            DropForeignKey("dbo.Items", "ItemLocationID", "dbo.ItemPartyTypes");
            DropForeignKey("dbo.Items", "ItemOwnerID", "dbo.ItemParties");
            DropForeignKey("dbo.Items", "LibraryLocationID", "dbo.ItemLibraryLocations");
            DropForeignKey("dbo.Items", "ItemBorrowStatusID", "dbo.ItemBorrowStatus");
            DropIndex("dbo.Items", new[] { "LibraryLocationID" });
            DropIndex("dbo.Items", new[] { "ItemBorrowStatusID" });
            DropIndex("dbo.Items", new[] { "ItemTypeID" });
            DropIndex("dbo.Items", new[] { "ItemOwnerID" });
            DropIndex("dbo.Items", new[] { "ItemLocationID" });
            DropTable("dbo.Items");
        }
    }
}
