// See https://aka.ms/new-console-template for more information
using T2_E7_Clases;

Console.WriteLine("Primer ejercicio");
TrianguloIsosceles t = new TrianguloIsosceles(5, 6, 12);
Console.WriteLine($"El area del triangulos es {t.Area()}");
Console.WriteLine($"El perimetro del triangulos es {t.Perimetro()}");

List<Dado> list = new List<Dado>();
list.Add(new Dado());
list.Add(new Dado());
list.Add(new Dado());


Console.WriteLine("Segundo ejercicio");
Juego juego = new(list);
juego.Jugar();


Console.WriteLine("Tercer ejercicio");
List<Cliente> clientes = new List<Cliente>();
clientes.Add(new Cliente("12", "Antonio", 342));
clientes.Add(new Cliente("123", "Paco", 452));
clientes.Add(new Cliente("1234", "Jose", 23.54));

Banco banco = new Banco(clientes);
banco.Operar();


Console.WriteLine("Cuarto ejercicio");
Persona persona = new Persona("Antonio", 23);
persona.Imprimir();

Empleado empleado = new Empleado("Jose", 65, 200);
empleado.Imprimir();

Console.WriteLine($"El nombre de la persona es: {persona.nombre} y su edad {persona.edad}");
Console.WriteLine($"El sueldo del empleado es: {empleado.sueldo} euros, su nombre {empleado.nombre} y su edad es {empleado.edad} anios.");