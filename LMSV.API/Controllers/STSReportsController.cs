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

        [HttpGet("CardTrans")]
        [HttpGet("CardTrans({key})")]
        [EnableQuery]
        public ActionResult<IQueryable<STSCardTran>> GetCardTrans(int? key)
        {
            if (key == null)
                return Ok(_context.CardTrans.AsQueryable<STSCardTran>());

            var cardTran = _context.CardTrans
                .FirstOrDefault(c => c.CardTransPk == key);
            if (cardTran == null)
                return NotFound();
            return Ok(cardTran);
        }

        [HttpGet("Chains")]
        [HttpGet("Chains({key})")]
        [EnableQuery]
        public ActionResult<IQueryable<STSChain>> GetChains(decimal? key)
        {
            if (key == null)
                return Ok(_context.Chains.AsQueryable<STSChain>());

            var chain = _context.Chains
                .FirstOrDefault(c => c.ChainPk == key);
            if (chain == null)
                return NotFound();
            return Ok(chain);
        }

        [HttpGet("Clerks")]
        [HttpGet("Clerks({key})")]
        [EnableQuery]
        public ActionResult<IQueryable<STSClerk>> GetClerks(decimal? key)
        {
            if (key == null)
                return Ok(_context.Clerks.AsQueryable<STSClerk>());

            var clerk = _context.Clerks
                .FirstOrDefault(c => c.ClerkPk == key);
            if (clerk == null)
                return NotFound();
            return Ok(clerk);
        }
    }
}
