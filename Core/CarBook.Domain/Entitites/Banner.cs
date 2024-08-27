using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Core
{
    public class Banner
    {
        public int BannerId { get; set; }
        public  string title { get; set; }
        public string Description { get; set; }
        public string VideDescription { get; set; }
        public string VideoUrl { get; set; }


    }
}
