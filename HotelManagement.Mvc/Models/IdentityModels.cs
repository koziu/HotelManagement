﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace HotelManagement.Mvc.Models
{
  public class ApplicationUser : IdentityUser
  {
  }

  public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
  {
    public ApplicationDbContext()
      : base("HotelManagement")
    {
    }
  }
}