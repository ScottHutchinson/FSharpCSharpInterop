using System;
using ICI.FSharpLibrary;

namespace CSharpConsole {
    class Program {
        static void Main(string[] args) {
            var n = 3.5;
            var result = FMath.Twice<double, double>(n);
            Console.WriteLine($"Twice {n} = {result:N1}");
            var s = "Word";
            var sresult = FMath.TwiceX(s);
            Console.WriteLine($"Twice {s} = {sresult}");

            var wilma = new FMath.RegisteredCustomer(id: "Wilma", isEligible: false);
            //wilma.IsEligible = true; // Error: property cannot be assigned to - it is read only.
            var lst = FMath.CustomerList; // <-- requires a reference to FSharp.Core assembly.
            Console.ReadKey();
        }
    }
}
