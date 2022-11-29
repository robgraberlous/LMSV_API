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

        [HttpGet("Clients")]
        [EnableQuery]
        public ActionResult<IQueryable<Client>> GetClients()
        {
            return Ok(_context.Clients.AsQueryable<Client>());
        }

        [HttpGet("EmsUsers")]
        [EnableQuery]
        public ActionResult<IQueryable<EmsUser>> GetEmsUsers()
        {
            return Ok(_context.EmsUsers.AsQueryable<EmsUser>());
        }

        [HttpGet("GiftCardTypes")]
        [EnableQuery]
        public ActionResult<IQueryable<GiftCardType>> GetGiftCardTypes()
        {
            return Ok(_context.GiftCardTypes.AsQueryable<GiftCardType>());
        }

        [HttpGet("Transactions")]
        [EnableQuery]
        public ActionResult<IQueryable<Transaction>> GetTransactions()
        {
            //var list = from t in _context.Transactions
            //           join c in _context.Cards
            //            on t.cardId equals c.Id
            //           select t;

            //return Ok(list.AsQueryable<Transaction>());

            return Ok(_context.Transactions.AsQueryable<Transaction>());
        }

    }
}
