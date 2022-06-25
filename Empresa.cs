using System.Collections.Generic;
namespace Aula14_Atividade
{
    public class Empresa : Administracao
    {
        Funcionario funcionario = new Funcionario();

        public Dictionary<int, Funcionario> NovosFuncionarios = new Dictionary<int, Funcionario>();
        int contador = 0;
        public override void Cadastrar()
        {
            Console.Write("Quantos funcionários deseja cadastrar? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Funcionario funcionario = new Funcionario();
                Console.WriteLine("Digite os dados do " + (i + 1) + "º funcionário: ");
                funcionario.Id = ++contador;
                Console.Write("Digite o nome: ");
                funcionario.Nome = Console.ReadLine();
                Console.Write("Digite o sobrenome: ");
                funcionario.Sobrenome = Console.ReadLine();
                Console.Write("Digite o telefone: ");
                funcionario.Telefone = Console.ReadLine();
                Console.Write("Digite o CPF do funcionário:");
                funcionario.CPF = Console.ReadLine();
                Console.WriteLine("---------------------------------");


                NovosFuncionarios.Add(funcionario.Id, funcionario);
            }

        }
        public override void Remover()
        {
            Console.WriteLine("Qual Funcionário deseja remover? ");
            foreach (KeyValuePair<int, Funcionario> local in NovosFuncionarios)
            {
                Console.WriteLine($"Digite {local.Key} para remover {local.Value.Nome}");
            }
            int funcionarioRemovido = int.Parse(Console.ReadLine());
            NovosFuncionarios.Remove(funcionarioRemovido);
            Console.WriteLine("---------------------------------");
        }
        public override void Atualizar()
        {
            Console.WriteLine("Os dados de qual Funcionario deseja atualizar? ");
            foreach (KeyValuePair<int, Funcionario> local in NovosFuncionarios)
            {
                Console.WriteLine($"Digite {local.Key} para atualizar {local.Value.Nome}");
            }
            int funcionarioAtualizado = int.Parse(Console.ReadLine());
            NovosFuncionarios.Remove(funcionarioAtualizado);
            Funcionario funcionario = new Funcionario();
            funcionario.Id = funcionarioAtualizado;
            Console.Write("Digite o nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Digite o sobrenome: ");
            funcionario.Sobrenome = Console.ReadLine();
            Console.Write("Digite o telefone: ");
            funcionario.Telefone = Console.ReadLine();
            Console.Write("Digite o CPF: ");
            funcionario.CPF = Console.ReadLine();
            NovosFuncionarios.Add(funcionarioAtualizado, funcionario);

            Console.WriteLine("---------------------------------");
        }

        public override void ApresentarTodos()
        {
            Console.WriteLine("Lista de funcionários: ");
            foreach (KeyValuePair<int, Funcionario> local in NovosFuncionarios)
            {
                Console.WriteLine($"ID {local.Key} - {local.Value.Nome}");
            }
            Console.WriteLine("---------------------------------");
        }

        public bool EstagioDoFuncionario()
        {
            Console.Write("Digite o Id que deseja verificar: ");
            int IdFuncionario = int.Parse(Console.ReadLine());
            if (NovosFuncionarios.ContainsKey(IdFuncionario))
            {
                Console.WriteLine("Ativo.");
                return true;
            }
            else
            {
                Console.WriteLine("Inativo.");
                return false;
            }


        }
        public Funcionario SelecionarFuncionario()
        {
            Console.WriteLine("Selecione um funcionario para continuar:");
            foreach (KeyValuePair<int, Funcionario> local in NovosFuncionarios)
            {
                Console.WriteLine($"Digite {local.Key} para selecionar {local.Value.Nome}");
            }
            int selecionarFuncionario = int.Parse(Console.ReadLine());
            return NovosFuncionarios[selecionarFuncionario];
        }
    }
}
