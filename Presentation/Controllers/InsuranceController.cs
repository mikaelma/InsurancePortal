using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Application;
using Application.ViewModels.InsuranceViewModels;
using AutoMapper;
using Domain.Insurance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{

    [Route("api/[controller]")]
   // [Authorize]
    [ApiController]
    public class InsuranceController : ControllerBase
    {
        private IInsuranceRepository insuranceRepository;
        private ICustomerRepository customerRepository;
        private IMapper mapper;

        public InsuranceController(IInsuranceRepository insuranceRepository, ICustomerRepository customerRepository, IMapper mapper)
        {
            this.insuranceRepository = insuranceRepository;
            this.customerRepository = customerRepository;
            this.mapper = mapper;
        }

        [HttpGet()]
        public ActionResult<InsurancesViewModel> GetStories([FromBody] string customerId)
        {

            var stories = insuranceRepository.AllIncluding(c => c.Customer.CustomerNumber);
            return new InsurancesViewModel
            {
                Insurances = stories.Select(mapper.Map<InsuranceViewModel>).ToList()
            };
        }

        [HttpPost("AddCarInsurance")]
        public ActionResult<CarInsuranceCreationViewModel> Post([FromBody] RegisterCarInsuranceViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var id = Guid.NewGuid().ToString();
            
            var customer = customerRepository.GetSingle(c=> c.CustomerNumber == model.CustomerNumber);

            if (customer == null) return NotFound();

            var valid = CheckValidity(model.DateActive);
            var premium = CalculatePremium();


            var insurance = new CarInsurance
            {
               // Customer = customer,
                CustomerId = customer.Id,
                DateOfPurchase = DateTime.Now,
                Id = id,
                IsActive = valid,
                Premium = premium,
                InsuranceNumber = new Random().Next(0, 100).ToString(),

                DateActive = DateTime.Now,
                RegistrationNumber = model.RegistrationNumber
            };

            insuranceRepository.Add(insurance);
            insuranceRepository.Commit();

            var thing = new CarInsuranceCreationViewModel
            {
                InsuranceId = id
            };
            return Ok(thing);
        }

        private bool CheckValidity(DateTime activationDate)
        {
            return activationDate <= DateTime.Today ? true : false;

        }

        private string CalculatePremium()
        {
            return "1000";
        }
    }
}