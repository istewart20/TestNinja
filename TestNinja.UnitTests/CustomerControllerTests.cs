using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var customerController = new CustomerController();
            var result = customerController.GetCustomer(0);
            Assert.That(result, Is.TypeOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnNotOk()
        {
            var customerController = new CustomerController();
            var result = customerController.GetCustomer(1);
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
