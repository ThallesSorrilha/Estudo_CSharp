namespace Projeto01.src.service;

using Projeto01.src.model.dto;

public class BibliotecaService
{
    private LivroService livroService = new LivroService();

    public bool CadastrarLivro(LivroDTO livroDTO)
    {
        return livroService.CadastrarLivro(livroDTO);
    }

    //CadastrarUsuario
    //EmprestarLivro
    //DevolverLivro

    public List<LivroDTO> ListarDisponiveis()
    {
        return livroService.ListarDisponiveis();
    }

    //ListarEmprestimosAtivos
    //HistoricoUsuario
}