using System.Collections.ObjectModel;
using System;
using System.Data.Entity;
using Core.DomainModel.Frontpage;

namespace Infrastructure.Data
{
    public class SampleSeedInitializer : CreateDatabaseIfNotExists<SampleContext>
    {
        protected override void Seed(SampleContext context)
        {
            var samplePostRevision = new PostRevision { 
                Header = "Android first",
                ModifiedOn = DateTime.UtcNow,
                Text = "<div>This is the beautiful Android icon <img src='http://www.bizreport.com/2011/02/03/android-logo-200x200.jpg'/> Representing the far superior mobile OS in the world</div>"
            };

            var samplePost = new Post { 
                Active = true,
                CreatedOn = DateTime.UtcNow, 
                Priority = Priority.High,
                Revisions = new Collection<PostRevision>
                {
                    samplePostRevision
                }
            };            
            
            var anotherSamplePostRevision = new PostRevision { 
                Header = "iPhone last",
                ModifiedOn = DateTime.UtcNow,
                Text = "<div>This is the awful iPhone icon <img src='http://cydiahelp.com/wp-content/uploads/2011/08/Apple-Logo-200x200.png'/> Representing the worst mobile OS in the world</div>"
            };

            var anotherSamplePost = new Post { 
                Active = true,
                CreatedOn = DateTime.UtcNow, 
                Priority = Priority.Locked,
                Revisions = new Collection<PostRevision>
                {
                    anotherSamplePostRevision
                }
            };

            context.Posts.Add(samplePost);
            context.Posts.Add(anotherSamplePost);
            context.SaveChanges();
        }
    }
}