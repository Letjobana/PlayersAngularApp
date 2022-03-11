using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlayersAngularProject.Models;
using PlayersAngularProject.Persistance;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlayersAngularProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public PlayersController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
        {
            try
            {
                return await context.Players.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
