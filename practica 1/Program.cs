using System;

namespace ArreglosUnidimensionalesDias
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arreglo = new string[7] { "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };
            int numeros = dias(arreglo);

            Console.Write($"El número corresponde al día: ");
            Console.WriteLine(arreglo[numeros - 1]);

        }
        static int dias(string[] arreglo)
        {
            try
            {
                Console.Clear();
                Console.Write($"seleccionar un número correspondiente al día de la semana: \n");
                for (int i = 0; i < arreglo.Length; i++)
                { Console.WriteLine($"{i + 1}.-{arreglo[i]}"); }

                int numeros = Int32.Parse(Console.ReadLine());

                return (numeros >= 1 && numeros <= 7) ? numeros : dias(arreglo);

            }

            catch
            {

                return dias(arreglo);

            }



        }
    }
}