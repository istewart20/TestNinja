using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenGivenAlphanumericString_ReturnsStringSurroundedByStrongTags()
        {
            var htmlFormatter = new HtmlFormatter();
            var result = htmlFormatter.FormatAsBold("Test123");
            Assert.That(result, Is.EqualTo("<strong>Test123</strong>").IgnoreCase);
        }
    }
}
