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


    // creates a new manager account in the user input through http requests
    [HttpPost("api/NewManagerAsync")]
        public async Task<ActionResult> CreateUserAsync(Managers m)
        {
            if (ModelState.IsValid)
            {
                Managers newman = await this._begin.NewUserAsync(m);
                return Ok(newman);
            }
            return null;
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


        [HttpGet("GetTicketStatusAsync/{status}")] // get all tickets of status
        public async Task<ActionResult<List<Tickets>>> GetTicketStatusAsync(int status)
        {
            List<Tickets> alltickets = await this._begin.GetTicketStatusAsync(status);
            return Ok(alltickets); //returns 200
        }

        [HttpPut("api/StatusAppAsync")]
        public async Task<ActionResult<UpdateDto>> StatusAppAsync(ApproveDto update)
        {
            if (ModelState.IsValid)
            {
                //send the tickets and managers to BusinessLayer
                UpdateDto approvedTicket = await this._begin.TicketStatusAppAsync(update);
                return approvedTicket;
            }
            else return Conflict(update);
        }
        
        [HttpPut("api/StatusDenAsync")]
        public async Task<ActionResult<DeniedDto>> StatusDenAsync(DeniedDto update)
        {
            if (ModelState.IsValid)
            {
                //send the tickets and managers to BusinessLayer
                DeniedDto deniedTicket = await this._begin.TicketStatusDenAsync(update);
                return deniedTicket;
            }
            else return Conflict(update);
        }
    }