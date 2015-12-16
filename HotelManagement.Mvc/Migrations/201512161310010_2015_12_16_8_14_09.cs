namespace HotelManagement.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2015_12_16_8_14_09 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "ReservationId", "dbo.Reservation");
            DropIndex("dbo.Events", new[] { "ReservationId" });

            AlterColumn("dbo.Events", "Reservation_Id", c => c.Guid());

            AddForeignKey("dbo.Events", "Reservation_Id", "dbo.Reservation", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Reservation_Id", "dbo.Reservation");
            DropIndex("dbo.Events", new[] { "Reservation_Id" });
            AlterColumn("dbo.Events", "Reservation_Id", c => c.Guid(nullable: false));
            RenameColumn(table: "dbo.Events", name: "Reservation_Id", newName: "ReservationId");
            CreateIndex("dbo.Events", "ReservationId");
            AddForeignKey("dbo.Events", "ReservationId", "dbo.Reservation", "Id", cascadeDelete: true);
        }
    }
}
