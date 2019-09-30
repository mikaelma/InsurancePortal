using System;

namespace Domain.Insurance
{
    public class Insurance: IEntityBase
    {
        public string Id { get; set; }
        public string InsuranceNumber { get; set; }
        public Customer Customer { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateActive { get; set; }
        public string CustomerId { get; set; }
    }
}