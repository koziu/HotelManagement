using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Http;
using HotelManagement.Mvc.Enums;

namespace HotelManagement.Mvc.Models
{
  [RoutePrefix("Pokoje")]
  [Table("Room")]
  public class RoomModels
  {
    public RoomModels()
    {
      RoomElements = new HashSet<RoomElementModels>();
    }
    [Key]
    public Guid Id { get; set; }

    [Display(Name = "Nazwa")]
    [Required(ErrorMessage = "Musisz podać nazwę")]
    public string RoomName { get; set; }

    [Display(Name = "Dodatki:")]
    public virtual ICollection<RoomElementModels> RoomElements { get; set; }

    [Display(Name = "Status")]
    public RoomStates RoomState { get; set; }

    [Display(Name = "Liczba łóżek SB")]
    [Required(ErrorMessage = "Musisz podać liczbę łóżek SB")]
    public int BedSBCOunt { get; set; }

    [Display(Name = "Liczba łóżek DB")]
    [Required(ErrorMessage = "Musisz podać liczbę łóżek DB")]
    public int BEdDBCount { get; set; }

    [Display(Name = "Liczba łóżek dodatkowych")]
    [Required(ErrorMessage = "Musisz podać liczbę łóżek dodatkowych")]
    public int AddtionalBed { get; set; }

    [Display(Name = "Cena za pokój")]
    [Required(ErrorMessage = "Musisz podać cenę za pokój")]
    public double FixedPricePerRoom { get; set; }

    [Display(Name = "Cena za osobę")]
    public double FixedPricePerPerson { get; set; }

    [Display(Name = "Opis pokoju")]
    [DataType(DataType.MultilineText)]
    public string RoomDescription { get; set; }

    [Display(Name = "Piętro")]
    public int Floor { get; set; }

    [Display(Name = "Wielkość pokoju (kw.)")]
    public int RoomCapacity { get; set; }
  }
}