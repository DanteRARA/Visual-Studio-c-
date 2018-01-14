using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            int[,] test = new int[15, 15];
            int count = 1;
            string ss = "";
            for (int i = 0; i < 15; i++) {
                for(int j = 0; j < 15; j++) {
                    test[i, j] = count++;
                    ss += test[i, j] + "\t";
                }
                ss += "\n";
            }

            Console.Write(ss);
            Console.ReadLine();
        }
    }
}
