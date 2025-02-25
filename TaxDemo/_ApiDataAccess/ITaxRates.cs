﻿///////////////////////////////////////////////////////////////////////////////////////////////
// Author: Patrick Gourdet Reinhard
// License: Iron Financials LLC All Rights Reserved
// Email: patrick.g.reinhard@ironfinancials.com
// Date: 09/11/2020
///////////////////////////////////////////////////////////////////////////////////////////////
using System.Threading.Tasks;
using TaxDemo.Model;

namespace TaxDemo.ApiDataAccess
{
    /// <summary>
    /// Access to base tax-rates for any order this can be expanded to
    /// separate different tax brackets international or by region 
    /// </summary>
    public interface ITaxRates : ITax<RatesRate>
    {
        /// <summary>
        /// Interface for all tax rate endpoints
        /// </summary>
        /// <param name="query"></param>
        /// <param name="apiName"></param>
        /// <param name="userHash"></param>
        /// <returns></returns>
        Task<RatesRate> GetOrderTaxRate(string query,string apiName,byte[] userHash);
    }
}