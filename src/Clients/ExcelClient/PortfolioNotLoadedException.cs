﻿//  Copyright (c) RXD Solutions. All rights reserved.
//  FusionLink is licensed under the MIT license. See LICENSE.txt for details.

using System;

namespace RxdSolutions.FusionLink.ExcelClient
{

    [Serializable]
    public class PortfolioNotLoadedException : Exception
    {
        public PortfolioNotLoadedException() { }

        public PortfolioNotLoadedException(string message) : base(message) { }

        public PortfolioNotLoadedException(string message, Exception inner) : base(message, inner) { }

        protected PortfolioNotLoadedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}