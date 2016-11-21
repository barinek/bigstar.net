using System;
using Xunit;

namespace Bigstar.Accounts {
    public class Tests{
        [Fact]
        public void TestGetAccounts() {
            Assert.Equal(3, new AccountsDataGateway().getAccounts().Count);
        }
    }
}
