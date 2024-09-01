using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.FeatureCommands
{
    public class RemoveFeatureCommand : IRequest
    {
        public RemoveFeatureCommand(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
