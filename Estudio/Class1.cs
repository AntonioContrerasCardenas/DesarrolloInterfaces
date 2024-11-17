using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    internal class Class1
    {
    }

    public interface ICaminable
    {
        void Caminar();
    }

    public interface IVolable
    {
        void Volar();
    }

    public interface INadable
    {
        void Nadar();
        void Apagar()
        {
            Console.WriteLine("Apagado en proceso...");
        }
    }

    public abstract class Animal
    {
        public string Nombre { get; set; }

        // Constructor para inicializar el nombre del animal
        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        // Método abstracto: cada animal hace un sonido diferente
        public virtual void HacerSonido() { }

        // Método concreto que todos los animales pueden compartir
        public void Comer()
        {
            Console.WriteLine($"{Nombre} está comiendo.");
        }
    }

    // Clase Perro que hereda de Animal e implementa ICaminable
    public class Perro : Animal, ICaminable
    {
        public Perro(string nombre) : base(nombre) { }

        public override void HacerSonido()
        {
            
        }

        public void Caminar()
        {
            Console.WriteLine($"{Nombre} está caminando.");
        }
    }

    public class Pato : Animal, ICaminable, IVolable, INadable
    {
        public Pato(string nombre) : base(nombre) { }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} dice: ¡Cuac cuac!");
        }

        public void Caminar()
        {
            Console.WriteLine($"{Nombre} está caminando.");
        }

        public void Volar()
        {
            Console.WriteLine($"{Nombre} está volando.");
        }

        public void Nadar()
        {
            Console.WriteLine($"{Nombre} está nadando.");
        }

    }

    public class Pez : Animal, INadable
    {
        public Pez(string nombre) : base(nombre) { }

        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} no hace sonidos audibles.");
        }

        public void Nadar()
        {
            Console.WriteLine($"{Nombre} está nadando.");
        }

    }

    public abstract class Ordenador
    {
        protected int numero;
        public abstract void Leer();
        public virtual void Escribo()
        {
            Console.WriteLine("Hola");
        }

        public Ordenador(int hola)
        {
            Console.WriteLine("Construcción Ordenador");
        }
    }
    public class Mac : Ordenador
    {
        public Mac() : base(200)
        {
            Console.WriteLine("Construcción Mac");
        }

        public override void Leer()
        {
            throw new NotImplementedException();
        }

        public override void Escribo()
        {
            base.Escribo();
        }
    }

}
