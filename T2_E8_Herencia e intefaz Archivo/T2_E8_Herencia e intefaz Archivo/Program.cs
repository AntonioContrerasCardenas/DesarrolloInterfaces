// See https://aka.ms/new-console-template for more information
using T2_E8_Herencia_e_intefaz_Archivo.Ej1;
using T2_E8_Herencia_e_intefaz_Archivo.Ej2;
using T2_E8_Herencia_e_intefaz_Archivo.Ej3;


//Ejercicio1
Console.WriteLine("Ejercicio 1");
Empleado empleado = new("Rafa");
Console.WriteLine(empleado.ToString());

Directivo directivo = new("Mario");
Console.WriteLine(directivo.ToString());

Operario operario = new("Alfonso");
Console.WriteLine(operario.ToString());

Oficial oficial = new("Luis");
Console.WriteLine(oficial.ToString());

Tecnico Tecnico = new("Pablo");
Console.WriteLine(Tecnico.ToString());

Console.WriteLine();

//Ejercicio 2
Console.WriteLine("Ejercicio 2");
Electrodomestico[] electrodomesticos = new Electrodomestico[10];
electrodomesticos[0] = new Lavadora(200, 500);
electrodomesticos[1] = new Television(700, 20);
electrodomesticos[2] = new Lavadora();
electrodomesticos[3] = new Television();
electrodomesticos[4] = new Lavadora(31, 90, Colores.azul, Consumo.A, 90);
electrodomesticos[5] = new Television(40, true, 80, Colores.blanco, Consumo.D, 90);
electrodomesticos[6] = new Lavadora(78, 20, Colores.negro, Consumo.F, 190);
electrodomesticos[7] = new Television(10, false, 20, Colores.rojo, Consumo.C, 120);
electrodomesticos[8] = new Lavadora();
electrodomesticos[9] = new Television();

double totalLavadoras = 0;
double totalTelevisiones = 0;

foreach (var electrodomestico in electrodomesticos)
{
    double precio = electrodomestico.PrecioFinal();

    if (electrodomestico is Lavadora)
    {
        totalLavadoras += precio;
    }

    if (electrodomestico is Television)
    {
        totalTelevisiones += precio;
    }
}

Console.WriteLine($"El precio total de las valadoras es {totalLavadoras} euros");
Console.WriteLine($"El precio total de las televisiones es {totalTelevisiones} euros");
Console.WriteLine($"El precio total de los electrodomesticos es {totalTelevisiones + totalLavadoras} euros");

Console.WriteLine();

//Ejercicio 3
Console.WriteLine("Ejercicio 3");
Serie[] series = new Serie[5];
Videojuego[] videojuegos = new Videojuego[5];

series[0] = new Serie();
series[1] = new Serie("Serie 1", "Antonio");
series[2] = new Serie("Serie 2", "Jose");
series[3] = new Serie("Serie 3", 2, "Carla", "Terror");
series[4] = new Serie("Serie 4", 5, "Carlota", "Ficcion");

videojuegos[0] = new Videojuego();
videojuegos[1] = new Videojuego();
videojuegos[2] = new Videojuego("Juego 1", 12);
videojuegos[3] = new Videojuego("Juego 2", 40);
videojuegos[4] = new Videojuego("Juego 3", 100, "Ficcion" , "Compania Antonio");

series[0].entregar();
series[3].entregar();
videojuegos[1].entregar();
videojuegos[3].entregar();

int seriesEntragadas = 0;
int videojuegosEntragadas = 0;

foreach (Videojuego videojuego in videojuegos)
{
    if (videojuego.isEntregado())
    {
        videojuegosEntragadas++;
        videojuego.devolver();
    }
}

foreach (Serie serie in series)
{
    if (serie.isEntregado())
    {
        seriesEntragadas++;
        serie.devolver();
    }
}

Console.WriteLine($"El numero de series entregadas son: {seriesEntragadas}");
Console.WriteLine($"El numero de videojuegos entregados son: {videojuegosEntragadas}");

