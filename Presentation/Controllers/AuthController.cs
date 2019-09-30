using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Application;
using Application.Models.UserHandlingModels;
using Dependencies.Auth;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IAuthService authService;
        ICustomerRepository customerRepository;
        public AuthController(IAuthService authService, ICustomerRepository customerRepository)
        {
            this.authService = authService;
            this.customerRepository = customerRepository;
        }


        [HttpPost("login")]
        public ActionResult<AuthData> Post([FromBody] LoginViewModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var customer = customerRepository.GetSingle(c => c.Email == model.Email);

            if (customer == null)
            {
                return BadRequest(new {email = "No user with this email!"});
            }

            var passwordValid = authService.VerifyPassword(model.Password, customer.Password);
            if (!passwordValid)
            {
                return BadRequest(new {password = "Invalid password"});
            }

            return authService.GetAuthData(customer.Id);
        }

        [HttpPost("register")]
        public ActionResult<AuthData> Post([FromBody] RegisterViewModel model)
        {

            Debug.WriteLine(model.FirstName + model.Email + model.Password);
            /*
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var emailUniq = customerRepository.IsEmailUnique(model.Email);
            if (!emailUniq) return BadRequest(new { email = "user with this email already exists" });

            */
            var id = Guid.NewGuid().ToString();

            var customer = new Customer
            {
                Id = id,
                Email = model.Email,
                Password = authService.HashPassword(model.Password),
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
            return authService.GetAuthData(id);
        }
    }
}