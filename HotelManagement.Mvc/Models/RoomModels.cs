using System;
using System.Collections.Generic;
using HotelManagement.Mvc.Enums;

namespace HotelManagement.Mvc.Models
{
  public class RoomModels
  {
    public Guid Id { get; set; }
    public string RoomName { get; set; }
    public virtual IEnumerable<RoomElementModels> RoomElements { get; set; }
    public RoomStates RoomState { get; set; }
    public int BedSBCOunt { get; set; }
    public int BEdDBCount { get; set; }
    public int AddtionalBed { get; set; }
    public double FixedPricePerRoom { get; set; }
    public double FixedPricePerPerson { get; set; }
    public string RoomDescription { get; set; }
    public int Floor { get; set; }
    public int RoomCapacity { get; set; }
  }
}