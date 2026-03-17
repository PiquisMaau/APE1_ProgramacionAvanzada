using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeber_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- GESTOR DE PRODUCTOS DE INVENTARIO -----");
            Console.Write("Ingresa la capacidad máxima del inventario: ");

            int capMaxima = int.Parse(Console.ReadLine());
            Inventario inv1 = new Inventario(capMaxima);

            Console.WriteLine("--- Registro de Productos ---");

            for (int i = 0; i < capMaxima; i++)
            {
                Console.WriteLine($"Producto {i + 1} de {capMaxima}:");

                Producto nuevoProducto = new Producto();

                Console.Write("Ingresa el ID del producto (número): ");
                nuevoProducto.ID = int.Parse(Console.ReadLine());

                Console.Write("Ingresa el nombre del producto: ");
                nuevoProducto.Nombre = Console.ReadLine();

                Console.Write("Ingresa el stock disponible: ");
                nuevoProducto.Stock = int.Parse(Console.ReadLine());

                inv1.AgregarProducto(nuevoProducto);
                Console.WriteLine("¡Producto agregado!");
            }

            Console.WriteLine("\n----- BÚSQUEDA DE PRODUCTOS -----");
            Console.Write("Ingresa el ID del producto que deseas buscar: ");
            int idBuscado = int.Parse(Console.ReadLine());

            Producto productoEncontrado = inv1.BuscarPorID(idBuscado);

            if (productoEncontrado != null)
            {
                Console.WriteLine("Producto Encontrado!");
                Console.WriteLine($"ID: {productoEncontrado.ID} | Nombre: {productoEncontrado.Nombre} | Stock: {productoEncontrado.Stock}");
            }
            else
            {
                Console.WriteLine("product not found!");
            }
        }
    }
}
 
