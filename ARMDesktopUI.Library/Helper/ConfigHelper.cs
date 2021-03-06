﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMDesktopUI.Library.Helper
{
    public class ConfigHelper : IConfigHelper
    {
        public decimal GetTaxRate()
        {
            string rateText = ConfigurationManager.AppSettings["taxRate"];

            bool isValidRate = Decimal.TryParse(rateText, out decimal output);

            if (isValidRate == false)
            {
                throw new ConfigurationErrorsException("The Tax rate is not set up properly");
            }

            return output;
        }
    }
}
