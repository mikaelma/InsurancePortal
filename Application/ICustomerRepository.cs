using Domain;

namespace Application
{
    public interface ICustomerRepository: IEntityBaseRepository<Customer>
    {
        bool IsEmailUnique(string email);
    }
}