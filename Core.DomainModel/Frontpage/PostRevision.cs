using System;
using Core.DomainModel.Shared;

namespace Core.DomainModel.Frontpage
{
    public class PostRevision : IRevision, IIdentifier, IModifiedOn
    {
        public int Id { get; set; }
        public String Header { get; set; }
        public String Text { get; set; }
        public DateTime ModifiedOn { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}