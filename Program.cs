using System;
using System.Collections.Generic;
using classi_oggetti140323.classi;

namespace classi_oggetti140323
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //   User u= new User();
        //    u.Name = "text1";
        //    Console.WriteLine(u.Name);
        //    u.Name = "text2";
        //    Console.WriteLine(u.Name);
        //}

        //esercizio1
        /*
        - creare una classe Prodotto con le seguenti properties:
           - Nome
           - Costo
        - chiedere all'utente nome e costo di un prodotto e istanziarne
        un oggetto
        - fare in modo che si possano settare nomi solo di lunghezza
        maggiore di 5 caratteri
        - stampare su schermo i valori delle properties dell'oggetto
        istanziato
        */
        /*
        static void Main(string[] args)
        {
            
            Prodotto product= new Prodotto();
            //product.Nome = null;
            Console.WriteLine("Inserisci il nome del prodotto :");
            product.Nome=Console.ReadLine();
            Console.WriteLine("Inserisci il costo : ");
            product.Costo=int.Parse(Console.ReadLine());

            Console.WriteLine("Il prodotto selezionato è : " + product.Nome + "con un costo di "
                + product.Costo + "£");

        }
        */

        /*
         - creare una classe Animale con caratteristiche:
            - razza
            - eta
            - colore
         - generare un numero casuale tra 1 e 5
         - creare n oggetti di tipo Animale equivalenti al numero estratto
         - attribuire valori qualsiasi a ciascun animale, ma
            fare in modo che il colore possa essere solo "bianco" o "nero"
         */
        static void Main(string[] args)
        {
            Random random= new Random();
            int numero = random.Next(1,6);
            //Console.WriteLine("il numero :" + numero);

            List<Animale> listAni = new List<Animale>();
            for(int i=0;i<numero;i++)
            {
                Animale a= new Animale();
                a.Razza = "Gatto " + i;
                a.Eta = 1 +i;
                a.Colore = "bianco";
                listAni.Add(a);

            }

            for(int i=0;i<listAni.Count;i++)
            {
                Console.WriteLine("nome "+listAni[i].Razza + " eta "+ listAni[i].Eta+ " colore "+ listAni[i].Colore);
            }
        }
    }
}
