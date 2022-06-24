using System.Globalization;
namespace Aula14_Atividade
{
    public class Aluno
    {
        public int Matricula = 0;
        public string Nome;
        public string Sobrenome;
        public string Telefone;
        public int[] Notas = new int [4];

        public int[] RegistrarNota()
        {
            for (int i = 0; i < Notas.Length; i++)
            {
                Console.Write($"Digite a nota do {i + 1}º Bimestre:");
                Notas[i] = int.Parse(Console.ReadLine());
            }
            return Notas;

        }

        public void ApresentarNotas()
        {
            for (int i = 0; i < Notas.Length; i++)
            {
                Console.WriteLine($"Nota do {i + 1}º Bimestre: {Notas[i]}");
            }
        }

        public double MediaDasNotas()
        {
            double somatoria = 0;
            for (int i = 0; i < Notas.Length; i++)
            {
               somatoria += Notas[i];
            }
            double media = somatoria / Notas.Length;
            Console.WriteLine($"Sua média é: {media}");
            return media;
        }

        public bool Estagio()
        {
            double media = MediaDasNotas();
            if (media > 5)
            {
                Console.WriteLine();
                Console.WriteLine("Aprovado.");
                return true;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Reprovado.");
                return false;
            }
        }
    }
}
