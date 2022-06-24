namespace Aula14_Atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Você é aluno ou funcionário? Digite A para aluno e F para funcionário");
            string opcao = Console.ReadLine();
            if (opcao == "A" || opcao == "a")
            {
                Curso curso = new Curso();
                curso.Cadastrar();
                Console.Write("Deseja remover algum aluno? S/N");
                string opcao2 = Console.ReadLine();
                if (opcao2 == "S" || opcao2 == "s")
                {
                    curso.Remover();
                    Console.WriteLine("Lista de Alunos Atualizada:");
                    curso.ApresentarTodos();
                }
                else if (opcao2 == "N" || opcao2 == "n")
                {
                    Console.WriteLine("Lista de Alunos:");
                    curso.ApresentarTodos();
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
                Console.Write("Gostaria de Atualizar alguma informação? S/N");
                string opcao3 = Console.ReadLine();
                if (opcao3 == "S" || opcao3 == "s")
                {
                    curso.Atualizar();
                    Console.WriteLine("Lista atualizada:");
                    curso.ApresentarTodos();
                }
                else
                {
                    Console.WriteLine("---------------------------------");
                }
                Console.Write("Gostaria de verificar a aprovação de algum aluno? S/N: ");
                string opcao4 = Console.ReadLine();
                Console.WriteLine();
                if (opcao4 == "S" || opcao4 == "s")
                {
                    var aluno = curso.SelecionarAluno();
                    Console.WriteLine();
                    aluno.ApresentarNotas();
                    Console.WriteLine();
                    aluno.Estagio();
                    Console.WriteLine("---------------------------------");
                }



            }
        }
    }
}