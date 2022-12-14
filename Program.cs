using ConsultarAPIControleSala.Consulta;
using System;

namespace ConsultarAPIControleSala
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultaAlunos Consulta1 = new ConsultaAlunos();

            Console.WriteLine("Consulta de Alunos");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Digite o nome do Aluno que deseja buscar:");
            Console.WriteLine("-----------------------------------------");
            string NomeAluno = Console.ReadLine();

            string Resultado = Consulta1.Consulta(NomeAluno);

            Console.WriteLine(Resultado);

        }
    }
}
