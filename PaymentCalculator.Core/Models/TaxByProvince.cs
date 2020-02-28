namespace PaymentCalculator.Core.Models
{
    public class TaxByProvince
    {
        public int Id { get; set; }
        public string ProvinceName { get; set; }
        public string ProvinceCode { get; set; }
        public decimal PST { get; set; }
        public decimal GST { get; set; }
        public decimal TaxOnInsurance { get; set; }
        public decimal TotalTax => PST + GST + TaxOnInsurance;
    }
}
