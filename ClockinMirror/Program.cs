using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockinMirror
{
    class Program
    {
        public static string WhatIsTheTime(string timeInMirror)
        {
            int hour = int.Parse(timeInMirror.Substring(0, 2));
            int min = int.Parse(timeInMirror.Substring(3));
            var mirTimeSpan = CountMirTimeSpan(hour, min);
            return $"{mirTimeSpan:hh\\:mm}";
        }

        private static TimeSpan CountMirTimeSpan(int hour, int min)
        {
            TimeSpan mirTimeSpan;
            if (hour >= 11)
            {
                mirTimeSpan = new TimeSpan(23, 60, 00) - new TimeSpan(hour, min, 00);
            }
            else
            {
                mirTimeSpan = new TimeSpan(11, 60, 00) - new TimeSpan(hour, min, 00);
            }
            return mirTimeSpan;
        }
    }
}
