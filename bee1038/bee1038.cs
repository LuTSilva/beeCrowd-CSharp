using System.Globalization;

string[] vet = Console.ReadLine().Split(' ');
int codigo = int.Parse(vet[0]);
int quantidade = int.Parse(vet[1]);
double preco = 0.0;

if (codigo == 1) {
    preco = 4.00;
} else if (codigo == 2) {
    preco = 4.50;
} else if (codigo == 3) {
    preco = 5.00;
} else if (codigo == 4) {
    preco = 2.00;
} else if (codigo == 5) {
    preco = 1.50;
}

double valorTotal = (double) quantidade * preco;

Console.WriteLine("Total: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));