using System;
using System.Collections.Generic;
using System.Text;

namespace classi_oggetti140323
{
    internal class Animale
    {
        public string Razza { get; set; }   
        public int Eta { get; set; }
        private string colore;
        public string Colore 
        {
            get
            {
                return this.colore;
            }
            set
            {
                //solo bianco o nero
                if(value !=null && value.Contains("bianco") || value != null && value.Contains("nero"))
                {
                    this.colore = value;
                }
                else
                {
                    Console.WriteLine("il colore deve essere bianco o nero");
                }
                
            }
        }

    }
}
