﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3 {
    class Program {
        static void Main(string[] args) {
            var sales = new SalesCalculator("Sales.csv");

            var amountPerCategory = sales.GetPerCategorySales();
            foreach (var obj in amountPerCategory) {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }
        }
    }
}