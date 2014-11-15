using System.Data.Entity;

namespace SelfHost
{
    internal class DbInitializer : DropCreateDatabaseAlways<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            context.Persons.Add(new Person()
            {
                FirstName = "Alexandra",
                LastName = "Popescu"
            });

            context.Persons.Add(new Person()
            {
                FirstName = "Andrei",
                LastName = "Albu"
            });
            
            context.Persons.Add(new Person()
            {
                FirstName = "Simona",
                LastName = "Tecsa"
            });
            
            context.Persons.Add(new Person()
            {
                FirstName = "Ovidiu",
                LastName = "Porumb"
            });

            base.Seed(context);
        }
    }
}
