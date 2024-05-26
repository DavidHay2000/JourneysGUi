using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneysGUi
{
    public class JourneyContext: DbContext
    {

        public DbSet<Journey> Journeys { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  //override keyword
        {
            optionsBuilder.UseMySql("Server=localhost;Database=utazasok;Uid=root;Pwd=;", ServerVersion.AutoDetect("Server=localhost;Database=utazasok;Uid=root;Pwd=;")); //mindkép helyen átirni adatbázisnevet
        }



    }
}
