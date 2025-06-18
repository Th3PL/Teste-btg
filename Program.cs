public class Program
{
    public static void Main(string[] args)
    {
        List<Aluno> alunos = new List<Aluno>();

        while (true)
        {
            Console.Write("Digite o Nome do Aluno ou Enter para sair: ");
            string nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome))
            {
                break;
            }

            Console.Write("Digite a Primeira Nota: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Segunda Nota: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Terceira Nota: ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            Aluno aluno = new Aluno
            {
                Nome = nome,
                Nota1 = n1,
                Nota2 = n2,
                Nota3 = n3
            };
            alunos.Add(aluno);

            Console.WriteLine("\n Alunos Cadastrados");
            foreach (var a in alunos)
            {
                Console.WriteLine($"Nome: {a.Nome}, Média: {a.media():F2}");
            }

            Console.WriteLine();
        }
        Console.WriteLine("Fim do Programa");
    }
}

