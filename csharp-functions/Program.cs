﻿/*
    int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

   Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
    Stampare l’array di numeri fornito a video

    Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])

    Stampare la somma di tutti i numeri

    Stampare la somma di tutti i numeri elevati al quadrati

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
            int[] numeri = { 1, 2, 3, 4, 5, 6, 7, 8 };
            StampaArray(numeri);
            Console.WriteLine();

            Console.WriteLine(Quadrato(8));

            int[] quadrati = ElevaArrayAlQuadrato(numeri);
            Console.WriteLine(string.Join(", ", quadrati));

            Console.WriteLine(SommaElementiArray(numeri)); 
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