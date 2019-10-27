using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persons.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persons.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PersonsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PersonsContext>>()))
            {
                // Look for any movies.
                if (context.persons.Any())
                {
                    return;   // DB has been seeded
                }

                context.persons.AddRange(
                    new Person
                    {
                        age = 20,
                        hair_color = "Brown",
                        eye_color = "Green",
                    },
                    new Person
                    {
                        age = 23,
                        hair_color = "Pink",
                        eye_color = "Blue",
                    },

                    new Person
                    {
                        age = 22,
                        hair_color = "Black",
                        eye_color = "Red",
                    },

                    new Person
                    {
                        age = 50,
                        hair_color = "Red",
                        eye_color = "Brown",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
