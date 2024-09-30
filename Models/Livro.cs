public class Livro
{
    public int Id { get; set; }
    public string Titulo { get; set; }

    public Livro(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
    }
}