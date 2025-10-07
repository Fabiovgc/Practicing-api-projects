using Events_manager.Models;
using Microsoft.EntityFrameworkCore;

namespace Events_manager.NewFolder
{
    public class EventsDbContext : DbContext
    {

        
        public EventsDbContext(DbContextOptions<DbContext> options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }


        //configuration
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // haskey
            builder.Entity<Event>(o =>
            {
                o.HasKey(e => e.Id);

            });
        }
    }
}
