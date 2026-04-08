using Projeto01.src.model;
using Projeto01.src.model.dto;
using Projeto01.src.model.enums;

class LivroService
{
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

    public List<LivroDTO> ListarDisponiveis()
    {
        IEnumerable<Livro> consulta = Livro.listaLivros.Where(liv => liv.GetStatus() == StatusLivro.DISPONIVEL);
        int quantidade = consulta.Count();
        Console.WriteLine("Qtde. de livros disponíveis: " + quantidade);
        List<LivroDTO> listaDTOs = new List<LivroDTO>();
        foreach (Livro liv in consulta)
        {
            listaDTOs.Add(new LivroDTO { titulo = liv.GetTitulo() });
        }
        return listaDTOs;
    }
}