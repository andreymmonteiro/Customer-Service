using AutoMapper;
using Customer.Domain.Dtos;
using Customer.Domain.Entities.Person;

namespace Customer.Service.Mapper.Profiles
{
    internal class EntityToDto : Profile
    {
        public EntityToDto()
        {
            PersonMap();
        }

        private void PersonMap()
        {
            CreateMap<PersonEntity, PersonDto>().ReverseMap();
            CreateMap<PersonEntity, PersonCreateDto>().ReverseMap();
            CreateMap<PersonEntity, PersonUpdateDto>().ReverseMap();
        }
    }
}
