using System;

class Program
{
    static void Main(string[] args)
    {
      var emailCadastro = "shaula@email.com";
      var nomeUsuario = "Shaula";
      var senha = "8989";

      emailCadastro = Console.ReadLine();
      nomeUsuario = Console.ReadLine();

      Console.WriteLine($"{nomeUsuario}, verifique o email: {emailCadastro} para ativar.");

    }
}