using Microsoft.EntityFrameworkCore;

namespace DroneCrud.Models
{
    public class DroneContext:DbContext
    {
        public DroneContext(DbContextOptions<DroneContext>options):base(options)
        {
            
        }

        public DbSet<Drone> Drones { get; set; }
      
    }
}
