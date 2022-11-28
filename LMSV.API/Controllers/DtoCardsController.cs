//using AutoMapper;
//using LMSV.API.Models;
//using LMSV.API.Services;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Infrastructure;
//using Microsoft.AspNetCore.OData.Query;

//namespace LMSV.API.Controllers
//{
//    [ApiController]
//    [Route("api/reporting/cards")]
//    public class CardsController : ControllerBase
//    {
//        private readonly ILMSVReportingRepository _lmsvReportingRepository;
//        private readonly IMapper _mapper;

//        public CardsController(ILMSVReportingRepository lmsvReportingRepository,
//            IMapper mapper)
//        {
//            _lmsvReportingRepository = lmsvReportingRepository ??
//                throw new ArgumentNullException(nameof(lmsvReportingRepository));
//            _mapper = mapper ??
//                throw new ArgumentNullException(nameof(mapper));
//        }

//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<CardDto>>> GetCards()
//        {
//            var cardEntities = await _lmsvReportingRepository.GetCardsAsync();

//            return Ok(_mapper.Map<IEnumerable<CardDto>>(cardEntities));
//        }

//        [HttpGet("{id}")]
//        public async Task<ActionResult<IEnumerable<CardDto>>> GetCard(long id)
//        {
//            var card = await _lmsvReportingRepository.GetCardAsync(id);

//            return Ok(_mapper.Map<CardDto>(card));
//        }
//    }
//}
