using System;

namespace Core.DomainModel
{
    public class Test : IIdentifier, ICreatedOn, IModifiedOn
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
