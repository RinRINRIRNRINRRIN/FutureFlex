﻿using System.Configuration;
namespace FutureFlex.Function
{
    internal class func_serialport
    {

        public static string COM_SCALE
        {
            get { return ConfigurationManager.AppSettings["WGH_COM"]; }
        }
        public static int BAUDRATE_SCALE
        {
            get { return int.Parse(ConfigurationManager.AppSettings["WGH_BAUDRATE"]); }
        }
    }
}
