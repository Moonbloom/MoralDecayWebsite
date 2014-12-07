using System.Data.Entity;
using Core.DomainModel.Frontpage;

namespace Infrastructure.Data
{
    public class SampleContext : DbContext //IdentityDbContext<ApplicationUser>
    {
        public SampleContext(): base("DefaultConnection")
        {
            Database.SetInitializer<SampleContext>(new SampleSeedInitializer());
        }
        
        public IDbSet<Post> Posts { get; set; }
        public IDbSet<PostRevision> PostRevisions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // use conventions when possible
        }
    }
}
