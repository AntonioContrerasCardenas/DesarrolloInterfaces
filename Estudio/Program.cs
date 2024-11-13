// See https://aka.ms/new-console-template for more information
using Estudio;
using System.Reflection.PortableExecutable;


Perro perro = new Perro("Bobby");
Pato pato = new Pato("Donald");
Pez pez = new Pez("Nemo");

// Llamar a los métodos de cada animal
perro.Comer();
perro.HacerSonido();
perro.Caminar();

Console.WriteLine();

pato.Comer();
pato.HacerSonido();
pato.Caminar();
pato.Volar();
pato.Nadar();

Console.WriteLine();

pez.Comer();
pez.HacerSonido();
pez.Nadar();