using System;

namespace Grados
{
    class Program
    {
        const int limInferior = -30;
        const int limSuperior = 100;
        const int incremento = 6;

        public static void Main(string[] args)
        {
            CGrados grados = new CGrados();
            int gradosCent = limInferior;
            float gradosfahr = 0;

            while (gradosCent <= limSuperior)
            {
                grados.AsignarCentigrados(gradosCent);
                gradosfahr = grados.ObtenerFahrenheit();
                Console.WriteLine("{0, 8:d} C {1, 8:f2} F", gradosCent, gradosfahr);
                gradosCent += incremento;
            }
            
            
        }
    }
}
