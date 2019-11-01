using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Persons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Persons.Data
{

    public class PersonsContext : DbContext
    {
        private readonly PersonsContext _ctx;
        public PersonsContext(
            DbContextOptions<PersonsContext> options)
            : base(options)
        {

        }

        public IEnumerable<Person> GetAll()
        {
            return _ctx.persons;
        }

        public DbSet<Person> persons { get; set; }
    }
}
