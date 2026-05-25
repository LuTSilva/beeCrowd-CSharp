using System.Globalization;
double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if(n1 < 0 || n1 > 100) {
    Console.WriteLine("Fora de intervalo");
} else if (n1 <= 25) {
    Console.WriteLine("Intervalo [0,25]");
} else if (n1 <= 50) {
    Console.WriteLine("Intervalo (25,50]");
} else if (n1 <= 75) {
    Console.WriteLine("Intervalo (50,75]");
} else {
    Console.WriteLine("Intervalo (75,100]");
}