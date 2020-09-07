﻿using System;
using DataStructureCore.StackSamples;

namespace DataStructureConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var hanoiSamples = new HanoiSamples();
            hanoiSamples.Hanoi(3,"塔1","塔2","塔3");
        }
    }
}