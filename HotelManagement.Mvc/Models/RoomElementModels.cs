using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Mvc.Models
{
  [Table("RoomElement")]
  public class RoomElementModels
  {
    public int Id { get; set; }

    [Display(Name = "Nazwa")]
    public string ElementName { get; set; }

    public virtual ICollection<RoomModels> Room { get; set; }
  }
}