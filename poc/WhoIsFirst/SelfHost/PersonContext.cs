using System.Data.Entity;

namespace SelfHost
{
    internal class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        static PersonContext()
        {
            Database.SetInitializer<PersonContext>(new DbInitializer());

            using (PersonContext db = new PersonContext())
            {
                db.Database.Initialize(false);
            }
        }
    }
}
