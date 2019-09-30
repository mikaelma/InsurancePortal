using System;
using Domain.Insurance;

namespace Application
{
    public interface IInsuranceRepository: IEntityBaseRepository<Insurance>
    {
        bool IsOwner(string insuranceNumber, string customerNumber);
    }
}