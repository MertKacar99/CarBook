using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbook.Domain.Entitites
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Name { get; set; }
        public string CreatedDate { get; set; }
        public string Email { get; set; }


        public string Description { get; set; }

        public string ProfilePictureUrl { get; set; }

        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}
