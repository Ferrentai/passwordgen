using System;
using System.Text;

namespace Gerador_de_Senhas;
class Program {
    static void Main(string[] args) {

        //MEU PRIMEIRO PROJETO <3

        Console.Write("Digite a quantidade de caracteres que deseja para sua nova senha: ");

        int qnt = int.Parse(Console.ReadLine());

        string numerosPossiveis = "ABCDEFGHIJKLMNOPQRSTUVWYXZÇabcdefghijklmnopqrstuvwyxz0123456789!@#$%&*";

        Random sorteio = new Random();

        int numerosSorteados = 0;

        StringBuilder senha = new StringBuilder();

        for (int i = 0; i < qnt; i++) {
            numerosSorteados = sorteio.Next(0, numerosPossiveis.Length - 1);
            senha.Append(numerosPossiveis[numerosSorteados]);

        }
        

        Console.WriteLine("A senha gerada é: " + senha);
        Console.ReadLine();
    }
}