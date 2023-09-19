using System;
namespace Program 
{
  class Program {
    static void Main (string[] args) {
      double x = 0;
      Console.WriteLine("Введiть х: ");
      x = Convert.ToDouble(Console.ReadLine());
      double s = Math.Pow(2, x) * x * Math.Cos(x) + 1;
      Console.WriteLine($"Обчислення 2^x*x*cos(x)+1: {s}");
    }
  }
}
