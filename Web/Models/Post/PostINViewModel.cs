using System;
using Core.DomainModel.Frontpage;

namespace Web.Models.Post
{
    public class PostInViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Active { get; set; }
        public String Header { get; set; }
        public String Text { get; set; }
        public Priority Priority { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}