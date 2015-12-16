namespace HotelManagement.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2015_12_16_8_12_04 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "Id", "dbo.Reservation");
            DropIndex("dbo.Events", new[] { "Id" });
            AddColumn("dbo.Events", "ReservationId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Events", "ReservationId");
            AddForeignKey("dbo.Events", "ReservationId", "dbo.Reservation", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "ReservationId", "dbo.Reservation");
            DropIndex("dbo.Events", new[] { "ReservationId" });
            DropColumn("dbo.Events", "ReservationId");
            CreateIndex("dbo.Events", "Id");
            AddForeignKey("dbo.Events", "Id", "dbo.Reservation", "Id");
        }
    }
}
