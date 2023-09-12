using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DesafioDotNET.Models;
using DesafioDotNET.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace DesafioDotNET.Controllers
{
    [ApiController]
    [Route("api")]
    public class FileController : ControllerBase
    {
        private readonly ITicketRepository _ticketRepository;

        public FileController(ITicketRepository ticketRepository) {
            this._ticketRepository = ticketRepository;
        }

        [HttpGet]
        [Route("ticket")]
        public async Task<IActionResult> GetAllTickets()
        {
            try
            {
                return Ok(await _ticketRepository.GetTicketsAsync());
            }
            catch (BadHttpRequestException exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpGet]
        [Route("ticket/report")]
        public async Task<IActionResult> GetTicketReport()
        {
            try
            {
                var tickets = await _ticketRepository.GetTicketsAsync();
                var reporte = new Report(tickets.ToList());
                return Ok(reporte);
            }
            catch (BadHttpRequestException exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpGet]
        [Route("ticket/{id}")]
        public async Task<IActionResult> GetTicketDetails(int id)
        {
            try
            {
                return Ok(await _ticketRepository.GetTicketAsync(id));
            }
            catch (BadHttpRequestException exception)
            {
                return BadRequest(exception.Message);
            }
        }


        [HttpPost]
        [Route("file")]
        public async Task<IActionResult> ProcessJson([FromBody] FilePost jsonRequest)
        {
            try 
            {
                var tickets = jsonRequest.Data.ToList();

                foreach (var ticket in tickets)
                {
                    var validationContext = new ValidationContext(ticket);
                    var resultsValidation = new List<ValidationResult>();

                    if (!Validator.TryValidateObject(ticket, validationContext, resultsValidation, validateAllProperties:true)) 
                    {
                        return BadRequest(resultsValidation);
                    }

                }

                return Ok(await _ticketRepository.InsertTicketAsync(tickets));
            } 
            catch (BadHttpRequestException exception) 
            {
                return BadRequest(exception.Message);
            }
        }
    }
}

