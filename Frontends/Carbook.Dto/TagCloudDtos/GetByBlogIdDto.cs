using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbook.Dto.TagCloudDtos
{
    public class GetByBlogIdDto
    {
        public int TagCloudID { get; set; }
        public string Title { get; set; }
        public int blogID { get; set; }
    }
}
