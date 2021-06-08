using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {

        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-toi") {
                PrintMeterToInchList(1, 10);
            } else {
                PrintInchToMeterList(1, 10);
            }
        }

        //メールからフィートへの対応表を出力
        private static void PrintInchToMeterList(int start, int stop) {
            for(int feet = start;feet <= stop; feet++) { }

        }
        //フィートからメートルへの対応表を出力
        private static void PrintMeterToInchList(int start, int stop) {

        }
    }
}
