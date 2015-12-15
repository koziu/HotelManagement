using System.Data.Entity;
using HotelManagement.Mvc.Models;

namespace HotelManagement.Mvc.DAL.Context
{
    public class HotelManagementContext : DbContext
    {
        public HotelManagementContext()
            : base("HotelManagement")
        {
        }

        public DbSet<ClientModels> ClientModels { get; set; }
        public DbSet<ReservationModels> ReservationModelses { get; set; }
        public DbSet<RoomElementModels> RoomElementModelses { get; set; }
        public DbSet<RoomModels> RoomModels { get; set; }
        public DbSet<EmployeeModels> EmployeeModels { get; set; }
    }
}