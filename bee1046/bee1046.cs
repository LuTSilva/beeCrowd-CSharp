string[] vet = Console.ReadLine().Split(' ');
int inicio = int.Parse(vet[0]);
int fim = int.Parse(vet[1]);

if(inicio >= fim) {
    fim += 24;
}

int duracao = fim - inicio;

if(duracao >= 1 || duracao >= 24) {
    Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
}