using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NuGet.Frameworks;
using Source.DevOps.Backend.Controllers;

namespace Source.DevOps.Tests.Controllers
{
    public class AuthControllerUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("test@gmail.com", "1234567")]
        //[TestCase("test2@gmail.com", "123456")]
        public void TestAuth(string email, string password)
        {
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddFilter("Microsoft", LogLevel.Warning)
                    .AddFilter("System", LogLevel.Warning)
                    .AddFilter("NonHostConsoleApp.Program", LogLevel.Debug)
                    .AddConsole();
            });
            var logger = loggerFactory.CreateLogger<AuthController>();

            var auth = new AuthController(logger);
            var response = auth.Login(email, password);

            if (response is OkObjectResult)
                Assert.Pass();

            Assert.Fail("Auth is KO");
        }
    }
}