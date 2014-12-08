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
            var MCPostRevision = new PostRevision
            {
                Header = "Moral Decay - 40man Molten Core - Nice and easy",
                ModifiedOn = DateTime.UtcNow,
                Text = "<img src='/Images/kill-shots/MoralDecayMC40Cleared.jpg'/><br/>We cleared it with 40 Moral Decay people, and it was fun and easy, nothing more to say"
            };

            var MCPost = new Post
            {
                Active = true,
                CreatedOn = DateTime.UtcNow,
                Priority = Priority.Locked,
                Revisions = new Collection<PostRevision>
                {
                    MCPostRevision
                }
            };  

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

            context.Posts.Add(MCPost);
            context.Posts.Add(samplePost);
            context.Posts.Add(anotherSamplePost);
            context.SaveChanges();
        }
    }
}