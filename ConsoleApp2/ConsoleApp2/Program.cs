using System;
using System.Collections.Generic;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<zabiljeska> Zabiljeske = new List<zabiljeska>();
            Zabiljeske.Add(new zabiljeska());
            Zabiljeske.Add(new zabiljeska("covid-19", "ti", 2));
            Zabiljeske.Add(new zabiljeska("karantena", 5));
            foreach (zabiljeska element in Zabiljeske) {
                Console.WriteLine(element.autor);
                Console.WriteLine(element.tekst);
            }
            Console.WriteLine(Zabiljeske[0].ToString());
            ToDoList mojaLista = new ToDoList();
            for (int i = 0; i < 3; i++)
            {
                mojaLista.Dodaj(Console.ReadLine(), Console.ReadLine(), Int32.Parse(Console.ReadLine()));
            }
            mojaLista.ispis();
            mojaLista.Ukloni();
            mojaLista.ispis();
        }
    }
}
