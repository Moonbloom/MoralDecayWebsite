using System.Collections.ObjectModel;
using System;
using System.Data.Entity;
using Core.DomainModel.Frontpage;

namespace Infrastructure.Data
{
    public class SampleSeedInitializer : DropCreateDatabaseIfModelChanges<SampleContext>
    {
        protected override void Seed(SampleContext context)
        {
            var samplePostRevision = new PostRevision { 
                Header = "First Kill",
                ModifiedOn = DateTime.UtcNow, 
                Text = "YEAH!"};

            var samplePost1 = new Post { 
                Active = true,
                CreatedOn = DateTime.UtcNow, 
                Priority = Priority.Locked,
                Revisions = new Collection<PostRevision>
                {
                    samplePostRevision
                }};

            context.Posts.Add(samplePost1);
            context.SaveChanges();
        }
    }
}
