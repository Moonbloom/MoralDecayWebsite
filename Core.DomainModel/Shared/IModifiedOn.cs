using System;

namespace Core.DomainModel.Shared
{
    public interface IModifiedOn
    {
        DateTime ModifiedOn { get; set; }
    }
}