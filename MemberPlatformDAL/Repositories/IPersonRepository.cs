using MemberPlatformDAL.Entities;
using MemberPlatformDAL.UoW;

namespace MemberPlatformDAL.Repositories
{
    public interface IPersonRepository : IGenericRepository<PersonEntity>
    {
        Task<IEnumerable<PersonEntity>> GetAllWithAddressAsync();

        Task<PersonEntity> SaveAsync(PersonEntity personEntity, int addressId);

        Task<PersonEntity> GetByEmailAddressAsync(string emailAddress);

        Task<PersonEntity> UpdateAsync(PersonEntity personEntity);

        //Task SaveAsync();
    }
}
