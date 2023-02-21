using DataAccess.Data;
using Models;
using AutoMapper;

namespace Logic.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LanEventDTO, LanEvent>().ReverseMap();
            CreateMap<LanGameDTO, LanGame>().ReverseMap();
        }
    }
}
