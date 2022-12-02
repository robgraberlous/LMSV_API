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
    [Route("api/reporting")]
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

        [HttpGet("STSCards")]
        [HttpGet("STSCards({key})")]
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

        [HttpGet("Merchants")]
        [HttpGet("Merchants({key})")]
        [EnableQuery]
        public ActionResult<IQueryable<STSMerchant>> GetMerchants(int? key)
        {
            if (key == null)
                return Ok(_context.Merchants.AsQueryable<STSMerchant>());

            var merchant = _context.Merchants
                .FirstOrDefault(c => c.MerchantPk == key);
            if (merchant == null)
                return NotFound();
            return Ok(merchant);
        }

        [HttpGet("Products")]
        [HttpGet("Products({key})")]
        [EnableQuery]
        public ActionResult<IQueryable<STSProduct>> GetProducts(int? key)
        {
            if (key == null)
                return Ok(_context.Products.AsQueryable<STSProduct>());

            var product = _context.Products
                .FirstOrDefault(c => c.ProductPk == key);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        [HttpGet("Terminals")]
        [HttpGet("Terminals({key})")]
        [EnableQuery]
        public ActionResult<IQueryable<STSTerminal>> GetTerminals(decimal? key)
        {
            if (key == null)
                return Ok(_context.Terminals.AsQueryable<STSTerminal>());

            var terminal = _context.Terminals
                .FirstOrDefault(c => c.TerminalPk == key);
            if (terminal == null)
                return NotFound();
            return Ok(terminal);
        }

        [HttpGet("ValidProducts")]
        [HttpGet("ValidProducts({key})")]
        [EnableQuery]
        public ActionResult<IQueryable<STSValidProduct>> GetValidProducts(decimal? key)
        {
            if (key == null)
                return Ok(_context.ValidProducts.AsQueryable<STSValidProduct>());

            var validProduct = _context.ValidProducts
                .FirstOrDefault(c => c.ValidProductsPk == key);
            if (validProduct == null)
                return NotFound();
            return Ok(validProduct);
        }

        [HttpGet("Venues")]
        [HttpGet("Venues({key})")]
        [EnableQuery]
        public ActionResult<IQueryable<STSVenue>> GetVenues(decimal? key)
        {
            if (key == null)
                return Ok(_context.Venues.AsQueryable<STSVenue>());

            var venue = _context.Venues
                .FirstOrDefault(c => c.VenuePk == key);
            if (venue == null)
                return NotFound();
            return Ok(venue);
        }

        [HttpGet("WtConfigs")]
        [HttpGet("WtConfigs({key})")]
        [EnableQuery]
        public ActionResult<IQueryable<STSWtConfig>> GetWtConfigs(decimal? key)
        {
            if (key == null)
                return Ok(_context.WtConfigs.AsQueryable<STSWtConfig>());

            var wtConfig = _context.WtConfigs
                .FirstOrDefault(c => c.WtConfigPk == key);
            if (wtConfig == null)
                return NotFound();
            return Ok(wtConfig);
        }

        [HttpGet("WtUsers")]
        [HttpGet("WtUsers({key})")]
        [EnableQuery]
        public ActionResult<IQueryable<STSWtUser>> GetWtUsers(decimal? key)
        {
            if (key == null)
                return Ok(_context.WtUsers.AsQueryable<STSWtUser>());

            var wtUser = _context.WtUsers
                .FirstOrDefault(c => c.WtUsersPk == key);
            if (wtUser == null)
                return NotFound();
            return Ok(wtUser);
        }

    }
}
