using Controllers;
using Modelo;
using Modelos;
using System;

namespace ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
//------------------------------Alunos-------------------------------------
            AlunosController alunosController = new AlunosController();
          
            Aluno a = CadastrarAluno();
            alunosController.Inserir(a);

            Aluno b = CadastrarAluno();
            alunosController.Inserir(b);

            Aluno c = CadastrarAluno();
            alunosController.Inserir(c);

            foreach (Aluno aluno in alunosController.ListarTodos())
            {

                Console.WriteLine("");
                ImprimeDadosAluno(aluno);
 
            }

//-----------------------------Professores---------------------------------

            ProfessoresController professoresController = new ProfessoresController();

            Professor x = CadastrarProfessor();
            professoresController.Inserir(x);

            Professor y = CadastrarProfessor();
            professoresController.Inserir(y);

            Professor z = CadastrarProfessor();
            professoresController.Inserir(z);

            foreach (Professor professor in professoresController.ListarTodos())
            {

                Console.WriteLine("");
                ImprimeDadosProfessor(professor);

            }



//------------------------------Disciplinas-------------------------------------
            DisciplinasController disciplinasController = new DisciplinasController();

            Disciplina d = CadastrarDisciplina();
            disciplinasController.Inserir(d);

            Disciplina e = CadastrarDisciplina();
            disciplinasController.Inserir(e);

            Disciplina f = CadastrarDisciplina();
            disciplinasController.Inserir(f);

            foreach (Disciplina disciplina in disciplinasController.ListarTodos())
            {

                Console.WriteLine("");
                ImprimeDadosDisciplina(disciplina);

            }


            Console.ReadKey();

        }

//--------------------------------------CADASTRO ALUNO----------------------------------------
        private static Aluno CadastrarAluno()
        {

            Aluno a = new Aluno();

            Console.WriteLine("------------------CADASTRO DADOS ALUNOS-----------------");
            Console.WriteLine("");
            Console.Write("Digite o nome do aluno: ");
           
            a.Nome = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Digite a Matricula do aluno: ");
            a.Matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            
            return a;
        }



        private static void ImprimeDadosAluno(Aluno a)
        {

            Console.WriteLine("----------------IMPRESSÃO DADOS ALUNO------------------ "); // get
            Console.WriteLine("");
            Console.WriteLine("Aluno: " + a.Nome); // get
            Console.WriteLine("");
            Console.WriteLine("Matricula: " + a.Matricula); // get
            Console.WriteLine("");


//------------------------------------FIM CADASTRO ALUNO------------------------------------------

        }
//---------------------------------INICIO CADASTRO PROFESSOR---------------------------------------

        private static Professor CadastrarProfessor()
        {
            Professor p = new Professor();
            Console.WriteLine("");
            Console.WriteLine("----------------CADASTRO DADOS PROFESSOR------------------ "); // get
            Console.WriteLine("");
            Console.Write("Digite o nome do Professor: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Digite a Matricula do Professor: ");
            p.Matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("");


            return p;
        }



        private static void ImprimeDadosProfessor(Professor p)
        {

            Console.WriteLine("");
            Console.WriteLine("------------------IMPRESSÃO CADASTRO PROFESSORES-------------------"); // get
            Console.WriteLine("");
            Console.WriteLine("Professor: " + p.Nome); // get
            Console.WriteLine("");
            Console.WriteLine("Matricula: " + p.Matricula); // get
            Console.WriteLine("");


        }

        //-----------------------------------FIM CADASTRO PROFESSOR-----------------------------------

        //-----------------------------------INICIO CADASTRO DISCIPLINAS-----------------------------

        private static Disciplina CadastrarDisciplina()
        {
            Disciplina d = new Disciplina();
            Console.WriteLine("");
            Console.WriteLine("----------------Cadastro das Disciplina------------------ "); // get
            Console.WriteLine("");
            Console.Write("Digite o ID da Disciplina: ");
            d.id = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Digite o nome da Disciplina Cadastrada: ");
            d.Nome = Console.ReadLine();

            
            return d;
        }



        private static void ImprimeDadosDisciplina(Disciplina d)
        {


            Console.WriteLine("------------------Imprime Dados Disciplina-------------------"); // get
            Console.WriteLine("");
            Console.WriteLine("ID Disciplina: " + d.id); // get
            Console.WriteLine("");
            Console.WriteLine("Disciplina: " + d.Nome); // get
            Console.WriteLine("");
            
        }


//--------------------------------FIM CADASTRO DISCIPLINAS-----------------------------


    }

    internal class AlunosControllers
    {
    }
}
