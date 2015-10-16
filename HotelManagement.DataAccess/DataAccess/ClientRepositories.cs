using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoExecutor.Core.QueryFactory.Infrastructure;
using HotelManagement.DataAccess.DataAccess.Interfaces;
using HotelManagement.DataAccess.Entities;

namespace HotelManagement.DataAccess.DataAccess
{
  public class ClientRepositories : IClientRepositories
  {
    private readonly IQueryFactory _queryFactory;

    private const string GetClientByIdQuery = @"select name, surname from clientTest where clientId = @clientId";

    public ClientRepositories(IQueryFactory queryFactory)
    {
      _queryFactory = queryFactory;
    }

    public ClientModel GetClientById(Guid clientId)
    {
      ClientModel client;
      using (var query = _queryFactory.CreateQuery())
      {
        client = query.Select<ClientModel>(GetClientByIdQuery, new {clientId = clientId});
      }
      return client;
    }
  }
}
