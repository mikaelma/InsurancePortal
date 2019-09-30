using Application;
using Domain.Insurance;

namespace Persistence
{
    public class InsuranceRepository: EntityBaseRepository<Insurance>, IInsuranceRepository
    {
        public InsuranceRepository(Context context) : base(context) { }
        public bool IsOwner(string insuranceNumber, string customerNumber)
        {
            var insurance = this.GetSingle(insuranceNumber);
            return insurance.Customer.Id == customerNumber;
        }
    }
}