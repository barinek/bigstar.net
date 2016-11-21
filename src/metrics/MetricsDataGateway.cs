using System;
using System.Collections.Generic;
using Bigstar.Accounts;

namespace Bigstar.Metrics {
    public class MetricsDataGateway {
        public MetricsInfo getMetrics() {
            double totalValue = 0.0;

            List<Account> accounts = new AccountsDataGateway().getAccounts();
            foreach (Account account in accounts)
            {
                totalValue =  totalValue + account.TotalContractValue;
            }
            return new MetricsInfo(accounts.Count, totalValue);    
        }
    }
}
