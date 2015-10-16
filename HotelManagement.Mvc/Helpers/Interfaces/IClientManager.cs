using System;
using HotelManagement.DataAccess.Entities;


namespace HotelManagement.Mvc.Helpers.Interfaces
{
  public interface IClientManager
  {
    ClientModel GetClientById(Guid id);
  }
}
