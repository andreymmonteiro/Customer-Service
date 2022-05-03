using Customer.Domain.Dtos;
using Customer.Domain.Entities.Person;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customer.Domain.Services
{
    public interface IPersonService
    {
        Task<IEnumerable<PersonDto>> GetAllAsync();
        
        Task<PersonDto> SingleAsync(Guid id);

        Task<PersonCreateDto> InsertAsync(PersonEntity entity);

        Task<PersonUpdateDto> UpdateAsync(PersonEntity entity);

        Task<bool> DeleteAsync(Guid id);

    }
}
