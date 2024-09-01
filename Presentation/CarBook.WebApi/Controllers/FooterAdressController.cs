using CarBook.Application.Features.Mediator.Commands.FooterAddressCommands;
using CarBook.Application.Features.Mediator.Queries.FooterAddressQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FooterAddressController : ControllerBase
    {
        private readonly IMediator _mediator;
        public FooterAddressController(IMediator mediator){
            _mediator = mediator;
        }

        
        [HttpGet]
        public async Task<IActionResult> FooterAddressList(){
            var values = await _mediator.Send(new GetFooterAddressQuery());
            return Ok(values);
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> GetFooterAddress(int id){
            var value = await _mediator.Send(new GetFooterAddressByIdQuery(id));
            return Ok(value);
        }


        // Create Process
        [HttpPost]
        public async   Task<IActionResult> CreateFooterAddress(CreateFooterAddressCommand command){
            await _mediator.Send(command);
            return Ok("Footer   Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFooterAddress(int id){
            await _mediator.Send(new RemoveFooterAddressComand(id));
            return Ok("Footer Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFooterAddress(UpdateFooterAddressCommand command){
            await _mediator.Send(command);
            return Ok("Footer Güncellendi");
        }


    }
}