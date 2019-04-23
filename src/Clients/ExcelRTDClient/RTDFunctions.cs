﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDna.Integration;

namespace RxdSolutions.FusionLink.RTDClient
{
    public static class RTDFunctions
    {
        [ExcelFunction(Name = "GETPOSITIONVALUE", Description = "Returns position cell value", Category = "FusionLink")]
        public static object GetPositionValue(int positionId, string column)
        {
            return ExcelAsyncUtil.Observe(nameof(GetPositionValue), new object[] { positionId, column }, () => new PositionValueExcelObservable(positionId, column, AddIn.Client));
        }

        [ExcelFunction(Name = "GETPORTFOLIOVALUE", Description = "Returns a portfolio cell value", Category = "FusionLink")]
        public static object GetPortfolioValue(int portfolioId, string column)
        {
            return ExcelAsyncUtil.Observe(nameof(GetPortfolioValue), new object[] { portfolioId, column }, () => new PortfolioValueExcelObservable(portfolioId, column, AddIn.Client));
        }

        [ExcelFunction(Name = "GETPORTFOLIODATE", Description = "Returns the Portfolio Date of FusionInvest", Category = "FusionLink")]
        public static object GetPortfolioDate()
        {
            return ExcelAsyncUtil.Observe(nameof(GetPortfolioDate), null, () => new SystemPropertyExcelObservable(Interface.SystemProperty.PortfolioDate, AddIn.Client));
        }
    }
}
