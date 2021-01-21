using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutput_DividesBy3And5_ReturnsFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_DividesBy3_ReturnsFizz()
        {
            var result = FizzBuzz.GetOutput(3);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_DividesBy5_ReturnsBuzz()
        {
            var result = FizzBuzz.GetOutput(5);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_DoesNotDivideBy3Or5_ReturnsInputNumberAsString()
        {
            var result = FizzBuzz.GetOutput(4);
            Assert.That(result, Is.EqualTo("4"));
        }
    }
}
