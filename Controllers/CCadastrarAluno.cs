using System.Collections.Generic;

public class CCadastrarAluno
{
    private List<Aluno> alunos = new List<Aluno>();

    public void CadastrarAluno(Aluno aluno)
    {
        alunos.Add(aluno);
        Console.WriteLine($"Aluno {aluno.Nome} cadastrado com sucesso!");
    }

    public List<Aluno> ListarAlunos()
    {
        return alunos;
    }
}
