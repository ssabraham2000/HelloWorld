using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Controllers;

namespace HelloWorld.Tests.Controllers
{
    [TestClass]
    public class PublicControllerTest
    {
        [TestMethod]
        public void GetMessage()
        {
            // Arrange
            PublicController controller = new PublicController();

            // Act
            string result = controller.GetMessage();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
