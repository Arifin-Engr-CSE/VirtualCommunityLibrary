namespace VirtualCommunityLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itemparty : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemParties",
                c => new
                    {
                        ItemPartyID = c.Int(nullable: false, identity: true),
                        ItemPartyName = c.String(nullable: false, maxLength: 50),
                        PartyAddress = c.String(maxLength: 200),
                        PartyMobile = c.String(maxLength: 50),
                        PartyNoteIfAny = c.String(maxLength: 1000),
                        CreatedOn = c.DateTime(),
                        CreatedBy = c.String(maxLength: 100),
                        ModifiedOn = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 100),
                        ItemPartyTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemPartyID)
                .ForeignKey("dbo.ItemPartyTypes", t => t.ItemPartyTypeID, cascadeDelete: true)
                .Index(t => t.ItemPartyTypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemParties", "ItemPartyTypeID", "dbo.ItemPartyTypes");
            DropIndex("dbo.ItemParties", new[] { "ItemPartyTypeID" });
            DropTable("dbo.ItemParties");
        }
    }
}
