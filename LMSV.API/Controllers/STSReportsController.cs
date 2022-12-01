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

        [HttpGet("Addresses")]
        [HttpGet("Addresses({key})")]
        [EnableQuery]
        public ActionResult<IQueryable<STSAddress>> GetAddresses(decimal? key)
        {
            if (key == null)
                return Ok(_context.Addresses.AsQueryable<STSAddress>());
            
            var address = _context.Addresses
                .FirstOrDefault(c => c.AddressPk == key);
            if (address == null)
                return NotFound();
            return Ok(address);
        }

        [HttpGet("CardOrders")]
        [HttpGet("CardOrders({key})")]
        [EnableQuery]
        public ActionResult<IQueryable<STSCard>> GetCardOrders(decimal? key)
        {
            if (key == null)
                return Ok(_context.CardOrders.AsQueryable<STSCardOrder>());

            var cardOrder = _context.CardOrders
                .FirstOrDefault(c => c.CardOrdersPk == key);
            if (cardOrder == null)
                return NotFound();
            return Ok(cardOrder);
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
