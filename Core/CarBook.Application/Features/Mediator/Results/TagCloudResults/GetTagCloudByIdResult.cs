using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.TagCloudResults
{
    public class GetTagCloudByIdResult
    {
        public int TagCloudID { get; set; }
        public string Title { get; set; }
        public int blogID { get; set; }
    }
}
