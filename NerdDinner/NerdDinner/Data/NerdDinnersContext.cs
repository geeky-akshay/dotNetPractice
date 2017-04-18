using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NerdDinner.Models;
using System.Data.Entity;

namespace NerdDinner.Data
{
    public class NerdDinnersContext : DbContext
    {
        public DbSet<Dinner> Dinners { get; set; }
        public DbSet<RSVP> RSVPs { get; set; }

        public NerdDinnersContext() : base("name=NerdDinnerConnectionString")
        {

        }
    }
}