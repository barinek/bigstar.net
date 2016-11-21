using System;
using Xunit;

namespace Bigstar.Metrics {
    public class MetricsDataGatewayTest {
        [Fact]
        public void TestGetMetric() {
            MetricsInfo metric = new MetricsDataGateway().getMetrics();
            Assert.Equal(3, metric.NumberOfAccounts);
            Assert.Equal(7400000, metric.TotalContractValue);
        }
    }
}
