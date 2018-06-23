using Modelo;
using System.Collections.Generic;

namespace Controllers
{
    public class ProfessoresController
    {

        
        List<Professor> tabelaProfessores = new List<Professor>();

        public void Inserir(Professor p)
        {

            tabelaProfessores.Add(p);

        }


        public List<Professor> ListarTodos()
        {

            return tabelaProfessores;

        }

    }
}
