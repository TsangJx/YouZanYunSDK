using System;
using System.Collections.Generic;
using System.Text;

namespace YouZanYun.Infrastructure
{
    public class TimestampUtil
    {
        public static long ToTimestamp(DateTime dateTime)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)); // 当地时区
            TimeSpan ts = dateTime - startTime;
            return Convert.ToInt64(ts.TotalMilliseconds);
        }

        public static long ToTimestampForSecond(DateTime dateTime)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)); // 当地时区
            TimeSpan ts = dateTime - startTime;
            return Convert.ToInt64(ts.TotalSeconds);
        }
    }
}
