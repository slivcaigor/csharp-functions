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
            // converto l'input utente in numero intero con "int.TryParse" e assegno il valore convertito alla variabile "numeroElementi" usando l'operatore "out"
            // se l'utente inserisce una stringa vuota o non valida, "int.TryParse" restituisce "false" e quindi viene valutata la seconda condizione in cui il valore di "numeroElementi" deve essere minore o uguale a 0 per essere vera
            while (!int.TryParse(Console.ReadLine(), out numeroElementi) || numeroElementi <= 0)
            {
                Console.Write("Inserisci un numero intero valido maggiore di zero: ");
            }

            // creo nuovo array con lunghezza pari al valore inserito dall'utente
            int[] numeri = new int[numeroElementi];

            // ciclo che prende l'input dell'utente per ogni elemento dell'array numeri
            for (int i = 0; i < numeroElementi; i++)
            {
                Console.Write($"Inserisci il numero per l'elemento {i + 1}: ");
                // utilizzo "int.TryParse" per convertire in numero intero il valore inserito dall'utente e lo assegno all'elemento corrispondente dell'array "numeri"
                while (!int.TryParse(Console.ReadLine(), out numeri[i]))
                {
                    Console.Write($"Inserisci un numero intero valido per l'elemento {i + 1}: ");
                }
            }

            int[] quadrati = ElevaArrayAlQuadrato(numeri);

            Console.WriteLine($"Array iniziale: [{string.Join(", ", numeri)}]");
            // uso "string.Join" per unire gli elementi dell'array separando con una virgola e uno spazio
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

        // prende come parametro un array di numeri interi
        static void StampaArray(int[] array)
        {
            Console.Write("[");

            // itero attraverso ogni elemento dell'array
            for (int i = 0; i < array.Length; i++)
            {
                // per ogni elemento dell'array stampo il suo valore
                Console.Write(array[i]);
                // verifico se e' l'ultimo elemento dell'array per stampare una virgola e spazio dopo ogni elemento
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");    
        }

        //  prende come parametro un numero intero e restituisce il suo quadrato 
        static int Quadrato(int numero)
        {
            // dichiaro una variabile "quadrato" di tipo intero e assegno il valore del parametro "numero" elevato al quadrato
            int quadrato = numero * numero;
            //restituisco il valore della variabile "quadrato" come risultato della funzione
            return quadrato;
        }

        // prende come parametro un array di numeri interi e restituisce un nuovo array contenente il quadrato di ogni elemento dell'array originale
        static int[] ElevaArrayAlQuadrato(int[] array)
        {
            // dichiaro un nuovo array "quadrati" che ha la dimensione uguale alla lunghezza dell'array originale
            int[] quadrati = new int[array.Length];

            // itero attraverso ogni elemento dell'array originale
            for (int i = 0; i < array.Length; i++)
            {
                // per ogni elemento calcolo il suo quadrato e lo assegno all'elemento corrispondente del array nuovo "quadrati"
                quadrati[i] = array[i] * array[i];
            }
            // restituisco l'array con i quadrati degli elementi
            return quadrati;
        }

        // prende come paramentro un array di interi e restituisce la somma di tutti gli elementi dell'array
        static int SommaElementiArray(int[] array)
        {
            // dichiaro e inizializzo la variabile "somma" a 0
            int somma = 0;
            // itero attraverso ogni elemento dell'array 
            for (int i = 0; i < array.Length; i++)
            {
                // per ogni elemento, il suo valore viene sommato al valore della variabile "somma"
                somma += array[i];
            }
            // faccio il return per restituire il valore della variabile somma
            return somma;
        }

    }
}