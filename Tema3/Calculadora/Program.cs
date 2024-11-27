namespace Calculadora
{

    /// <summary>
    /// Clase principal de la aplicación que implementa una calculadora interactiva.
    /// </summary>
    public class Program
    {

        /// <summary>
        /// Método principal de la aplicación.
        /// </summary>
        /// <param name="args">Argumentos de la línea de comandos.</param>
        static void Main(string[] args)
        {
            try
            {
                int vivo = 1;
                do
                {
                    Console.WriteLine("----- Calculadora -----");
                    Console.WriteLine("Seleccione una operación:");
                    Console.WriteLine("1. Sumar");
                    Console.WriteLine("2. Restar");
                    Console.WriteLine("3. Multiplicar");
                    Console.WriteLine("4. Dividir");
                    Console.Write("Opción: ");
                    int opcion = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el primer número: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese el segundo número: ");
                    double num2 = double.Parse(Console.ReadLine());

                    try
                    {
                        double resultado = opcion
                        switch
                        {
                            1 => Calculadora.Suma(num1, num2),
                            2 => Calculadora.Resta(num1, num2),
                            3 => Calculadora.Multiplicar(num1, num2),
                            4 => Calculadora.Dividir(num1, num2),
                            _ => throw new ArgumentException("Opción inválida."),
                        };
                        Console.WriteLine($"Resultado: {resultado}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }

                    Console.WriteLine("Si deseas salir pulse 0 y si deseas seguir 1");
                    vivo = int.Parse(Console.ReadLine());
                } while (vivo == 1);
            }
            catch(Exception e)
            {
                Console.WriteLine("Ha ocurrido un error");
            }
            
        }
    }

    
}
