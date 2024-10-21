using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_E7_Clases
{
    public class Banco
    {
        private List<Cliente> clientes;

        public Banco(List<Cliente> clientes)
        {
            this.clientes = clientes;
        }

        public void Operar()
        {
            Console.WriteLine("Introduce el DNI del cliente:");
            string dni = Console.ReadLine();

            Cliente cliente = clientes.FirstOrDefault(c => c.DNI == dni);

            if(cliente == null) 
                return;

            Console.WriteLine("Las operacion posibles son (1: Ingresar, 2: Extraer), introduce el numero de la operacion");
            int opcion = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la cantidad:");
            double cantidad = double.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                cliente.Ingresar(cantidad);
            }
            else if (opcion == 2)
            {
                cliente.Extraer(cantidad);
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }

            ConsultaSaldoTotal();
        }

        public void ConsultaSaldoTotal()
        {
            double saldo = clientes.Sum(c => c.CantidadAhorrada);
            Console.WriteLine($"El saldo de todas las cuentas es {saldo} euros.");
        }
    }
}
