using System;
using System.Linq;

namespace PaymentCalculator.Core.Models
{
    public class PaymentDetails
    {
        public PaymentDetails(string provinceCode, decimal sellingPrice, decimal downPayment,
            decimal rebateAndIncentive, bool excludeTaxes, decimal registrationFee, decimal apr, int term,
            int frequency, decimal tradeInValue, decimal tradeInOwing)
        {
            ProvinceCode = provinceCode;
            SellingPrice = sellingPrice;
            DownPayment = downPayment;
            RebateAndIncentive = rebateAndIncentive;
            ExcludeTaxes = excludeTaxes;
            RegistrationFee = registrationFee;
            APR = apr;
            Term = term;
            TradeInValue = tradeInValue;
            TradeInOwing = tradeInOwing;
            Frequency = frequency;
        }

        public string ProvinceCode { get; set; }

        public decimal SellingPrice { get; set; }

        public decimal DownPayment { get; set; }

        public decimal RebateAndIncentive { get; }

        public decimal TradeInValue { get; set; }

        public decimal TradeInOwing { get; set; }  
        
        public decimal RegistrationFee { get; set; }

        public decimal APR { get; set; }

        public int Term { get; set; }

        public int Frequency { get; set; }

        public bool ExcludeTaxes { get; set; }
        
        public decimal ProtectionProducts { get; set; } = 0m;

        public decimal EstimatedNetTradeInValue => TradeInValue - TradeInOwing;

        public decimal NetSellingPrice => SellingPrice + ProtectionProducts - DownPayment - EstimatedNetTradeInValue;        
        
        public decimal TaxePercenage => Mock.Seed().First(p => p.ProvinceCode == ProvinceCode).TotalTax;

        public decimal Taxes => ExcludeTaxes ? 0 : Math.Ceiling(NetSellingPrice * TaxePercenage * 100) / 100;

        public decimal AmountFinanced => Math.Ceiling((NetSellingPrice - RebateAndIncentive + Taxes + RegistrationFee) * 100) / 100;

        public decimal TotalEstimatedPayment => (decimal)CalculatePMT();                   

        public virtual double CalculatePMT()
        {
            var rate = (double)APR / Frequency;           
            var result = (((double)AmountFinanced - 0) * rate / (1 - Math.Pow((1 + rate), -Term)));
            return Math.Ceiling(result * 100) / 100; ;
        }      
    }
}