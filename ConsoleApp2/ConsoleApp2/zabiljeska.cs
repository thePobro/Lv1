using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class zabiljeska
    {
        private String Tekst;
        private String Autor;
        private int Vaznost;
        public String tekst { get; set; }
        public String autor { get; private set; }
        public int vaznost { get; set; }
        public zabiljeska()
        {
            this.tekst = "bla bla bla";
            this.autor = "ja";
            this.vaznost = 0;
        }
        public zabiljeska(string tekst, string autor, int vaznost)
        {
            this.tekst = tekst;
            this.autor = autor;
            this.vaznost = vaznost;
        }
        public zabiljeska(string tekst, int vaznost)
        {
            this.tekst = tekst;
            this.autor = "ja";
            this.vaznost = vaznost;
        }
        public override string ToString()
        {
            return "autor: " + this.autor + ", tekst: " + this.tekst + ", vaznost: " + this.vaznost;
        }
    }
    
}
