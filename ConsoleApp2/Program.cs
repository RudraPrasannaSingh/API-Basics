using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine($"Constant returned was:{TestConst()}");
         Console.ReadLine();
      }
      static string TestConst()
      {
         const string solved = "This is a viable solution!";
         return solved;
      }
   }
}
