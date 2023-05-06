﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Scaffold_Test_User.Models;

namespace Scaffold_Test_User.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{   
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public ICollection<Vehicle>? Reservations { get; set; }
}

