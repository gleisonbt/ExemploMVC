using System;

public class TelaCadastro
{
    private CCadastrarAluno controladorCadastro;

    public TelaCadastro(CCadastrarAluno controlador)
    {
        controladorCadastro = controlador;
    }

    public void MostrarTelaCadastro()
    {
        Console.WriteLine("Digite o nome do aluno:");
        string nome = Console.ReadLine();
        int id = controladorCadastro.ListarAlunos().Count + 1;
        Aluno aluno = new Aluno(id, nome);
        controladorCadastro.CadastrarAluno(aluno);
    }
}
