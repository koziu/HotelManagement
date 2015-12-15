using System;
using System.Collections.Generic;
using HotelManagement.Mvc.Enums;

namespace HotelManagement.Mvc.Models
{
  public class ReservationModels
  {
    public Guid Id { get; set; }
    public virtual IEnumerable<RoomModels> Rooms { get; set; }
    public double Price { get; set; }
    public ReservationStates ReservationState { get; set; }
    public DateTime ArriveDate { get; set; }
    public DateTime DepatureDate { get; set; }
    public ClientModels Client { get; set; }
  }
}