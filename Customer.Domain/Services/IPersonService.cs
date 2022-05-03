using Customer.Domain.Entities.Person;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customer.Domain.Services
{
    public interface IPersonService
    {
        Task<IEnumerable<PersonEntity>> GetAllAsync();
        
        Task<PersonEntity> SingleAsync(Guid id);

        Task<PersonEntity> InsertAsync(PersonEntity entity);

        Task<PersonEntity> UpdateAsync(PersonEntity entity);

        Task<bool> DeleteAsync(Guid id);

    }
}
