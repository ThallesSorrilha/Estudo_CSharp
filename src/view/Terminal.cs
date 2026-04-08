using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Projeto01.src.model.dto;
using Projeto01.src.service;
using Projeto01.src.util;

namespace Projeto01.src.view;

public static class Terminal
{
    private static bool vivo = true;
    private static int opcao;
    private static readonly string PERGUNTA = "Escolha uma opção:\n 0.Sair\n 1.Cadastrar livro.\n 2.Cadastrar usuário.\n 3.Realizar empréstimo de livro.\n 4.Realizar devolução.\n 5.Listar livros disponíveis.\n 6.Listar empréstimos ativos.\n 7.Exibir histórico de empréstimos por usuário.";
    private static readonly Dictionary<int, Action> MAPAACOES = new()
    {
        {0, Sair},
        {1, CadastrarLivro}
    };

    public static void Loop()
    {
        while (vivo)
        {
            try
            {
                opcao = Entrada.Pegar<int>(PERGUNTA);
                Action callback = MAPAACOES[opcao];
                callback();
                Console.WriteLine("-----------------");
            }
            catch { }
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

    public static void CadastrarLivro()
    {
        LivroView livroView = new LivroView();
        LivroDTO livroDTO = livroView.SolicitarDados(false, true, true, true, true);
        livroView.Imprimir(livroDTO, true, true, true, true, true);
        BibliotecaService bibliotecaService = new BibliotecaService();
        bibliotecaService.CadastrarLivro(livroDTO);
    }

    //Cadastrar usuário.
    //Realizar empréstimo de livro.
    //Realizar devolução.
    //Listar livros disponíveis.
    //Listar empréstimos ativos.
    //Exibir histórico de empréstimos por usuário.
    //Modelo de Domínio (Classes Principais)

}