using System.Globalization;

string[] vet1 = Console.ReadLine().Split(' ');
string[] vet2 = Console.ReadLine().Split(' ');

int codigo1 = int.Parse(vet1[0]);
int numero1 = int.Parse(vet1[1]);
double valorUnitario1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);
int codigo2 = int.Parse(vet2[0]);
int numero2 = int.Parse(vet2[1]);
double valorUnitario2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

double valorTotal = ((double) numero1 * valorUnitario1) + ((double) numero2 *  valorUnitario2);

Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
