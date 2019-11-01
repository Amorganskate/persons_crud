using Persons.Models;

namespace Persons.Interfaces
{
    public interface IPersons
    {
        IEnumerable<Person> getAll();
    }
}
