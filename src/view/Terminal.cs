using System;
using System.Collections.Generic;

namespace Projeto01.src.view;

public static class Terminal
{
    private static bool vivo = true;
    private static int opcao;
    private static readonly string PERGUNTA = "Escolha uma opção:\n 1.Cadastrar livro.\n 2.Cadastrar usuário.\n 3.Realizar empréstimo de livro.\n 4.Realizar devolução.\n 5.Listar livros disponíveis.\n 6.Listar empréstimos ativos.\n 7.Exibir histórico de empréstimos por usuário.";
    private static readonly Dictionary<int, Action> MAPAACOES = new()
    {
        {0, Sair},
        {1, Teste}
    };

    public static void Loop()
    {
        while (vivo)
        {
            Console.WriteLine(PERGUNTA);
            opcao = int.Parse(Console.ReadLine());
            Action callback = MAPAACOES[opcao];
            callback();
            Console.WriteLine("-----------------");
        }
    }

    public static void Sair()
    {
        vivo = false;
    }

    public static void Teste()
    {
        Console.WriteLine("Teste");
    }
    
    //Cadastrar livro.

    public static void cadastrarLivro

    //Cadastrar usuário.
    //Realizar empréstimo de livro.
    //Realizar devolução.
    //Listar livros disponíveis.
    //Listar empréstimos ativos.
    //Exibir histórico de empréstimos por usuário.
    //Modelo de Domínio (Classes Principais)
    
}