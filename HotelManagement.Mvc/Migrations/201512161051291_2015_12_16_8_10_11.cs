namespace HotelManagement.Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2015_12_16_8_10_11 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RoomElement", "Room_Id", "dbo.Room");
            DropForeignKey("dbo.Events", "Room_Id", "dbo.Room");
            DropIndex("dbo.Events", new[] { "Room_Id" });
            DropIndex("dbo.RoomElement", new[] { "Room_Id" });
            DropPrimaryKey("dbo.Employee");
            CreateTable(
                "dbo.RoomElementModelsRoomModels",
                c => new
                    {
                        RoomElementModels_Id = c.Int(nullable: false),
                        RoomModels_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoomElementModels_Id, t.RoomModels_Id })
                .ForeignKey("dbo.RoomElement", t => t.RoomElementModels_Id, cascadeDelete: true)
                .ForeignKey("dbo.Room", t => t.RoomModels_Id, cascadeDelete: true)
                .Index(t => t.RoomElementModels_Id)
                .Index(t => t.RoomModels_Id);
            
            AlterColumn("dbo.Employee", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Events", "Room_Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Room", "RoomName", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Employee", "Id");
            CreateIndex("dbo.Events", "Room_Id");
            AddForeignKey("dbo.Events", "Room_Id", "dbo.Room", "Id", cascadeDelete: true);
            DropColumn("dbo.RoomElement", "Room_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RoomElement", "Room_Id", c => c.Guid());
            DropForeignKey("dbo.Events", "Room_Id", "dbo.Room");
            DropForeignKey("dbo.RoomElementModelsRoomModels", "RoomModels_Id", "dbo.Room");
            DropForeignKey("dbo.RoomElementModelsRoomModels", "RoomElementModels_Id", "dbo.RoomElement");
            DropIndex("dbo.RoomElementModelsRoomModels", new[] { "RoomModels_Id" });
            DropIndex("dbo.RoomElementModelsRoomModels", new[] { "RoomElementModels_Id" });
            DropIndex("dbo.Events", new[] { "Room_Id" });
            DropPrimaryKey("dbo.Employee");
            AlterColumn("dbo.Room", "RoomName", c => c.String());
            AlterColumn("dbo.Events", "Room_Id", c => c.Guid());
            AlterColumn("dbo.Employee", "Id", c => c.String(nullable: false, maxLength: 128));
            DropTable("dbo.RoomElementModelsRoomModels");
            AddPrimaryKey("dbo.Employee", "Id");
            CreateIndex("dbo.RoomElement", "Room_Id");
            CreateIndex("dbo.Events", "Room_Id");
            AddForeignKey("dbo.Events", "Room_Id", "dbo.Room", "Id");
            AddForeignKey("dbo.RoomElement", "Room_Id", "dbo.Room", "Id");
        }
    }
}
