using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class zabiljeskaSVremenom:zabiljeska
    {
        public DateTime vrijeme { get; set; }
        public zabiljeskaSVremenom()
        {
            this.vrijeme = DateTime.Now;
        }

        public zabiljeskaSVremenom(string tekst, string autor, int vaznost, DateTime vrijeme) : base(tekst, autor, vaznost)
        {
            this.vrijeme = vrijeme;
        }
        public override string ToString()
        {
            return base.ToString() + ", vrijeme: " + this.vrijeme;
        }


    }
}
