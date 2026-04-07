namespace Projeto01.src.service;

using Projeto01.src.model;
using Projeto01.src.model.dto;

public class BibliotecaService
{
    //CadastrarLivro
    public bool CadastrarLivro(LivroDTO livroDTO)
    {
        Livro livro = new Livro(livroDTO.id, livroDTO.titulo, livroDTO.anoPublicacao, livroDTO.isbn, livroDTO.status);
        
        if (Livro.listaLivros.Any(liv => liv.GetIsbn() == livro.GetIsbn()))
        {
            Console.WriteLine("ISBN já cadastrado");
            return false;
        }

        Livro.listaLivros.Add(livro);
        return true;
    }

    //CadastrarUsuario
    //EmprestarLivro
    //DevolverLivro
    //ListarDisponiveis
    //ListarEmprestimosAtivos
    //HistoricoUsuario
}