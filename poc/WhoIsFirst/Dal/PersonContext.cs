using System.Data.Entity;
using Model;

namespace Dal
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        static PersonContext()
        {
            Database.SetInitializer(new DbInitializer());

            using (PersonContext db = new PersonContext())
            {
                db.Database.Initialize(false);
            }
        }

        public PersonContext()
        {
            Initialize();
        }

        private bool isInitialized;

        private void Initialize()
        {
            if (!isInitialized)
            {
                isInitialized = true;

                //OP: Thank you Microsoft for this one. Great job!
                var type = typeof(System.Data.Entity.SqlServerCompact.SqlCeProviderServices);
            }
        }
    }
}
