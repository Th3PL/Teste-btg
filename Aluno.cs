public class Aluno
{
    public String Nome { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Nota3 { get; set; }

    public double media()
    {
        return (Nota1 + Nota2 + Nota3) / 3;
    }
}