using Customer.Domain.Entities.Person;
using Customer.Domain.Interfaces;
using Customer.Domain.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customer.Service
{
    public class PersonService : IPersonService
    {
        private readonly IRepository<PersonEntity> _repository;

        public PersonService(IRepository<PersonEntity> repository)
        {
            _repository = repository;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<PersonEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();

        }

        public async Task<PersonEntity> InsertAsync(PersonEntity entity)
        {
            return await _repository.UpdateAsync(entity);
        }

        public async Task<PersonEntity> SingleAsync(Guid id)
        {
            return await _repository.SingleAsync(id);
        }

        public async Task<PersonEntity> UpdateAsync(PersonEntity entity)
        {
            return await _repository.UpdateAsync(entity);
        }
    }
}
