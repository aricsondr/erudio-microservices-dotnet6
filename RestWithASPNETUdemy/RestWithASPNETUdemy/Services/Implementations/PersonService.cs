using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonService : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(int id)
        {
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                persons.Add(MockPerson(i));
            }
            return persons;
        }

        public Person FindById(int id)
        {
            return new Person()
            {
                Id = IncrementAndGet(),
                FirstName = "Ari",
                LastName = "Rosario",
                Adress = "Aveiro",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
        private Person MockPerson(int i)
        {
            return new Person()
            {
                Id = IncrementAndGet(),
                FirstName = "FirstName" + i,
                LastName = "LastName" + i,
                Adress = "Adress" + i,
                Gender = "Gender" + i
            };
        }

        private int IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
