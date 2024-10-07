using NUnit.Framework;

namespace MyLibrary
{
    [TestFixture]
    internal class CustomerNUnitTest
    {
        [Test]
        public void FullName_ReturnEmpty()
        {
            Customer customer = new Customer();

            string result = customer.FullName;

            Assert.That(result, Is.WhiteSpace);
        }
        /*
        [Test]
        public void FullName_Contenido()
        {
            Customer customer = new Customer()
            {
                FirstName = "John",
                LastName = "Doe"
            };

            string result = customer.FullName;

            Assert.That(result, Is.WhiteSpace);
            Assert.That(result, Does.Contain(" "));
            Assert.That(result, Does.StartWith("John"));
            Assert.That(result, Does.EndWith("Doe"));
            Assert.That(result, Does.Contain("John Doe").IgnoreCase);
        }
        */
    }
}
