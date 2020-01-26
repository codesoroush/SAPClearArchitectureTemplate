﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.ExtentionMethods
{
    public static class SAPGenerator
    {
        /// <summary>
        /// this method will generate random hex color  like "#A197B9"
        /// </summary>
        public static string GenerateHexColorCode => string.Format("#{0:X6}", new Random().Next(0x1000000));
    

    }
}
