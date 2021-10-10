namespace VirtualCommunityLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itempartytype : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemPartyTypes",
                c => new
                    {
                        ItemPartyTypeID = c.Int(nullable: false, identity: true),
                        PartyTypeName = c.String(nullable: false, maxLength: 50),
                        PartyTypeDescription = c.String(nullable: false, maxLength: 1000),
                        CreatedOn = c.DateTime(),
                        CreatedBy = c.String(maxLength: 100),
                        ModifiedOn = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ItemPartyTypeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ItemPartyTypes");
        }
    }
}
