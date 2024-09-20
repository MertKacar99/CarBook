using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.TagCloudCommands
{
    public class RemoveTagCloudCommand : IRequest
    {
        public RemoveTagCloudCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
