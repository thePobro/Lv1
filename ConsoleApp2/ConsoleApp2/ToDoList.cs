using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class ToDoList
    {
        private List<zabiljeska> Zabiljeske;
        public ToDoList()
        {
            Zabiljeske = new List<zabiljeska>();
        }
        public void Dodaj(string tekst, string autor, int vaznost) {
            Zabiljeske.Add(new zabiljeska(tekst, autor, vaznost));
        }
        public zabiljeska Dohvati(String trazeniAutor)
        {
            foreach(zabiljeska element in Zabiljeske)
            {
                if (string.Equals(element.autor, trazeniAutor))
                    return element;
            }
            return null;
        }
        public void Ukloni()
        {
            int max = 0;
            if (Zabiljeske.Count == 0)
                return;
            else if (Zabiljeske.Count == 1)
                Zabiljeske.Clear();
            for (int i = 1; i < Zabiljeske.Count; i++)
                if (Zabiljeske[i].vaznost > Zabiljeske[max].vaznost)
                    max = i;
            Zabiljeske.RemoveAt(max);
        }
        public String ispis()
        {
            String zaIspis = "";
            foreach(zabiljeska element in Zabiljeske)
            {
                zaIspis += element.ToString() + "\n";
            }
            return zaIspis;
        }
       
    }
}
