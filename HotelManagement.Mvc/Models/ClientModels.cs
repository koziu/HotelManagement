using System;
using System.ComponentModel.DataAnnotations;
using HotelManagement.Mvc.Enums;

namespace HotelManagement.Mvc.Models
{
  public class ClientModels
  {
    [Key]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Musisz wprowadzić numer telefonu!")]
    //[RegularExpression(@"([\+]){0,1}([0-9]{2})?[\-\s]?[-]?([0-9]{3})\-?[-\s]?([0-9]{3})[-\s]\-?([0-9]{3})$",
    //  ErrorMessage = "Numer musi być zapisany w formacie 123-123-123")]
    [Display(Name="Numer telefonu")]
    [DataType(DataType.PhoneNumber)]
    public string PhoneNumber { get; set; }

    [Display(Name = "Ulica")]
    [Required(ErrorMessage = "Musisz wprowadzić adres!")]
    public string Street { get; set; }
    
    [Display(Name = "Miasto")]
    [Required(ErrorMessage = "Musisz wprowadzić miejscowość")]
    public string City { get; set; }

    [Display(Name= "Kod pocztowy")]
    [Required(ErrorMessage = "Musisz wprowadzić kod pocztowy")]
    [DataType(DataType.PostalCode)]
    public string PostalCode { get; set; }   

    [Display(Name = "E-mail")]
    [EmailAddress]
    [Required(ErrorMessage = "Musisz wprowadzić adres e-mail!")]
    public string Email { get; set; }

    [Display(Name="Rodzaj klienta")]
    public CommentsKinds Comments { get; set; }

    [Display(Name="Imię")]
    [Required(ErrorMessage = "Musisz podać imię")]
    public string Name { get; set; }

    [Display(Name="Nazwisko")]
    [Required(ErrorMessage = "Musisz podać naziwsko")]
    public string Surname { get; set; }

    [Required(ErrorMessage = "Musisz podać PESEL")]
    public string TaxId { get; set; }

    [Display(Name = "Numer konta bankowego")]
    [DataType(DataType.CreditCard)]
    [Required(ErrorMessage = "Musisz podać numer dowodu osobistego")]
    public string IdentityCardNumber { get; set; }
  
    [Display(Name = "Data urodzenia")]
    [Required(ErrorMessage = "Musisz podać datę urodzenia")]
    [DataType(DataType.Date)]
    public DateTime BrithDay { get; set; }

    [Display(Name = "Miejsce urodzenia")]
    public string BrithPlace { get; set; }

    [Display(Name = "Nazwa firmy")]
    public string CompanyName { get; set; }

    [Display(Name= "Numer REGON")]
    public string REGON { get; set; }
  }
}