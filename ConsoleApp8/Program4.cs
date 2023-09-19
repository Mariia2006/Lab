using System;
namespace Program 
{
  class Program {
    static void Main (string[] args) {
      double x = 0;
      x = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine(Math.Pow(2, x) * x * Math.Cos(x) + 1);
    }
  }
}
