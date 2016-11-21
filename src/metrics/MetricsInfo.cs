using System;

namespace Bigstar.Metrics {
    public class MetricsInfo {
        public int NumberOfAccounts { get; }
        public double TotalContractValue { get; }
        public MetricsInfo(int NumberOfAccounts, double TotalContractValue)
        {
            this.NumberOfAccounts = NumberOfAccounts;
            this.TotalContractValue = TotalContractValue;
        }
    }
}
