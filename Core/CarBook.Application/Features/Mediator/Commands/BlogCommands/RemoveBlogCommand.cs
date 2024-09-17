using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.BlogCommands
{
    public class RemoveBlogCommand : IRequest
    {
        public RemoveBlogCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
