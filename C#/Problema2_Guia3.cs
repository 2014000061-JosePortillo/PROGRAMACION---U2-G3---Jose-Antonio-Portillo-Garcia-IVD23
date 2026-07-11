using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Problema2_Guia3
{
    class Problema2_Guia3
    {
        static string[,] vehiculos = new string[10, 3];
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1. Registrar Vehiculo");
                Console.WriteLine("2. Mostrar Vehicilos");
                Console.WriteLine("3. Actualizar Vehiculo");
                Console.WriteLine("4. Eliminar Vehiculo");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("=== REGISTRAR VEHICULO ===");
                        Registrar();
                        Pausa();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("=== MOSTRAR VEHICULOS ===");
                        MostrarE();
                        Pausa();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("=== ACTUALIZAR VEHICULO ===");
                        Actualizar();
                        Pausa();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("=== ELIMINAR VEHICULO ===");
                        Eliminar();
                        Pausa();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        Pausa();
                        break;
                }
            } while (opcion != 5);
        }
        // Método Registrar
        static void Registrar()
        {
            bool registrado = false;
            for (int i = 0; i < 3; i++)
            {
                if (string.IsNullOrEmpty(vehiculos[i, 0]))
                {
                    Console.Write("Numero de placa: ");
                    vehiculos[i, 0] = Console.ReadLine();
                    Console.Write("Nombre del propietario: ");
                    vehiculos[i, 1] = Console.ReadLine();
                    Console.Write("Marca del vehiculo: ");
                    vehiculos[i, 2] = Console.ReadLine();
                    Console.WriteLine("\nVehiculo registrado.");
                    registrado = true;
                    break;
                }
            }
            if (!registrado)
            {
                Console.WriteLine("\nLa matriz está llena.");
            }
        }
        // Método Mostrar
        static void MostrarE()
        {
            Console.WriteLine("\nPLACA\tNOMBRE DEL PROPIETARIO\t\tMARCA");
            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < 10; i++)
            {
                if (!string.IsNullOrEmpty(vehiculos[i, 0]))
                {
                    Console.WriteLine(
                    vehiculos[i, 0] + "\t" +
                    vehiculos[i, 1] + "\t\t" +
                    vehiculos[i, 2]);
                }
            }
        }
        // Método Actualizar
        static void Actualizar()
        {
            string codigo;
            bool encontrado = false;
            Console.Write("Placa a buscar: ");
            codigo = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                if (vehiculos[i, 0] == codigo)
                {
                    Console.Write("Nuevo propietario: ");
                    vehiculos[i, 1] = Console.ReadLine();
                    Console.Write("Nueva marca: ");
                    vehiculos[i, 2] = Console.ReadLine();
                    Console.WriteLine("\nRegistro actualizado.");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("\nCódigo no encontrado.");
            }
        }
        // Método Eliminar
        static void Eliminar()
        {
            string codigo;
            bool encontrado = false;
            Console.Write("Vehiculo a eliminar: ");
            codigo = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                if (vehiculos[i, 0] == codigo)
                {
                    vehiculos[i, 0] = "";
                    vehiculos[i, 1] = "";
                    vehiculos[i, 2] = "";
                    Console.WriteLine("\nRegistro eliminado.");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("\nCódigo no encontrado.");
            }
        }
        // Método Pausa
        static void Pausa()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}