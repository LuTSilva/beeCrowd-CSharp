using System.Globalization;

double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double imposto = 0;
double resto = 0;
double valorTeto1 = 4500.00;
double valorTeto2 = 3000.00;
double valorTeto3 = 2000.00;
double impostoTeto1 = 0.28;
double impostoTeto2 = 0.18;
double impostoTeto3 = 0.08;

if (valor > valorTeto1) {
    resto = valor - valorTeto1;
    imposto += (resto * impostoTeto1);
    valor = valorTeto1;
    resto = 0;
} 
if (valor > valorTeto2) {
    resto = valor - valorTeto2;
    imposto += (resto * impostoTeto2);
    valor = valorTeto2;
    resto = 0;
}
if (valor > valorTeto3) {
    resto = valor - valorTeto3;
    imposto += (resto * impostoTeto3);
    valor = valorTeto3;
    resto = 0;
}

if (imposto > 0) {
    Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
} else {
    Console.WriteLine("Isento");
}