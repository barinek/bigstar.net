using System;
using System.IO;
using System.Net.Http;
using System.Reflection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;

namespace Bigstar.Server {
    public class TestFixture<TStartup> : IDisposable where TStartup : class  {
        
        private readonly TestServer _server;
        
        public TestFixture() {
            var builder = new WebHostBuilder().UseStartup<TStartup>();
            _server = new TestServer(builder);
            
            Client = _server.CreateClient();
            Client.BaseAddress = new Uri("http://localhost:5002");
        }

        public HttpClient Client { get; }

        public void Dispose() {
            Client.Dispose();
            _server.Dispose();
        }
    }
}