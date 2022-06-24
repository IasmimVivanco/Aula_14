namespace Aula14_Atividade
{
    public class Curso: Administracao
    {

        public Dictionary<int, Aluno> NovosAlunos = new Dictionary<int, Aluno>();
        int contador = 0;
        public override void Cadastrar()
        {
            Console.Write("Quantos Alunos deseja cadastrar? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Aluno aluno = new Aluno();
                Console.WriteLine("Digite os dados do aluno" + " " + (i + 1));
                aluno.Matricula = ++contador;
                Console.Write("Digite o nome: ");
                aluno.Nome = Console.ReadLine();
                Console.Write("Digite o sobrenome: ");
                aluno.Sobrenome = Console.ReadLine();
                Console.Write("Digite o telefone: ");
                aluno.Telefone = Console.ReadLine();
                aluno.RegistrarNota();

                Console.WriteLine("---------------------------------");


                NovosAlunos.Add(i, aluno);
            }

        }
        public override void Remover()
        {
            Console.WriteLine("Qual Aluno deseja remover? ");
            foreach (KeyValuePair<int, Aluno> local in NovosAlunos)
            {
                Console.WriteLine($"Digite {local.Key} para remover {local.Value.Nome}");
            }
            int alunoRemovido = int.Parse(Console.ReadLine());
            NovosAlunos.Remove(alunoRemovido);
            Console.WriteLine("---------------------------------");
        }

        public override void ApresentarTodos()
        {
            foreach (KeyValuePair<int, Aluno> local in NovosAlunos)
            {
                Console.WriteLine($"{local.Key} - {local.Value.Nome} {local.Value.Sobrenome}");
            }
            Console.WriteLine("---------------------------------");
        }

        public override void Atualizar()
        {
            Console.WriteLine("Os dados de qual Aluno deseja atualizar? ");
            foreach (KeyValuePair<int, Aluno> local in NovosAlunos)
            {
                Console.WriteLine($"Digite {local.Key} para atualizar {local.Value.Nome}");
            }
            int alunoAtualizado = int.Parse(Console.ReadLine());
            NovosAlunos.Remove(alunoAtualizado);
            Aluno aluno = new Aluno();
            aluno.Matricula = alunoAtualizado;
            Console.Write("Digite o nome: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Digite o sobrenome: ");
            aluno.Sobrenome = Console.ReadLine();
            Console.Write("Digite o telefone: ");
            aluno.Telefone = Console.ReadLine();
            aluno.RegistrarNota();
            NovosAlunos.Add(alunoAtualizado, aluno);

            Console.WriteLine("---------------------------------");
        }
        public Aluno SelecionarAluno()
        {
            Console.WriteLine("Selecione um aluno para continuar:");
            foreach (KeyValuePair<int, Aluno> local in NovosAlunos)
            {
                Console.WriteLine($"Digite {local.Key} para selecionar {local.Value.Nome}");
            }
            int selecionarAluno = int.Parse(Console.ReadLine());
            return NovosAlunos[selecionarAluno];
        }

    }
}
