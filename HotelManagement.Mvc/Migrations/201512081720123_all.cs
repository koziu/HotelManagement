namespace HotelManagement.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class all : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientModels",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Comments = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        PESEL = c.String(nullable: false),
                        IdentityCardNumber = c.String(nullable: false),
                        BrithDay = c.DateTime(nullable: false),
                        BrithPlace = c.String(),
                        CompanyName = c.String(),
                        TaxId = c.String(nullable: false),
                        REGON = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeeModels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Surname = c.String(),
                        Address = c.String(),
                        DeliveriesAddress = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        BrithDay = c.DateTime(nullable: false),
                        BrithPlace = c.String(),
                        TaxId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReservationModels",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Price = c.Double(nullable: false),
                        ReservationState = c.Int(nullable: false),
                        ArriveDate = c.DateTime(nullable: false),
                        DepatureDate = c.DateTime(nullable: false),
                        Client_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClientModels", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.RoomElementModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ElementName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RoomModels",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RoomName = c.String(),
                        RoomState = c.Int(nullable: false),
                        BedSBCOunt = c.Int(nullable: false),
                        BEdDBCount = c.Int(nullable: false),
                        AddtionalBed = c.Int(nullable: false),
                        FixedPricePerRoom = c.Double(nullable: false),
                        FixedPricePerPerson = c.Double(nullable: false),
                        RoomDescription = c.String(),
                        Floor = c.Int(nullable: false),
                        RoomCapacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.UserProfile");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            DropForeignKey("dbo.ReservationModels", "Client_Id", "dbo.ClientModels");
            DropIndex("dbo.ReservationModels", new[] { "Client_Id" });
            DropTable("dbo.RoomModels");
            DropTable("dbo.RoomElementModels");
            DropTable("dbo.ReservationModels");
            DropTable("dbo.EmployeeModels");
            DropTable("dbo.ClientModels");
        }
    }
}
