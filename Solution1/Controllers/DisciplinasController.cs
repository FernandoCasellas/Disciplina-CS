using Modelo;
using System.Collections.Generic;

namespace Controllers
{
    public class DisciplinasController
    {

        List<Disciplina> tabelaDisciplinas = new List<Disciplina>();

        public void Inserir(Disciplina d)
        {

            tabelaDisciplinas.Add(d);

        }


        public List<Disciplina> ListarTodos()
        {

            return tabelaDisciplinas;

        }

    }
}
