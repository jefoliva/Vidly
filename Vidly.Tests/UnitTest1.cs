using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Vidly.Dtos;
using Vidly.Controllers.Api;
using System.Web.Mvc;

namespace Vidly.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAllCustomers()
        {
            var testCustomers = GetTestCustomers();
            var controller = new CustomersController();

            var result = controller.GetCustomers();
            Assert.AreEqual(testCustomers.Count, 8);

            //var controller = new CustomersController();
            //var result = controller.Details(1) as ViewResult;

            //var nView = result.View;
            //var nModel = result.Model;



            //Assert.AreEqual("{Vidly.Models.Customer}", result.Model.ToString());
        }

        private List<CustomerDto> GetTestCustomers()
        {
            var testCustomers = new List<CustomerDto>();
            testCustomers.Add(new CustomerDto { Id = 1, Name = "John Doe",  Birthdate = new DateTime(), MembershipTypeId = 1});
            testCustomers.Add(new CustomerDto() { Id = 1, Name = "John Doe", IsSubscribedToNewsletter = false, MembershipTypeId = 1, Birthdate = new DateTime(1994, 6, 10) });
            testCustomers.Add(new CustomerDto() { Id = 2, Name = "Carl Sagan", IsSubscribedToNewsletter = false, MembershipTypeId = 2, Birthdate = new DateTime(1994, 6, 10) });
            testCustomers.Add(new CustomerDto() { Id = 3, Name = "Richard Feynman", IsSubscribedToNewsletter = false, MembershipTypeId = 3, Birthdate = new DateTime(1994, 6, 10) });
            testCustomers.Add(new CustomerDto() { Id = 4, Name = "Jorge Luis Borges", IsSubscribedToNewsletter = false, MembershipTypeId = 4, Birthdate = new DateTime(1994, 6, 10) });
            testCustomers.Add(new CustomerDto() { Id = 5, Name = "Marcus Aurelius", IsSubscribedToNewsletter = false, MembershipTypeId = 5, Birthdate = new DateTime(1994, 6, 10) });
            testCustomers.Add(new CustomerDto() { Id = 6, Name = "Dennis Ritchie", IsSubscribedToNewsletter = false, MembershipTypeId = 6, Birthdate = new DateTime(1994, 6, 10) });
            testCustomers.Add(new CustomerDto() { Id = 7, Name = "Edger Dijkstra", IsSubscribedToNewsletter = false, MembershipTypeId = 7, Birthdate = new DateTime(1994, 6, 10) });


            return testCustomers;
        }
    }
}
