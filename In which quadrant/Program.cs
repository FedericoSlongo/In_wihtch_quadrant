using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_10
{
    class Program
    {
        struct posizione_punti
        {
            public int x;
            public int y;
        }
        static void Main(string[] args)
        {
            int utente_choice = 0, punteggio = 0;
            Random rnd = new Random();
            posizione_punti[] array = new posizione_punti[10];

            //Generazione numeri casuali
            for (int i = 0; i < 10; i++)
            {
                array[i].x = rnd.Next(-10, 11);
                array[i].y = rnd.Next(-10, 11);
            }

            for (int i = 0; i < 10; i++)
            {
                //Se è zero si sistema
                if (array[i].x == 0 || array[i].y == 0)
                {
                    array[i].x = rnd.Next(1, 11);
                    array[i].y = rnd.Next(1, 11);
                }
                Console.Write($"Were are the points {array[i].x} {array[i].y}: ");
                utente_choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                //Se corretto aggiunge punti
                if (funzione(in utente_choice, array[i]))
                    punteggio++;
            }
            Console.WriteLine($"You've done {punteggio} points");

            Console.ReadKey();
        }

        static bool funzione(in int utente_choice, posizione_punti array)
        {
            Random rnd = new Random();

            //Controllo se è nel primo quadrante e se l'utente è corretto
            if ((array.x > 0 && array.y > 0) && (utente_choice == 1))
                return true;

            //Controllo se è nel secondo quadrante e se l'utente è corretto
            if (array.x < 0 && array.y > 0 && utente_choice == 2)
                return true;

            //Controllo se è nel terzo quadrante e se l'utente è corretto
            if (array.x < 0 && array.y < 0 && utente_choice == 3)
                return true;

            //Controllo se è nel quarto quadrante e se l'utente è corretto
            if (array.x > 0 && array.y < 0 && utente_choice == 4)
                return true;

            return false;
        }
    }
}
