using Microsoft.EntityFrameworkCore;
using Events.Models;

namespace Events.Repositories
{
    public class EventsDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-J0ROJ34\MSSQLSERVER2017;Database=Events;Trusted_Connection=True;Password=Password0;User=sa");
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCatetogory> EventCatetogories { get; set; }
    }
}
