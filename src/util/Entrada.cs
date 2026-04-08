namespace Projeto01.src.util;

public class Entrada
{
    public static T? Pegar<T>(string? texto = "")
    {
        string? entrada;
        do
        {
            Console.WriteLine(texto);
            entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Entrada obrigatória não pode ser vazia");
            }
            else
            {
                try
                {
                    return (T)Convert.ChangeType(entrada, typeof(T));
                } catch (Exception exception)
                {
                    Console.WriteLine($"Não foi possível converter para {typeof(T).Name}", exception);
                }
            }
        } while (true);
    }
}