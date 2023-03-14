using System;
using System.Collections.Generic;
using System.Text;

namespace classi_oggetti140323.classi
{
    internal class Prodotto
    {
        private string nome;
        public string Nome
        { 
            get
            {
                return this.nome;
            }
            set
            {
                
                if(value !=null && value.Length>=5)
                {
                    this.nome = value;
                }
                else
                {
                    Console.WriteLine("nome deve aver almeno una lunghezza di 5");
                }
                
            }
        }
        public int Costo { get; set; }
    }
}
