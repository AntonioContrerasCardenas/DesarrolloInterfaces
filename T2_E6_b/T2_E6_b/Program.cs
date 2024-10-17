// See https://aka.ms/new-console-template for more information


using static Program;

internal class Program
{
    private static void Main(string[] args)
    {
        var Libros = new List<Libro>()
            {
                new Libro{Titulo= "Don Quijote de la Mancha", IDAutor= 1, FechaPublicacion= 1605,
                Ventas= 500},
                new Libro{Titulo="Historia de dos ciudades", IDAutor=2, FechaPublicacion=1859,
                Ventas=200},
                new Libro{Titulo="El Señor de los Anillos", IDAutor=3,
                FechaPublicacion=1978,Ventas= 150},
                new Libro{Titulo="El principito", IDAutor=4, FechaPublicacion=1951, Ventas=140},
                new Libro{Titulo="El hobbit", IDAutor=3, FechaPublicacion=1982, Ventas=100},
                new Libro{Titulo="Sueño en el pabellón rojo", IDAutor=5, FechaPublicacion=1792,
                Ventas=100},
                new Libro{Titulo="Las aventuras de Alicia en el país de las maravillas", IDAutor=6,
                FechaPublicacion=1865, Ventas=100},
                new Libro{Titulo="Diez negritos", IDAutor=7, FechaPublicacion=1939, Ventas=100},
                new Libro{Titulo="El león, la bruja y el armario", IDAutor=8, FechaPublicacion=1950,
                Ventas=85},
                new Libro{Titulo="El código Da Vinci", IDAutor=9, FechaPublicacion=2003,
                Ventas=80},
                new Libro{Titulo="El guardián entre el centeno", IDAutor=10,
                FechaPublicacion=1951, Ventas=65},
                new Libro{Titulo="El alquimista", IDAutor=11, FechaPublicacion=1988, Ventas=65},
            };


        var Autores = new List<Autor>()
            {
                new Autor{IDAutor= 1, Nombre= "Miguel de Cervantes"},
                new Autor{IDAutor=2, Nombre= "Charles Dickens"},
                new Autor{IDAutor=3, Nombre= "J. R. R. Tolkien"},
                new Autor{IDAutor=4, Nombre= "Antoine de Saint-Exupéry"},
                new Autor{IDAutor=5, Nombre= "Cao Xueqin"},
                new Autor{IDAutor=6, Nombre= "Lewis Car"},
                new Autor{IDAutor=7, Nombre= "Agatha Christie"},
                new Autor{IDAutor=8, Nombre= "C. S. Lewis"},
                new Autor{IDAutor=9, Nombre= "Dan Brown"},
                new Autor{IDAutor=10, Nombre= "J. D. Salinger"},
            };

        MostrarLibrosMasVendidos(Libros);
        MostrarLibrosMenosVendidos(Libros);
        MostrarNombresAutores(Autores);
        MostrarLibrosAgrupadosAutor(Libros, Autores);
        MostrarLibrosMenor50Anios(Libros);
        MostrarLibroMasViejo(Libros);
        MostrarLibrosComiencenEl(Libros);
    }

    private static void MostrarLibrosComiencenEl(List<Libro> libros)
    {
        var librosComienzoEl = libros.Where(l => l.Titulo.StartsWith("El"));

        Console.WriteLine("Los libros que comienzan con El son");
        foreach (var item in librosComienzoEl)
        {
            Console.WriteLine(item.Titulo);
        }
        Console.WriteLine();
    }

    private static void MostrarLibroMasViejo(List<Libro> libros)
    {
        var librosMasViejo = libros.OrderBy(l => l.FechaPublicacion).FirstOrDefault();
        Console.WriteLine("Libro mas viejo");
        Console.WriteLine(librosMasViejo != null ? librosMasViejo.Titulo : "Error");
        Console.WriteLine();
    }

    private static void MostrarLibrosMenor50Anios(List<Libro> libros)
    {
        int anioActual = DateTime.Now.Year;
        var librosRecientes = libros.Where(l => anioActual - l.FechaPublicacion < 50);

        Console.WriteLine("Los libros con menos de 50 años son");
        foreach (var libro in librosRecientes)
        {
            Console.WriteLine(libro.Titulo);
        }
        Console.WriteLine();
    }

    private static void MostrarLibrosAgrupadosAutor(List<Libro> libros, List<Autor> autores)
    {
        var librosPorAutor = libros.GroupBy(l => l.IDAutor);
        Console.WriteLine("Libros agrupados por autores");          
        foreach (var grupo in librosPorAutor)
        {
            //var nombreAutor = autores.Where(a => a.IDAutor.Equals(item.Key)).Select(item => item.Nombre).FirstOrDefault();
            string autor = autores.FirstOrDefault(a => a.IDAutor == grupo.Key)?.Nombre ?? "Autor desconocido";
            Console.WriteLine($"Autor: {autor}");
            foreach (var libro in grupo)
            {
                Console.WriteLine($"--Libro: {libro.Titulo}");
            }
        }
        Console.WriteLine();
    }

    private static void MostrarNombresAutores(List<Autor> autores)
    {
        var autoresCaracteres = autores.Where(l => l.Nombre.Replace(" ", String.Empty).Length<10);
        Console.WriteLine("Los autores cuyos nombres tienen menos de 10 caracteres");
        foreach (var autor in autoresCaracteres)
        {
            Console.WriteLine($"Codigo: {autor.IDAutor}, Nombre: {autor.Nombre}");
        }
        Console.WriteLine();
    }

    private static void MostrarLibrosMenosVendidos(List<Libro> libros)
    {
        var librosMenosVendidos = libros.OrderBy(l => l.Ventas).Take(3);
        Console.WriteLine("Los 3 libros menos vendidos son");
        foreach (var item in librosMenosVendidos)
        {
            Console.WriteLine(item.Titulo);
        }
        Console.WriteLine();
    }

    private static void MostrarLibrosMasVendidos(List<Libro> libros)
    {
        var librosMasVendidos = libros.OrderByDescending(l => l.Ventas).Take(3);
        Console.WriteLine("Los 3 libros mas vendidos son");
        foreach (var item in librosMasVendidos)
        {
            Console.WriteLine(item.Titulo);
        }
        Console.WriteLine();
    }
    public class Libro
    {
        public string Titulo { get; set; }
        public int IDAutor { get; set; }
        public int FechaPublicacion { get; set; } // Year
        public int Ventas { get; set; } //Millions
    }
    public class Autor
    {
        public int IDAutor { get; set; }
        public string Nombre { get; set; }
    }
}
