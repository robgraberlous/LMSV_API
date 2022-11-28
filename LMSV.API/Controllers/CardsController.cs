using AutoMapper;
using LMSV.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.Controllers
{
    [Route("odata/reporting")]
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
        public async Task<IActionResult> GetAllCards()
        {
            return Ok(await _lmsvReportingRepository.GetCardsAsync());
        }

    }
}
