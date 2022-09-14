using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace entityDemo.Models
{
    [Route("api/[controller]")]
    public class AssociateController : Controller
    {
        private static List<Associates> Associates = new List<Associates>
        {
            new Associates
            {
                Id = 1,
                LastName = "Jaworski",
                FirstName = "Mikael",
                Date = DateTime.Now
            }

        };


        [HttpGet("{id}")]
        public async Task<ActionResult<Associates>> GetIdAsync(int id)
        {
            Associates blank = new Associates
            {
                Id = 0,
                LastName = "",
                FirstName = "",
                Date = DateTime.Now
            };

            var associate = Associates.Find(a => a.Id == id);

            if (associate == null)
                return BadRequest("Associate Not Found.");
            return Ok(associate);
        }

        
        [HttpGet]
        public async Task<ActionResult<List<Associates>>> GetAssociateAsync()
        {
            return Ok(Associates);
        }



        [HttpPost]
        public async Task<ActionResult<List<Associates>>> AddAssociatesAsync(Associates newAssociate)
        {
            Associates.Add(newAssociate);
            return Ok(Associates);
        }


        [HttpPut]
        public async Task<ActionResult<List<Associates>>> UpdateAssociate(Associates update)
        {
            var associate = Associates.Find(a => a.Id == update.Id);

            if (associate == null)
                return BadRequest("Associate Not Found.");

            associate.FirstName = update.FirstName;
            associate.LastName = update.LastName;
            associate.Date = update.Date;

            return Ok(Associates);
        }


        [HttpDelete]
        public async Task<ActionResult<List<Associates>>> DeleteAssociate(int id)
        {
            var associate = Associates.Find(a => a.Id == id);

            if (associate == null)
                return BadRequest("Associate Not Found.");

            Associates.Remove(associate);
            return Ok(Associates);
        }


    }//EoC
}//EoN

