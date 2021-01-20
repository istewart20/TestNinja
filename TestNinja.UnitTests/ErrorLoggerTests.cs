using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetsTheLastErrorProperty()
        {
            var errorLogger = new ErrorLogger();
            errorLogger.Log("test");
            Assert.That(errorLogger.LastError, Is.EqualTo("test"));
        }
    }
}
