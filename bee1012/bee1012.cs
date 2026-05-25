using System.Globalization;

string[] vet = Console.ReadLine().Split(' ');

double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
double C = double.Parse(vet[2], CultureInfo.InvariantCulture);
double pi = 3.14159;

double triangulo = A * (C / 2.0);
double circulo = Math.Pow(C, 2.0) * pi;
double trapezio = (A + B) * (C / 2.0);
double quadrado = Math.Pow(B, 2.0);
double retangulo = A * B;

Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));