using Application;
using Domain;

namespace Persistence
{
    public class CustomerRepository: EntityBaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(Context context) : base(context) { }
        public bool IsEmailUnique(string email)
        {
            var customer = this.GetSingle(c => c.Email == email);
            return customer == null;
        }
    }
}