using System;
using Application;
//using Application.Customers;
// using Application.Insurances;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence;

namespace Dependencies
{
    public static class ServiceProviderBuilder
    {

        public static ServiceProvider Build()
        {
            return new ServiceCollection().AddServicesOfInsurancePortal().BuildServiceProvider();
        }
        public static IServiceCollection AddServicesOfInsurancePortal(this IServiceCollection services)
        {
            return services


                .AddScoped<ICustomerRepository, CustomerRepository>()
                .AddScoped<IInsuranceRepository, InsuranceRepository>();

            //.AddScoped<IInsuranceRepository, InsuranceDatabase>()
            //                .AddTransient<ICustomerRepository, CustomerDatabase>()
            // .AddScoped<ICustomers, Customers>()
            //                .AddSingleton<IInsuranceRepository, InsuranceDatabase>()
            // .AddScoped<IInsurances, Insurances>()
            // .AddScoped<IInsuranceDetailsMapper, InsuranceDetailsMapper>();

        }
    }
}