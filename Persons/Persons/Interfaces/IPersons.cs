using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persons.Models;

namespace Persons.Interfaces
{
    public interface IPersons
    {
        IEnumerable<Person> getAll();
    }
}
