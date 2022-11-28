using AutoMapper;
using LMSV.API.DbContexts;
using LMSV.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.Controllers
{
    [Route("api/reporting")]
    public class CardsController : ODataController
    {
        private readonly CardInfoContext _context;
        
        public CardsController(CardInfoContext context)
        {
            _context = context ?? 
                throw new ArgumentNullException(nameof(context));
        }

        [HttpGet("Cards")]
        [EnableQuery]
        public ActionResult<IQueryable<Card>> GetAllCards()
        {
            return Ok(_context.Cards.AsQueryable<Card>());
        }

    }
}
