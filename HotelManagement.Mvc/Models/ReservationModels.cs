using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HotelManagement.Mvc.Enums;

namespace HotelManagement.Mvc.Models
{
  [Table("Reservation")]
  public class ReservationModels
  {
    public ReservationModels()
    {
      Events = new HashSet<Event>();
    }
    [Key]
    public Guid Id { get; set; }    
    public Guid ClientId { get; set; }

    
    public virtual ClientModels Client { get; set; }
    public virtual ICollection<Event> Events { get; set; } 
  }
}