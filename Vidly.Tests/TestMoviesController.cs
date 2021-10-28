using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using Vidly.Controllers;

namespace Vidly.Tests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class TestMoviesController
    {
        [TestMethod]
        public void TestIndexView()
        {
            var controller = new MoviesController();
            var result = controller.Index() as ViewResult;

            Assert.AreEqual("List", result.ViewName);
        }


        [TestMethod]
        public void TestNewView()
        {
            var controller = new MoviesController();
            var result = controller.New() as ViewResult;

            Assert.AreEqual("MovieForm", result.ViewName);
        }

        [TestMethod]
        public void TestEditView()
        {
            var controller = new MoviesController();
            var result = controller.Edit(1) as ViewResult;

            Assert.AreEqual("MovieForm", result.ViewName);
        }
    }
}
