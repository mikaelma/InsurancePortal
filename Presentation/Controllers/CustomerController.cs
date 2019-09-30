using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;
using Application.ViewModels.CustomerViewModels;
using Dependencies.Auth;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private ICustomerRepository customerRepository;
        IAuthService authService;


        public CustomerController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        [HttpPost("AddCustomer")]
        public ActionResult<CustomerCreationViewModel> Post([FromBody] RegisterCustomerViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var id = Guid.NewGuid().ToString();
            //var pw = authService.HashPassword(model.Password);
            var customer = new Customer
            {
                Id = id,
                Email = model.Email,
                Password = model.Password,
                CustomerNumber = new Random().Next(0, 100).ToString(),
                PersonalInformation = new Person
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Id = id,
                    SocialSecurityNumber = model.SocialSecurityNumber,
                    TelephoneNumber = model.TelephoneNumber,
                    Address = new Address
                    {
                        City = model.City,
                        Country = model.Country,
                        Id = id,
                        PostalCode = model.PostalCode,
                        StreetNameAndNumber = model.StreetNameAndNumber
                    }
                }
            };

            customerRepository.Add(customer);
            customerRepository.Commit();

            return new CustomerCreationViewModel
            {
                CustomerNumber = customer.CustomerNumber
            };

        }

    }
}