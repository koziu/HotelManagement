using System;
using HotelManagement.DataAccess.DataAccess.Interfaces;
using HotelManagement.DataAccess.Entities;
using HotelManagement.Mvc.Helpers.Interfaces;


namespace HotelManagement.Mvc.Helpers
{
  public class ClientManager : IClientManager
  {
    private readonly IClientRepositories _clientRepositories;

    public ClientManager(IClientRepositories clientRepositories)
    {
      _clientRepositories = clientRepositories;
    }

    public ClientModel GetClientById(Guid id)
    {
      return _clientRepositories.GetClientById(id); ;
    }
  }
}
