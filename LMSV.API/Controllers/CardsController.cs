using AutoMapper;
using LMSV.API.Entities;
using LMSV.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.Controllers
{
    [Route("api/reporting")]
    public class CardsController : ODataController
    {
        private readonly ILMSVReportingRepository _lmsvReportingRepository;

        public CardsController(ILMSVReportingRepository lmsvReportingRepository)
        {
            _lmsvReportingRepository = lmsvReportingRepository ??
                throw new ArgumentNullException(nameof(lmsvReportingRepository));
        }

        [HttpGet("Cards")]
        [EnableQuery]
        public ActionResult<IQueryable<Card>> GetAllCards()
        {
            return Ok(_lmsvReportingRepository.GetCards());
        }

    }
}
