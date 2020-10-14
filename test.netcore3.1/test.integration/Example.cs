using System.Threading.Tasks;
using Microsoft.AspNetCore.TestHost;
using Xunit;

namespace test.integration
{
    public class Example
    {
        [Fact]
        public void Test1()
        {
            TestServer server = new TestServer(Program.CreateHostBuilder(new string[] { })
                .ConfigureTestServices(collection =>
                {
                    
                }));
            var client = server.CreateClient();
            
            Assert.NotNull(client);
        }
    }
}
