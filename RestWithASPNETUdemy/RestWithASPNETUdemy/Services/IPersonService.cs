using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(int id);
        Person Update(Person person);
        void Delete(int id);
        List<Person> FindAll();
    }
}
