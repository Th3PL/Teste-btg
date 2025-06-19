using System.Globalization;

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

            double n1 = lerNota("Nota 1: ");
            double n2 = lerNota("Nota 2: ");
            double n3 = lerNota("Nota 3: ");


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

    static double lerNota(String nota)
    {
        while (true)
        {
            try
            {
                Console.Write($"{nota} (0 a 10): ");
                string notaEntrada = Console.ReadLine();
                double n = Convert.ToDouble(notaEntrada);

                if (n >= 0 && n <= 10)
                {
                    return n;
                }
                Console.WriteLine("Nota fora do intervalo. Digite um valor entre 0 e 10.");
            }
            catch
            {
                Console.WriteLine("Valor inválido.");
            }
        }
    }
}

