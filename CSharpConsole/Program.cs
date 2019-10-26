﻿using System;
using ICI.FSharpLibrary;

namespace CSharpConsole {
    class Program {
        static void Main(string[] args) {
            var n = 3.5;
            var result = FMath.Twice<double, double>(n);
            Console.WriteLine($"Twice {n} = {result:N1}");
            var s = "Word";
            var sresult = FMath.Twice<string, string>(s);
            Console.WriteLine($"Twice {s} = {sresult}");
            Console.ReadKey();
        }
    }
}