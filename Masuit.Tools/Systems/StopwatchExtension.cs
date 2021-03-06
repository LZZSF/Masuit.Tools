﻿using System;
using System.Diagnostics;

namespace Masuit.Tools.Systems
{
    public static class StopwatchExtension
    {
        public static double Execute(Action action)
        {
            Stopwatch sw = Stopwatch.StartNew();
            action();
            return sw.ElapsedMilliseconds;
        }
    }
}