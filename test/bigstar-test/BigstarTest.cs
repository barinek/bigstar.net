using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xunit;

namespace Bigstar.Server {
    
    public class ServerTest : IClassFixture<TestFixture<Bigstar.Server.Startup>> {

        public ServerTest(TestFixture<Bigstar.Server.Startup> fixture) {
            Client = fixture.Client;
        }

        public HttpClient Client { get; }

        [Fact]
        public async Task TestAccounts() {

            var request = new HttpRequestMessage(new HttpMethod("GET"), "/api/accounts");

            var response = await Client.SendAsync(request);
        
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            
            var contents = await response.Content.ReadAsStringAsync();

            Assert.True(contents.Contains("Hamburg Inn No. 2"));
        }

        [Fact]
        public async Task TestMetrics() {

            var request = new HttpRequestMessage(new HttpMethod("GET"), "/api/metrics");

            var response = await Client.SendAsync(request);
        
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            
            var contents = await response.Content.ReadAsStringAsync();

            Assert.True(contents.Contains("7400000"));
        }
    }
}
