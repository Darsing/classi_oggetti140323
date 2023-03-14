using System;
using System.Collections.Generic;
using System.Text;

namespace classi_oggetti140323.classi
{
    internal class User
    {
        //field
        private string name;
        //property servono per controllare accesso al field
        //public string lastName { get; set; }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

}
