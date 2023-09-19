using System;
namespace Program 
{
  class Program {
    static void Main (string[] args) {
      double x = 0;
      Console.WriteLine("Введiть х: ");
      x = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine($"Обчислення 2^x*x*cos(x)+1: {Math.Pow(2, x) * x * Math.Cos(x) + 1}");
    }
  }
}
