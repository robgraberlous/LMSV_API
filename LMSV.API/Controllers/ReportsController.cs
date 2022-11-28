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
    public class ReportsController : ODataController
    {
        private readonly LMSVInfoContext _context;
        
        public ReportsController(LMSVInfoContext context)
        {
            _context = context ?? 
                throw new ArgumentNullException(nameof(context));
        }

        [HttpGet("Cards")]
        [EnableQuery]
        public ActionResult<IQueryable<Card>> GetCards()
        {
            return Ok(_context.Cards.AsQueryable<Card>());
        }

    }
}
