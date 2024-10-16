// See https://aka.ms/new-console-template for more information
var listaNumeros = Enumerable.Range(1, 100);

var listaDivisibles = listaNumeros.Where(x => x%7==0).GroupBy(x => x % 2 == 0 ? "Par" : "Impar");

foreach (var grupo in listaDivisibles)
{
    foreach (var numero in grupo)
    {
        Console.WriteLine($"{grupo.Key}: {numero}");
    }
}