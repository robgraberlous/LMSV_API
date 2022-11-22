using AutoMapper;
using LMSV.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace LMSV.API.Controllers
{
    [ApiController]
    [Route("api/reporting/cards")]
    public class CardsController : ControllerBase
    {
        private readonly ILMSVReportingRepository _lmsvReportingRepository;
        private readonly IMapper _mapper;

        public CardsController(ILMSVReportingRepository lmsvReportingRepository,
            IMapper mapper)
        {
            _lmsvReportingRepository = lmsvReportingRepository ?? 
                throw new ArgumentNullException(nameof(lmsvReportingRepository));
            _mapper = mapper ?? 
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public JsonResult GetCards()
        {
            return new JsonResult(
                new List<object>
                {
                    new { id = 1, Name = "New York City" },
                    new { id = 2, Name = "Antwerp" }
                });
        }
    }
}
