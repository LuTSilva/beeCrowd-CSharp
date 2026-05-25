using System.Globalization;
double pi = 3.14159;
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double area = pi * Math.Pow(raio, 2.0);

Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));