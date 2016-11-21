using System;

namespace Bigstar.Accounts {
    public class Account {
        public string Name { get; }
        public double TotalContractValue { get; }
        public Account(string Name, double TotalContractValue)
        {
            this.Name = Name;
            this.TotalContractValue = TotalContractValue;
        }
    }
}
