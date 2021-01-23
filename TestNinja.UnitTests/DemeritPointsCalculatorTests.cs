using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class DemeritPointsCalculatorTests
    {
        [Test]
        public void CalculateDemeritPoints_NegativeSpeed_ThrowsArgumentOutOfRangeException()
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();
            Assert.That(() => demeritPointsCalculator.CalculateDemeritPoints(-1), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void CalculateDemeritPoints_SpeedOverMaximumValue_ThrowsArgumentOutOfRangeException()
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();
            Assert.That(() => demeritPointsCalculator.CalculateDemeritPoints(301), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void CalculateDemeritPoints_SpeedLessThanLimit_ReturnsZero()
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();
            var result = demeritPointsCalculator.CalculateDemeritPoints(64);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateDemeritPoints_SpeedEqualsLimit_ReturnsZero()
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();
            var result = demeritPointsCalculator.CalculateDemeritPoints(65);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateDemeritPoints_SpeedOfSeventy_ReturnsOneDemeritPoint()
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();
            var result = demeritPointsCalculator.CalculateDemeritPoints(70);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void CalculateDemeritPoints_SpeedOfTwoHundredNinetyNine_ReturnsOneDemeritPoint()
        {
            var demeritPointsCalculator = new DemeritPointsCalculator();
            var result = demeritPointsCalculator.CalculateDemeritPoints(299);
            Assert.That(result, Is.EqualTo(46));
        }
    }
}
