using Projeto01.src.model;
using Projeto01.src.model.dto;
using Projeto01.src.model.enums;
using Projeto01.src.util;

class LivroView
{
    public void Imprimir(LivroDTO livroDTO, bool id, bool titulo, bool anoPublicacao, bool isbn, bool status)
    {
        if (id)
        {
            Console.WriteLine("ID: " + livroDTO.id);
        }
        if (titulo)
        {
            Console.WriteLine("Titulo: " + livroDTO.titulo);
        }
        if (anoPublicacao)
        {
            Console.WriteLine("Ano Publicação: " + livroDTO.anoPublicacao);
        }
        if (isbn)
        {
            Console.WriteLine("ISBN: " + livroDTO.isbn);
        }
        if (status)
        {
            Console.WriteLine("Status: " + livroDTO.status);
        }
    }

    public LivroDTO SolicitarDados(bool id, bool titulo, bool anoPublicacao, bool isbn, bool status)
    {
        LivroDTO livroDTO = new LivroDTO();
        Console.WriteLine("- Formulário de Livro -");
        if (id)
        {
            livroDTO.id = Entrada.Pegar<int>("ID: ");
        }
        if (titulo)
        {
            livroDTO.titulo = Entrada.Pegar<string>("Titulo: ");
        }
        if (anoPublicacao)
        {
            livroDTO.anoPublicacao = Entrada.Pegar<int>("Ano de Publicação: ");
        }
        if (isbn)
        {
            livroDTO.isbn = Entrada.Pegar<string>("ISBN: ");
        }
        if (status)
        {
            int st = Entrada.Pegar<int>("Status: (0 - Emprestado) (1 - Disponível) (2 - Indisponível)");
            try
            {
                livroDTO.status = (StatusLivro)st;
            }
            catch (System.Exception exception)
            {
                Console.Write("Não foi possível converter status do Livro" + exception);
            }
        }
        return livroDTO;
    }
}