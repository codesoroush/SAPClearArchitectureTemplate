using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.ExtentionMethods
{
    public static class SAPConverters
    {

        public static string ToSAPFormat(this DateTime? value)
        {
            if (value.HasValue)
            {
                return $"last modify on : {value.Value.ToShortDateString()}  {value.Value.Hour}:{value.Value.Minute}";

            }
            return "";
        }
    }
}
