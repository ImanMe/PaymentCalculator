using System.Collections.Generic;
using PaymentCalculator.Core.Models;

namespace PaymentCalculator.Core
{
    public class Mock
    {
        public static List<TaxByProvince> Seed()
        {
            var taxByAllProvinces = new List<TaxByProvince>()
            {
                new TaxByProvince{GST = 0.05m, PST = 0m, ProvinceCode = "AB-T2", ProvinceName = "Alberta"},
                new TaxByProvince { GST = 0.05m, PST = 0.07m, ProvinceCode = "BC-V2", ProvinceName = "British Columbia" },
                new TaxByProvince { GST = 0.05m, PST = 0.08m, ProvinceCode = "MB-R2", ProvinceName = "Manitoba" },
                new TaxByProvince { GST = 0.15m, PST = 0m, ProvinceCode = "NM-E2", ProvinceName = "New Brunswick" },
                new TaxByProvince { GST = 0.05m, PST = 0m, ProvinceCode = "NW-X2", ProvinceName = "NorthWest Territory" },
                new TaxByProvince { GST = 0.15m, PST = 0m, ProvinceCode = "NF-A2", ProvinceName = "NewFoundland" },
                new TaxByProvince { GST = 0.15m, PST = 0m, ProvinceCode = "NS-B2", ProvinceName = "Nova Scotia" },
                new TaxByProvince { GST = 0.05m, PST = 0m, ProvinceCode = "NU-x2", ProvinceName = "Nunavat" },
                new TaxByProvince { GST = 0.13m, PST = 0m, ProvinceCode = "ON-M2", ProvinceName = "Ontario" },
                new TaxByProvince { GST = 0.15m, PST = 0m, ProvinceCode = "PEI-C2", ProvinceName = "Prince Edward Island" },
                new TaxByProvince { GST = 0.05m, PST = 0.09975m, ProvinceCode = "QC-J2", ProvinceName = "Quebec" },
                new TaxByProvince { GST = 0.05m, PST = 0.06m, ProvinceCode = "SK-S2", ProvinceName = "Saskachewan" },
                new TaxByProvince { GST = 0.05m, PST = 0m, ProvinceCode = "YU-Y2", ProvinceName = "Yukon" }
            };

            return taxByAllProvinces;
        }
    }
}
