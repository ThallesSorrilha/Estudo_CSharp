namespace Projeto01.src.model;

using Projeto01.src.model.enums;
using Projeto01.src.model.dto;

public class Livro
{
    private int? id;
    private string? titulo;
    private int? anoPublicacao;
    private string? isbn;
    private StatusLivro? status;

    public static List<Livro> listaLivros;

    public Livro(int? id, string? titulo, int? anoPublicacao, string? isbn, StatusLivro? status)
    {
        this.id = id;
        this.titulo = titulo;
        this.anoPublicacao = anoPublicacao;
        this.isbn = isbn;
        this.status = status;
    }

    public void MarcarComoEmprestado()
    {
        status = StatusLivro.EMPRESTADO;
    }

    public void MarcarComoDisponivel()
    {
        status = StatusLivro.DISPONIVEL;
    }

    public bool ValidarDadosBasicos()
    {
        if (id == null || titulo == null || status == null)
        {
            return false;
        }
        return true;
    }

    public int? GetId() { return id; }
    public void SetId(int id) { this.id = id; }

    public string? GetTitulo() { return titulo; }
    public void SetId(string titulo) { this.titulo = titulo; }

    public int? GetAnoPublicacao() { return anoPublicacao; }
    public void SetAnoPublicacao(int anoPublicacao) { this.anoPublicacao = anoPublicacao; }

    public string? GetIsbn() { return isbn; }
    public void SetIsbn(string isbn) { this.isbn = isbn; }

    public StatusLivro? GetStatus() { return status; }
    public void SetStatus(StatusLivro status) { this.status = status; }
}
