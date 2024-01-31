using System;

namespace programmaTipoTriangolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valore;

            do
            {
                Console.WriteLine("Inserisci 1 per visualizzare triangolo, inserisci 2 per visualizzare quadrato");

                valore = Convert.ToInt32(Console.ReadLine());

                if (valore == 1)

                {


                    Console.WriteLine("inserisci valore del primo lato del triangolo");
                    int lato1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n");

                    Console.WriteLine("inserisci valore del secondo lato del triangolo");
                    int lato2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n");

                    Console.WriteLine("inserisci valore del terzo lato del triangolo");
                    int lato3 = Convert.ToInt32(Console.ReadLine());


                    Triangolo triangoloTest = new Triangolo(lato1, lato2, lato3);
                    Console.WriteLine(triangoloTest.CheckTipoTriangolo());
                    Console.WriteLine(triangoloTest.latoPIulungo());


                    Console.WriteLine("\n");

                }
                else if (valore == 2)
                {


                    Console.WriteLine("\n");

                    Console.WriteLine("Inserisci lunghezza lato quadrato");
                    int latoQuadrato = Convert.ToInt16(Console.ReadLine());

                    Quadrato quadratino = new Quadrato(latoQuadrato);
                    Console.WriteLine($" la mia area è di  {quadratino.CheckMyArea()} mq^2 ");
                    Console.WriteLine($" il mio perimetro è di {quadratino.CheckMyPerimeter()} m ");

                }

                /* else if (valore = 1 || valore != 2)
                 {
                     Console.WriteLine("opzione non valida");
                 }
                 else { } */
            }
            while (valore == 1);










            Console.ReadLine();
        }
    }
}
