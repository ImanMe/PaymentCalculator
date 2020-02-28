using PaymentCalculator.Core.Models;
using Xunit;

namespace PaymentCalculator.Test
{
    public class PaymentDetailsTest
    {
        [Fact]
        public void TestTotalEstimatedPayment()
        {
            var paymentDetails = new PaymentDetails(
                provinceCode: "NS-B2",
                sellingPrice: 27031.00m,
                downPayment: 1000.00m,
                rebateAndIncentive: 500.00m,
                excludeTaxes: false,
                registrationFee: 71.00m,
                apr: 0.045m,
                term: 36,
                frequency: 12,
                tradeInValue: 15909.00m,
                tradeInOwing: 1000.00m);

            Assert.Equal(14909.00m, paymentDetails.EstimatedNetTradeInValue,1);
            Assert.Equal(11122.00m, paymentDetails.NetSellingPrice, 1);
            Assert.Equal(1668.30m, paymentDetails.Taxes,1);
            Assert.Equal(367.71m, paymentDetails.TotalEstimatedPayment,1);
        }

        [Fact]
        public void TestPaymentDetailsForNissan()
        {
            var paymentDetails = new PaymentDetails(
                provinceCode: "ON-M2",
                sellingPrice: 37661.00m,
                downPayment: 0.00m,
                rebateAndIncentive: 1000.00m,
                excludeTaxes: false,
                registrationFee: 0.00m,
                apr: 0.029m,
                term: 60,
                frequency: 12,
                tradeInValue: 0.00m,
                tradeInOwing: 0.00m);
           
            Assert.Equal(0.00m, paymentDetails.EstimatedNetTradeInValue,1);
            Assert.Equal(37661.00m, paymentDetails.NetSellingPrice,1);
            Assert.Equal(4895.93m, paymentDetails.Taxes,1);
            Assert.Equal(744.88m, paymentDetails.TotalEstimatedPayment,1);
        }
    }
}
