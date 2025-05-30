Console.WriteLine("Digite um número entre 0 e 10, para eu fazer a tabuada: ");
int numero = Convert.ToInt32(Console.ReadLine());
int multiplicador = 0;
// multiplicador começa no 0
int resultado;

while (multiplicador <= 10)
// exibe a tabuada até o multiplicador 10
{
    resultado = numero * multiplicador;
    Console.WriteLine($"{numero} x {multiplicador} = {resultado}");
    multiplicador += 1;
// cresce o multiplicador de 1 em 1
}
