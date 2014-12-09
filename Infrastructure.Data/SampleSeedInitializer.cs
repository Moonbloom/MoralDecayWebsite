using System.Collections.ObjectModel;
using System;
using System.Data.Entity;
using Core.DomainModel.Frontpage;

namespace Infrastructure.Data
{
    public class SampleSeedInitializer : DropCreateDatabaseAlways<SampleContext>
    {
        protected override void Seed(SampleContext context)
        {
            var samplePostRevision = new PostRevision { 
                Header = "Shaman first",
                ModifiedOn = DateTime.UtcNow,
                Text = "<div>This is the beautiful Shaman icon <img src='/Images/class-icons/class-icon-shaman.jpg'/> Representing the far superior class in WoW</div>"
            };

            var samplePost = new Post { 
                Active = true,
                CreatedOn = DateTime.UtcNow, 
                Priority = Priority.Locked,
                Revisions = new Collection<PostRevision>
                {
                    samplePostRevision
                }
            };            
            
            var anotherSamplePostRevision = new PostRevision { 
                Header = "Rogue second",
                ModifiedOn = DateTime.UtcNow,
                Text = "<div>This is the awful Rogue icon <img src='/Images/class-icons/class-icon-rogue.jpg'/> Representing the weakest class in WoW</div>"
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