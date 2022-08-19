using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BusinessLayer;
using Models;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")] //TODOfix routing for all folders to properly load onto Swagger
public class MikaelController : ControllerBase
{
        private readonly DoBusiness _begin;
        public MikaelController()
        {
            this._begin = new DoBusiness();
        }


        // logs in the user input through http requests
        [HttpPost("api/LoginUserAsync")]
        public async Task<ActionResult> LoginUserAsync(Login login)
        {
            if (ModelState.IsValid)
            {
            Login newlogin = await this._begin.GetLoginAsync(login);
            return Ok(newlogin);
            }
            return null;
        }

        // asynchronously present the user with a new ticket object to be filled out
        [HttpPost("api/CreateTicketAsync")]
        public async Task<ActionResult> CreateTicketAsync(Tickets ticket)
        {
            if (ModelState.IsValid)
            {
                Tickets newTicket = await this._begin.CreateTicketQueryAsync(ticket);
                return Ok(newTicket);
            }
            return null;
        }



        [HttpGet("api/GetTicketStatusAsync")] // get all tickets
        [HttpGet("GetTicketStatusAsync/{status}")] // get all tickets of status
        public async Task<ActionResult<List<Tickets>>> GetTicketStatusAsync(int status)
        {
            List<Tickets> alltickets = await this._begin.GetTicketStatusAsync(status);
            return Ok(alltickets); //returns 200
        }

        [HttpPut("api/StatusAppAsync")]
        public async Task<ActionResult<Tickets>> StatusAppAsync(Tickets approved)
        {
            if (ModelState.IsValid)
            {
                //send the tickets and managers to BusinessLayer
                Tickets approvedTicket = await this._begin.TicketStatusAppAsync(approved);
                return approvedTicket;
            }
            else return Conflict(approved);
        }
        
        [HttpPut("api/StatusDenAsync")]
        public async Task<ActionResult<Tickets>> StatusDenAsync(Tickets denied)
        {
            if (ModelState.IsValid)
            {
                //send the tickets and managers to BusinessLayer
                Tickets deniedTicket = await this._begin.TicketStatusDenAsync(denied);
                return deniedTicket;
            }
            else return Conflict(denied);
        }
    }