using System.Collections;
using System.Collections.Generic;
using Domain.Insurance;

namespace Domain
{
    public class Customer: IEntityBase
    {
        public string Id { get; set; }
        public string CustomerNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Person PersonalInformation { get; set; }
        public ICollection<Insurance.Insurance> Insurances { get; set; }
    }
}