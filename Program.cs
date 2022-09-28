using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasEstudiantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNotas = new int[5];
            String[] arrayNombres = new string[5];
            int totalNotas = 0;
            double notaPromedio = 0;
            int notaAlta = 0;
            int notasMenoresAlPromedio = 0;
            int notasMayoresAlPromedio = 0;

            for (int i = 0; i < arrayNotas.Length; i++)
            {
                Console.WriteLine("Digite el nombre del estudiante #" + (i+1));
                arrayNombres[i] = Console.ReadLine();
                
                Console.WriteLine("Digite la nota de " + arrayNombres[i]);
                arrayNotas[i] = int.Parse(Console.ReadLine());

                if (notaAlta < arrayNotas[i]) {notaAlta = arrayNotas[i];}

                totalNotas += arrayNotas[i];
            }
            notaPromedio = totalNotas / arrayNotas.Length;
            Console.WriteLine("El promedio de las notas es " + notaPromedio);
            Console.WriteLine("La nota más alta es " + notaAlta);

            for (int i = 0; i < arrayNotas.Length; i++)
            {
                if (arrayNotas[i] < notaPromedio) {notasMenoresAlPromedio++;}
            }

            notasMayoresAlPromedio = arrayNotas.Length - notasMenoresAlPromedio;
            Console.WriteLine("Las notas menores al promedio fueron " + notasMenoresAlPromedio);
            Console.WriteLine("Las notas mayores o iguales al promedio fueron " + notasMayoresAlPromedio);
            Console.ReadKey();
        }
    }
}