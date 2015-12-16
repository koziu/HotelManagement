using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Mvc.Models
{
  [Table("Employee")]
  public class EmployeeModels
  {
    [Key]
    public Guid Id { get; set; }

    [Display(Name = "Imię")]
    [Required(ErrorMessage = "Musisz podać imię")]
    public string Name { get; set; }

    [Display(Name = "Nazwisko")]
    [Required(ErrorMessage = "Musisz podać nazwisko")]
    public string Surname { get; set; }

    [Display(Name = "Adres zamieszkania")]
    [Required(ErrorMessage = "Musisz podać adres zamieszkania")]
    public string Address { get; set; }

    [Display(Name = "Adres korespondencji")]
    [Required(ErrorMessage = "Musisz podać adres korespondencji")]
    public string DeliveriesAddress { get; set; }

    [Display(Name = "Adres e-mail")]

    public string Email { get; set; }

    [Display(Name = "Numer telefonu")]
    [Required(ErrorMessage = "Musisz podać numer telefonu")]
    public string PhoneNumber { get; set; }

    [Display(Name = "Data urodzenia")]
    [Required(ErrorMessage = "Musisz podać date urodzenia")]
    public DateTime BrithDay { get; set; }

    [Display(Name = "Miejsce urodzenia")]
    [Required(ErrorMessage = "Musisz podać miejsce urodzenia")]
    public string BrithPlace { get; set; }

    [Display(Name = "PESEL")]
    [Required(ErrorMessage = "Musisz podać PESEL")]
    public string TaxId { get; set; }
  }
}