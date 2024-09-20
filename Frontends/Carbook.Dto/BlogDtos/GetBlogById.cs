using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbook.Dto.BlogDtos
{
    public class GetBlogById
    {
        public int blogID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryID { get; set; }
         
        public string Description { get; set; }
         
    }
}
