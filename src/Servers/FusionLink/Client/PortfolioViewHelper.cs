﻿//  Copyright (c) RXD Solutions. All rights reserved.


using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTreeList.Columns;
using Sophis.Data.Utils;
using Sophis.Portfolios;
using Sophis.Util.GUI.DevXpress;

namespace RxdSolutions.FusionLink.Client
{
    public static class PortfolioViewHelper
    {
        public static string GetSelectedColumn()
        {
            var pv = GetPortfolioView();
            var column = pv.TreeList.FocusedColumn;
            return column?.Caption;
        }

        public static IEnumerable<string> GetDisplayedColumns()
        {
            var pv = GetPortfolioView();
            var columns = pv.TreeList.Columns;
            return columns
                        .Cast<TreeListColumn>()
                        .Select(x => x.Caption)
                        .Where(x => !string.IsNullOrWhiteSpace(x));
        }

        private static PortfolioView GetPortfolioView()
        {
            var pv = NavigationManager.Instance.FocusedTreeView as PortfolioView;
            return pv;
        }
    }
}