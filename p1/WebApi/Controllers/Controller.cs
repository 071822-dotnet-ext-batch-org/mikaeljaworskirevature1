using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BusinessLayer;
using Models;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class Controller : ControllerBase
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        private readonly DoBusiness _begin;
        public APIController()
        {
            this._begin = new DoBusiness();
        }


        // logs in the user input through http requests
        [HttpPost("loginuserasync")]
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
        [HttpPost("create_new_ticket")]
        public async Task<ActionResult> CreateTicketAsync(Tickets ticket)
        {
            if (ModelState.IsValid)
            {
                Tickets newTicket = await this._begin.CreateTicketQueryAsync(ticket);
                return Ok(newTicket);
            }
            return null;
        }



        [HttpGet("get_ticket_status")] // get all tickets
        [HttpGet("GetStatusAsync/{status}")] // get all tickets of status
        public async Task<ActionResult<List<Tickets>>> GetTicketStatusAsync(int status)
        {
            List<Tickets> alltickets = await this._begin.GetTicketStatusAsync(status);
            return Ok(alltickets); //returns 200
            //return null;
        }

        [HttpPut("approve_ticket")]
        public async Task<ActionResult<Tickets>> StatusAppAsync(Tickets approved, Managers m)
        {
            if (ModelState.IsValid)
            {
                //send the tickets and managers to BusinessLayer
                Tickets approvedTicket = await this._begin.TicketStatusAppAsync(approved, m);
                return approvedTicket;
            }
            else return Conflict(approved);
        }
        
        [HttpPut("deny_ticket")]
        public async Task<ActionResult<Tickets>> StatusDenAsync(Tickets denied, Managers m)
        {
            if (ModelState.IsValid)
            {
                //send the tickets and managers to BusinessLayer
                Tickets deniedTicket = await this._begin.TicketStatusDenAsync(denied, m);
                return deniedTicket;
            }
            else return Conflict(denied);
        }
    }
}