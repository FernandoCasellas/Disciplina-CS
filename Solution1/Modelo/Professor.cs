using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Professor
    {

        
        private string nome;

        public string Nome
        {
            get { return nome; }

            set { nome = value; }

        }



        public int Matricula { get; set; }

        public string Disciplina { get; set; }

    }
}
