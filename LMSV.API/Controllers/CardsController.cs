using AutoMapper;
using LMSV.API.Models;
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

        public CardsController(ILMSVReportingRepository lmsvReportingRepository)//,
            //IMapper mapper)
        {
            _lmsvReportingRepository = lmsvReportingRepository ?? 
                throw new ArgumentNullException(nameof(lmsvReportingRepository));
            //_mapper = mapper ?? 
            //    throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CardDto>>> GetCards()
        {
            var cardEntities = await _lmsvReportingRepository.GetCardsAsync();

            var results = new List<CardDto>();
            int i = 0;
            foreach (var cardEntity in cardEntities)
            {
                if (i++ < 100)
                    results.Add(new CardDto
                    {
                        Id = cardEntity.Id,
                        Balance = cardEntity.Balance,
                        cardNumber = cardEntity.cardNumber,
                        pin = cardEntity.pin,
                        cardTypeId = cardEntity.cardTypeId,
                        active = cardEntity.active,
                        dateActivated = cardEntity.dateActivated,
                        dateDeactivated = cardEntity.dateDeactivated,
                        customerId = cardEntity.customerId,
                        name = cardEntity.name,
                        createdAt = cardEntity.createdAt,
                        updatedAt = cardEntity.updatedAt
                    });
            }

            return Ok(results);
        }
    }
}
