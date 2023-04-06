/*

    BONUS: Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile, ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via. A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente. Rieseguire il programma con l’input preso esternamente dall’utente.
 */




using System.Reflection.Metadata;
using System;

namespace csharp_functions
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Inserisci il numero di elementi che vuoi aggiungere: ");
            int numeroElementi;
            while (!int.TryParse(Console.ReadLine(), out numeroElementi) || numeroElementi <= 0)
            {
                Console.Write("Inserisci un numero intero valido maggiore di zero: ");
            }

            int[] numeri = new int[numeroElementi];

            for (int i = 0; i < numeroElementi; i++)
            {
                Console.Write($"Inserisci il numero per l'elemento {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numeri[i]))
                {
                    Console.Write($"Inserisci un numero intero valido per l'elemento {i + 1}: ");
                }
            }

            int[] quadrati = ElevaArrayAlQuadrato(numeri);

            Console.WriteLine($"Array iniziale: [{string.Join(", ", numeri)}]");
            Console.WriteLine($"Array con numeri al quadrato: [{string.Join(", ", quadrati)}]");
            Console.WriteLine($"Array iniziale non modificato: [{string.Join(", ", numeri)}]");

            int sommaIniziale = SommaElementiArray(numeri);
            int sommaQuadrati = SommaElementiArray(quadrati);
            Console.WriteLine($"La somma degli elementi dell'array iniziale è: {sommaIniziale}");
            Console.WriteLine($"La somma dei quadrati degli elementi inseriti è: {sommaQuadrati}");




            //int[] numeri = { 2, 6, 7, 5, 3, 9 };
            //StampaArray(numeri);
            //Console.WriteLine();

            ////Console.WriteLine(Quadrato(8));

            //int[] quadrati = ElevaArrayAlQuadrato(numeri);
            //Console.WriteLine(string.Join(", ", quadrati));

            //Console.WriteLine(SommaElementiArray(numeri));

            //Console.WriteLine(SommaElementiArray(quadrati));
        }

        static void StampaArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");    
        }

        static int Quadrato(int numero)
        {
            int quadrato = numero * numero;
            return quadrato;
        }

        static int[] ElevaArrayAlQuadrato(int[] array)
        {
            int[] quadrati = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                quadrati[i] = array[i] * array[i];
            }
            return quadrati;
        }

        static int SommaElementiArray(int[] array)
        {
            int somma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                somma += array[i];
            }
            return somma;
        }

    }
}