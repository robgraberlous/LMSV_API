using AutoMapper;

namespace LMSV.API.Profiles
{
    public class CardProfile : Profile
    {
        public CardProfile()
        {
            CreateMap<Entities.Card, Models.CardDto>();
        }
    }
}
