double t = 0;
double v = 0;
Console.WriteLine("Введiть час (год): ");
t = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть швидкiсть (км/год): ");
v = Convert.ToDouble(Console.ReadLine());
double s = t * v;
Console.WriteLine($"Вiдстань дорiвнює (км): {s}");
Console.ReadKey();