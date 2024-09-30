class Program
{
    static void Main(string[] args)
    {
        
        CCadastrarAluno controladorCadastro = new CCadastrarAluno();
        CEmprestarLivro controladorEmprestimo = new CEmprestarLivro();

        
        TelaCadastro telaCadastro = new TelaCadastro(controladorCadastro);
        TelaEmprestar telaEmprestar = new TelaEmprestar(controladorEmprestimo, controladorCadastro);

        
        telaCadastro.MostrarTelaCadastro();
        telaEmprestar.MostrarTelaEmprestar();
    }
}
