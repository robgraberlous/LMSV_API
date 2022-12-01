using AutoMapper;
using LMSV.API.DbContexts;
using LMSV.API.STSModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Eventing.Reader;

namespace LMSV.API.Controllers
{
    [Route("api/reporting/STS")]
    public class STSReportsController : ODataController
    {
        private readonly GcStsdataContext _context;
        
        public STSReportsController(GcStsdataContext context)
        {
            _context = context ?? 
                throw new ArgumentNullException(nameof(context));
        }

        [HttpGet("Cards")]
        [HttpGet("Cards({key})")]
        [EnableQuery]
        public ActionResult<IQueryable<STSCard>> GetCards(string? key)
        {
            if (key == null)
                return Ok(_context.Cards.AsQueryable<STSCard>());
            
            var card = _context.Cards
                .FirstOrDefault(c => c.CardNumber == key);
            if (card == null)
                return NotFound();
            return Ok(card);
        }

    }
}
