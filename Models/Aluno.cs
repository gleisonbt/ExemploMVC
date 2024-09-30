public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public Aluno(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }
}