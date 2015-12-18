using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace HotelManagement.Mvc.Models
{
  public class ClientsReservationModels
  {
    private readonly List<ClientModels> _clients;
    private readonly List<RoomModels> _rooms;

    [Display(Name = "Klient")]
    public Guid SelectedClientId { get; set; }

    [Display(Name = "Pokój")]
    public Guid SelectedRoomId { get; set; }

    public IEnumerable<SelectListItem> Rooms { get; set; }

    public IEnumerable<SelectListItem> Clients { get; set; }

    public Event Event { get; set; }
  }
}