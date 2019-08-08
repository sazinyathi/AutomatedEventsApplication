using Microsoft.EntityFrameworkCore;
using Events.Models;

namespace Events.Repositories
{
    public class EventsDbContext : DbContext
    {

        public EventsDbContext(DbContextOptions<EventsDbContext> options)
                    : base(options)
        {
            Database.Migrate();
        }


        public DbSet<Event> Events { get; set; }
        public DbSet<EventCatetogory> EventCatetogories { get; set; }
    }
}
