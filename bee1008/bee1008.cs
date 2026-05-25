using System.Globalization;

int numero = int.Parse(Console.ReadLine());
int horas = int.Parse(Console.ReadLine());
double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double salario = (double) horas * valor;

Console.WriteLine("NUMBER = " + numero);
Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
