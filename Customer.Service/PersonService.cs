using AutoMapper;
using Customer.Domain.Dtos;
using Customer.Domain.Entities.Person;
using Customer.Domain.Interfaces;
using Customer.Domain.Mapper;
using Customer.Domain.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customer.Service
{
    public class PersonService : IPersonService
    {
        private readonly IRepository<PersonEntity> _repository;

        private readonly IMapper _mapper;

        public PersonService(IRepository<PersonEntity> repository, IServiceMapper mapper)
        {
            _repository = repository;
            _mapper = mapper.GetMapper();
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<PersonDto>> GetAllAsync()
        {
            return  _mapper.Map<IEnumerable<PersonDto>>(await _repository.GetAllAsync());
        }

        public async Task<PersonCreateDto> InsertAsync(PersonEntity entity)
        {
            return _mapper.Map<PersonCreateDto>(await _repository.UpdateAsync(entity));
        }

        public async Task<PersonDto> SingleAsync(Guid id)
        {
            return _mapper.Map<PersonDto>(await _repository.SingleAsync(id));
        }

        public async Task<PersonUpdateDto> UpdateAsync(PersonEntity entity)
        {
            return _mapper.Map<PersonUpdateDto>(await _repository.UpdateAsync(entity));
        }
    }
}
