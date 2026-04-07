namespace Projeto01.src.model.dto;

using Projeto01.src.model.enums;

public struct LivroDTO
{
    public int? id;
    public string? titulo;
    public int? anoPublicacao;
    public string? isbn;
    public StatusLivro? status;
}