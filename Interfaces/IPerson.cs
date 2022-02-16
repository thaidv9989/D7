using D7_ASPMVC.Models;
namespace D7_ASPMVC.Interfaces
{
    public interface IPerson
    {
        public List<PersonModel> GetAll();

        public void Add(PersonModel model);

        public PersonModel Detail(int ID);

        public void Edit(PersonModel model);

        public PersonModel Delete(int ID);
    }
}