
var listaNumeros = Enumerable.Range(1, 100);

var listaDivisiblesDividida = listaNumeros.Where(x => x % 7 == 0).GroupBy(x => x % 2 == 0 ? "Par" : "Impar");

foreach (var grupo in listaDivisiblesDividida)
{
    Console.WriteLine(grupo.Key);
    foreach (var numero in grupo)
    {
        Console.WriteLine($" - {numero}");
    }
}