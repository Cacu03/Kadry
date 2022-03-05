using Kadry.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kadry.ApDbContext
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        
    }
}