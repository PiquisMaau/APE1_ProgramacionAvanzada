using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeber_9
{
    public class SombradelSol
    {
            public void CalcularSombra()
            {
                try
                {
                    Console.Write("Ingresa la hora (24h): ");
                    int hora = int.Parse(Console.ReadLine());

                    Console.Write("Ingresa los minutos: ");
                    int minutos = int.Parse(Console.ReadLine());

                    if (hora < 6 || hora > 18 || (hora == 18 && minutos > 0))
                    {
                        throw new Exception("No hay sol a esas horas :)");
                    }

                    int minutosTotales = ((hora - 6) * 60) + minutos;

                    double anguloElevacion = minutosTotales * 0.25;
                    Console.WriteLine($"El ángulo de elevación solar: {anguloElevacion}°");

                    if (anguloElevacion == 0 || anguloElevacion == 180)
                    {
                        Console.WriteLine("Sol perfectamente horizontado.");
                        return;
                    }

                    double radianes = anguloElevacion * (Math.PI / 180.0);
                    double alturaArbol = 20.0; 

                    double longitudSombra = alturaArbol / Math.Tan(radianes);

                    Console.WriteLine($"La sombra proyectada por el árbol es de: {Math.Round(Math.Abs(longitudSombra), 2)} metros.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingres valores numéricos!!!!!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error de rango!!: {ex.Message}");
                }
            }
        }
}
