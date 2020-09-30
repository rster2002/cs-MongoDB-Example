using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using MongoDB;

namespace TestConsole {
    class Program {
        static void Main(string[] args) {
            new MainView().Show();

            Console.WriteLine("hmm");
            Console.ReadKey();
        }
    }
}
