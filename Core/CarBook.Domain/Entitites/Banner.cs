using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbook.Domain.Core
{
    public class Banner
    {
        public int BannerId { get; set; }
        
        //[Column("Title")]
        public string Title { get; set; }
        public string Description { get; set; }

        //[Column("VideoDescription")]
        public string VideoDescription { get; set; }
        public string VideoUrl { get; set; }


    }
}
