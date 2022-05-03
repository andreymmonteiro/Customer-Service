using AutoMapper;
using Customer.Domain.Mapper;
using Customer.Service.Mapper.Profiles;

namespace Customer.Service.Mapper
{
    public sealed class ServiceMapper : IServiceMapper
    {
        public IMapper GetMapper()
        {
            var config = new MapperConfiguration(options =>
                {
                    options.AddProfile(new EntityToDto());
                }
            );
            return config.CreateMapper();
        }
    }
}
