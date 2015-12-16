using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HotelManagement.Mvc.Enums;

namespace HotelManagement.Mvc.Models
{
  public class Event
  {
    //public Event()
    //{
    //  Reservation = new HashSet<ReservationModels>();
    //}
    [Key]
    public Guid Id { get; set; }

    [Display(Name = "Pokój")]
    [Required(ErrorMessage = "Musisz wybrać pokój")]
    public virtual RoomModels Room { get; set; }

    [Display(Name = "Cena")]
    [Required(ErrorMessage = "Musisz podać cene")]
    public double Price { get; set; }

    [Display(Name = "Status")]
    [Required(ErrorMessage = "Musisz wybrać status")]
    public virtual ReservationStates ReservationState { get; set; }

    [Display(Name = "Data przyjazdu")]
    [Required(ErrorMessage = "Musisz podać datę przyjazu")]
    [DataType(DataType.DateTime)]
    public DateTime ArriveDate { get; set; }

    [Display(Name = "Data wyjazdu")]
    [Required(ErrorMessage = "Musisz podać datę wyjazdu")]
    [DataType(DataType.DateTime)]
    public DateTime DepatureDate { get; set; }

    public virtual ReservationModels Reservation { get; set; }
  }
}