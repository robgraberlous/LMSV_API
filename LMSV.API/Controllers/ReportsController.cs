using AutoMapper;
using LMSV.API.DbContexts;
using LMSV.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Eventing.Reader;

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
        [HttpGet("Cards({key})")]
        [EnableQuery]
        public ActionResult<IQueryable<Card>> GetCards(long? key)
        {
            if (key == null)
                return Ok(_context.Cards.AsQueryable<Card>());
            
            var card = _context.Cards
                .FirstOrDefault(c => c.Id == key);
            if (card == null)
                return NotFound();
            return Ok(card);
        }

        [HttpGet("Clients")]
        [HttpGet("Clients({key})")]
        [EnableQuery]
        public ActionResult<IQueryable<Client>> GetClients(int? key)
        {
            if (key == null)
                return Ok(_context.Clients.AsQueryable<Client>());

            var client = _context.Clients
                .FirstOrDefault<Client>(c => c.Id == key);
            if (client == null)
                return NotFound();
            return Ok(client);
        }

        [HttpGet("EmsUsers")]
        [HttpGet("EmsUsers({key})")]
        [EnableQuery]
        public ActionResult<IQueryable<EmsUser>> GetEmsUsers(Guid? key)
        {
            if (key == null)
                return Ok(_context.EmsUsers.AsQueryable<EmsUser>());
            
            var user = _context.EmsUsers.FirstOrDefault(c => c.Id == key);
            if (user == null)
                return NotFound();
            return Ok(user);
        }

        [HttpGet("GiftCardTypes")]
        [HttpGet("GiftCardTypes({key})")]
        [EnableQuery]
        public ActionResult<IQueryable<GiftCardType>> GetGiftCardTypes(int? key)
        {
            if (key == null)
                return Ok(_context.GiftCardTypes.AsQueryable<GiftCardType>());
            
            var gcType = _context.GiftCardTypes.FirstOrDefault(t => t.Id == key);
            if (gcType == null)
                return NotFound();
            return Ok(gcType);
        }

        [HttpGet("Stores")]
        [HttpGet("Stores({key})")]
        [EnableQuery]
        public ActionResult<IQueryable<Store>> GetStores(int? key)
        {
            if (key == null)
                return Ok(_context.Stores.AsQueryable<Store>());
            
            var store = _context.Stores.FirstOrDefault(s => s.storeId == key);
            if (store == null)
                return NotFound();
            return Ok(store);
        }

        [HttpGet("Transactions")]
        [HttpGet("Transactions({key})")]
        [EnableQuery]
        public ActionResult<IQueryable<Transaction>> GetTransactions(int? key)
        {
            //var list = from t in _context.Transactions
            //           join c in _context.Cards
            //            on t.cardId equals c.Id
            //           select t;

            //return Ok(list.AsQueryable<Transaction>());

            if (key == null)
                return Ok(_context.Transactions.AsQueryable<Transaction>());
            
            var transaction = _context.Transactions.FirstOrDefault(t => t.Id == key);
            if (transaction == null)
                return NotFound();
            return Ok(transaction);
        }

    }
}
