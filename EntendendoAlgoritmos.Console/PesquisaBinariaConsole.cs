using EntendendoAlgoritmos.Core.Capitulo01;

int[] array = [1, 3, 5, 7, 8, 9, 10, 30, 50, 51];


Console.Write("Lista: ");
foreach (int item in array)
{
    Console.Write($"{item} ");
}

Console.WriteLine("\nQual numero quer realizar a busca binária? ");
int numero = int.Parse(Console.ReadLine());

int? resultado = PesquisaBinaria.Buscar(array, numero);

if (resultado.HasValue)
{
    Console.WriteLine($"{numero} foi encontrado na posição {resultado} do array");
}
else
{
    Console.WriteLine($"O array não contém {numero}");
}