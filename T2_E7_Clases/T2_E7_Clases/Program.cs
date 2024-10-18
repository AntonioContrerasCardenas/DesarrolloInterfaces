// See https://aka.ms/new-console-template for more information
using T2_E7_Clases;

TrianguloIsosceles t = new TrianguloIsosceles(5, 6, 12);
Console.WriteLine($"El area del triangulos es {t.Area()}");
Console.WriteLine($"El perimetro del triangulos es {t.Perimetro()}");


List<Dado> list = new List<Dado>();
list.Add(new Dado());
list.Add(new Dado());
list.Add(new Dado());

Juego juego = new(list);
juego.Jugar();