﻿using System;

namespace NonFactors.Mvc.Grid
{
    public class Int32Filter<T> : NumberFilter<T>
    {
        public override Object GetNumericValue()
        {
            Int32 number;
            if (Int32.TryParse(Value, out number))
                return number;

            return null;
        }
    }
}
