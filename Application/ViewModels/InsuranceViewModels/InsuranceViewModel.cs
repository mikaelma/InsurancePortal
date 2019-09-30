using System.Collections.Generic;

namespace Application.ViewModels.InsuranceViewModels
{
    public class InsuranceViewModel
    {
        public string Id { get; set; }
        public string InsuranceNumber { get; set; }
        public bool IsActive { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CustomerId { get; set; }
    }
}