using Microsoft.EntityFrameworkCore;
using System;
using Events.BOL;
namespace Events.DAL
{
    public class EventsDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LNGDURL0000329\SQLSERVER2012;Database=Events;Trusted_Connection=True;Password=Password0;User=sa");
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventCatetogory> EventCatetogories { get; set; }
        public DbSet<ReciepentsUsers> ReciepentsUsers { get; set; }
    }
}
