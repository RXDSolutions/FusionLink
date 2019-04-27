﻿//  Copyright (c) RXD Solutions. All rights reserved.
//  FusionLink is licensed under the MIT license. See LICENSE.txt for details.

using System.Collections.Generic;
using DevExpress.XtraTreeList.Columns;

namespace Sophis.Util.GUI
{
    public class CustomTreeList
    {
        public TreeListColumn FocusedColumn { get; set; }

        public IEnumerable<TreeListColumn> Columns { get; set; }
    }
}