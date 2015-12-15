using System;
using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Mvc.Models
{
    public class EmployeeModels
    {
        [Key]
        public string Id { get; set; }

        [Display(Name = "Imię")]
        public string Name { get; set; }

        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }

        [Display(Name = "Adres zamieszkania")]
        public string Address { get; set; }

        [Display(Name = "Adres korespondencji")]
        public string DeliveriesAddress { get; set; }   

        [Display(Name = "Adres e-mail")]
        public string Email { get; set; }

        [Display(Name = "Numer telefonu")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Data urodzenia")]
        public DateTime BrithDay { get; set; }

        [Display(Name = "Miejsce urodzenia")]
        public string BrithPlace { get; set; }

        [Display(Name = "PESEL")]
        public string TaxId { get; set; }
    }
}