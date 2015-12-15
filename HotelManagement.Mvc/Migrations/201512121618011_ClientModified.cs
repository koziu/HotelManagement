namespace HotelManagement.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientModified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClientModels", "Street", c => c.String(nullable: false));
            AddColumn("dbo.ClientModels", "City", c => c.String(nullable: false));
            AddColumn("dbo.ClientModels", "PostalCode", c => c.String(nullable: false));
            DropColumn("dbo.ClientModels", "Address");
            DropColumn("dbo.ClientModels", "PESEL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClientModels", "PESEL", c => c.String(nullable: false));
            AddColumn("dbo.ClientModels", "Address", c => c.String(nullable: false));
            DropColumn("dbo.ClientModels", "PostalCode");
            DropColumn("dbo.ClientModels", "City");
            DropColumn("dbo.ClientModels", "Street");
        }
    }
}
