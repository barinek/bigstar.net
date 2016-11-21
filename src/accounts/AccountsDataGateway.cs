using System;
using System.Collections.Generic;

namespace Bigstar.Accounts {
    public class AccountsDataGateway {
        public List<Account> getAccounts() {
            return new List<Account> // replace with db call
            {
                new Account("John's Grocery", 6000000.00),
                new Account("Hamburg Inn No. 2", 0.00),
                new Account("Record Collector'", 1400000.00)
            };
        }
    }
}