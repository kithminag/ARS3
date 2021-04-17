using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;

namespace ARS1.Models
{
    public class ContextCS : DbContext
    {
        public ContextCS() : base("cs")
        {

        }
        public DbSet<AdminLogic> AdminLogins { get; set; }
        public DbSet<UserAccount> UserLogins { get; set; }
        public DbSet<AeroPlaneInfo> PlaneInfo { get; set; }
        public DbSet<FlightBooking> FlightBookings { get; set; }


    }
}
