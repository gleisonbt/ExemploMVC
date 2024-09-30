using System;

public class TelaEmprestar
{
    private CEmprestarLivro controladorEmprestimo;
    private CCadastrarAluno controladorCadastro;

    public TelaEmprestar(CEmprestarLivro controladorEmprestimo, CCadastrarAluno controladorCadastro)
    {
        this.controladorEmprestimo = controladorEmprestimo;
        this.controladorCadastro = controladorCadastro;
    }

    public void MostrarTelaEmprestar()
    {
        Console.WriteLine("Lista de Alunos:");
        var alunos = controladorCadastro.ListarAlunos();
        for (int i = 0; i < alunos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {alunos[i].Nome}");
        }

        Console.WriteLine("Selecione o aluno pelo número:");
        int alunoIndex = int.Parse(Console.ReadLine()) - 1;
        Aluno alunoSelecionado = alunos[alunoIndex];

        Console.WriteLine("Digite o título do livro a ser emprestado:");
        string tituloLivro = Console.ReadLine();
        Livro livro = new Livro(1, tituloLivro);

        controladorEmprestimo.EmprestarLivro(alunoSelecionado, livro);
    }
}