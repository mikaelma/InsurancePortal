using System;
using Domain;

namespace Application.ViewModels.InsuranceViewModels
{
    public class RegisterCarInsuranceViewModel
    {
        public string Id { get; set; }
        public string InsuranceNumber { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateActive { get; set; }
        public string RegistrationNumber { get; set; }
        public string CustomerNumber { get; set; }
    }
}