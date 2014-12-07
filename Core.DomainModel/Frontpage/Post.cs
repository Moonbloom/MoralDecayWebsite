using System;
using System.Collections.Generic;
using Core.DomainModel.Shared;

namespace Core.DomainModel.Frontpage
{
    public class Post : IIdentifier, ICreatedOn
    {
        public Post()
        {
            Revisions = new HashSet<PostRevision>();
        }

        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Active { get; set; }
        public Priority Priority { get; set; }
        public virtual ICollection<PostRevision> Revisions { get; set; }
    }

    public enum Priority
    {
        Low,
        Medium,
        High,
        Locked
    }
}
