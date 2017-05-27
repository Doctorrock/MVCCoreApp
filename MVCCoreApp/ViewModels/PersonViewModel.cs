using MVCCoreApp.Models;

namespace MVCCoreApp.ViewModels
{
    public class PersonViewModel
    {
        public PersonViewModel(Person person)
        {
            Name = person.Name;
        }

        public string Name { get; }

    }
}
