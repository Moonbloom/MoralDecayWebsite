using Web.Models;

namespace Web.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Web.Models.ApplicationDbContext";
        }

        protected override void Seed(Web.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Users.AddOrUpdate(
                new ApplicationUser { 
                    MdUser = new MDUser{ InGameName = "Admin" }, 
                    Email = "admin@moral.dk", 
                    PasswordHash = "ACiYR/hF/EC6JFIC/XOgQJinBoASYI/XhUwXKFJhUqSfWCT68l9Ya6dmyZxa+lGsRQ==",
                    SecurityStamp = "7fbcf980-9ae7-44ed-9b34-770741fe7465",
                    UserName = "admin@moral.dk"
                }
            );
            
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
