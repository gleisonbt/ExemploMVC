public class Emprestimo
{
    public Aluno Aluno { get; set; }
    public Livro Livro { get; set; }
    public DateTime DataEmprestimo { get; set; }

    public Emprestimo(Aluno aluno, Livro livro)
    {
        Aluno = aluno;
        Livro = livro;
        DataEmprestimo = DateTime.Now;
    }
}