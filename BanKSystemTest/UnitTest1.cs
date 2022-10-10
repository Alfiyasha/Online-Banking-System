using BankSystem.Controllers;
using BankSystem.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;

namespace BanKSystemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Register()
        {
            
            HomeController controller = new HomeController();
            login lg = new login();
            lg.username = "Test";
            lg.password = "Test";
            lg.Name = "Test1";
            lg.Phone = "9874562534";
            lg.Email = "Test@gmail.com";
            lg.DOB = DateTime.Now;
            lg.Address = "bangalore";
            lg.Branch = "Bangalore";
            lg.AccountType = "current";

            var result = (System.Web.Mvc.RedirectToRouteResult) controller.Register(lg);

            Assert.AreEqual("BankPage", result.RouteValues["action"]);
        }
       

    }
}
