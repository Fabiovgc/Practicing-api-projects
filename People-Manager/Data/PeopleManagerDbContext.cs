using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using People_Manager.Models;

namespace People_Manager.Data
{
    public class PeopleManagerDbContext : DbContext
    {
        public PeopleManagerDbContext (DbContextOptions<PeopleManagerDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Person { get; set; } = default!;
    }
}
