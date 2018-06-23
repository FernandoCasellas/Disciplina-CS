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

            Console.WriteLine("------------------Cadastro Aluno-----------------");
            Console.WriteLine("");
            Console.Write("Digite o nome do aluno: ");
            Console.WriteLine("");
            a.Nome = Console.ReadLine();

    
            Console.Write("Digite a Matricula do aluno: ");
            a.Matricula = int.Parse(Console.ReadLine());


           // Console.Write("Digite UMA DISCIPLINA do aluno: ");
            //a.Disciplina = Console.ReadLine();
            return a;
        }



        private static void ImprimeDadosAluno(Aluno a)
        {

            Console.WriteLine("----------------Dados Aluno------------------ " + a.Nome); // get
            Console.WriteLine("");
            Console.WriteLine("Aluno: " + a.Nome); // get

            Console.WriteLine("Matricula: " + a.Matricula); // get
            Console.WriteLine("");

            //Console.WriteLine("Disciplina: " + a.Disciplina); // get

//------------------------------------FIM CADASTRO ALUNO------------------------------------------

        }
//---------------------------------INICIO CADASTRO PROFESSOR---------------------------------------

        private static Professor CadastrarProfessor()
        {
            Professor p = new Professor();

            Console.WriteLine("----------------Dados Professor------------------ "); // get

            Console.Write("Digite o nome do Professor: ");
            p.Nome = Console.ReadLine();

            Console.Write("Digite a Matricula do Professor: ");
            p.Matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("");


            //    Console.Write("Digite UMA DISCIPLINA do Profesor: ");
            //   p.Disciplina = Console.ReadLine();
            return p;
        }



        private static void ImprimeDadosProfessor(Professor p)
        {


            Console.WriteLine("------------------IMPRESSÃO-------------------"); // get
            Console.WriteLine("");
            Console.WriteLine("Professor: " + p.Nome); // get

            Console.WriteLine("Matricula: " + p.Matricula); // get
            Console.WriteLine("");
            //Console.WriteLine("Disciplina: " + p.Disciplina); // get

        }

        //-----------------------------------FIM CADASTRO PROFESSOR-----------------------------------

        //-----------------------------------INICIO CADASTRO DISCIPLINAS-----------------------------

        private static Disciplina CadastrarDisciplina()
        {
            Disciplina d = new Disciplina();

            Console.WriteLine("----------------Cadastro Disciplina------------------ "); // get

            Console.Write("Digite o ID da Disciplina: ");
            d.id = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Digite o nome da Disciplina Cadastrada: ");
            d.Nome = Console.ReadLine();

            

            //    Console.Write("Digite UMA DISCIPLINA do Profesor: ");
            //   p.Disciplina = Console.ReadLine();
            return d;
        }



        private static void ImprimeDadosDisciplina(Disciplina d)
        {


            Console.WriteLine("------------------Dados Disciplina-------------------"); // get
            Console.WriteLine("");
            Console.WriteLine("ID Disciplina: " + d.id); // get

            Console.WriteLine("Disciplina: " + d.Nome); // get
            Console.WriteLine("");
            //Console.WriteLine("Disciplina: " + p.Disciplina); // get

        }


//--------------------------------FIM CADASTRO DISCIPLINAS-----------------------------


    }

    internal class AlunosControllers
    {
    }
}
