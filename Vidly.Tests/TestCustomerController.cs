using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Vidly.Dtos;
using Vidly.Controllers;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Http.Results;

namespace Vidly.Tests
{
    [TestClass]
    public class TestCustomerController
    {
        [TestMethod]
        public void TestModeloDetailView()
        {

            var controller = new CustomersController();
            var result = controller.Details(1) as ViewResult;


            Assert.AreEqual("Vidly.Models.Customer", result.Model.ToString());
        }

        [TestMethod]
        public void TestCustomerIndexView()
        {
            var controller = new CustomersController();
            var result = controller.Index() as ViewResult;

            Assert.AreEqual(result.ViewName, "Index");
        }

        [TestMethod]
        public void TestNewView()
        {
            var controller = new CustomersController();
            var result = controller.New() as ViewResult;

            Assert.AreEqual(result.ViewName, "CustomerForm");
        }


        [TestMethod]
        public void TestEditView()
        {
            var controller = new CustomersController();
            var result = controller.Edit(1) as ViewResult;

            Assert.AreEqual(result.ViewName, "CustomerForm");
        }
    }
}
