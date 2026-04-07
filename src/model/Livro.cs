namespace Model;

public class Livro
{
    private int id;
    private string titulo;
    private int anoPublicacao;
    private string isbn;
    private bool disponivel;

    public Livro() { }
    public Livro(int id, string titulo, int anoPublicacao, string isbn, bool disponivel)
    {
        this.id = id;
        this.titulo = titulo;
        this.anoPublicacao = anoPublicacao;
        this.isbn = isbn;
        this.disponivel = disponivel;
    }

    public int GetId() { return id; }
    public void SetId(int id) { this.id = id; }

    public string GetTitulo() { return titulo; }
    public void SetId(string titulo) { this.titulo = titulo; }

    public int GetAnoPublicacao() { return anoPublicacao; }
    public void SetAnoPublicacao(int anoPublicacao) { this.anoPublicacao = anoPublicacao; }

    public string GetIsbn() { return isbn; }
    public void SetIsbn(string isbn) { this.isbn = isbn; }

    public bool GetDisponivel() { return disponivel; }
    public void SetId(bool disponivel) { this.disponivel = disponivel; }
}
