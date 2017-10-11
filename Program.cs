using System;
using System.IO;

namespace arquivocsv
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, email;
            int idade;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();
            
            Console.WriteLine("Digite o seu email: ");
            email = Console.ReadLine();
            
            Console.WriteLine("Digite a sua idade: ");
            idade = Int16.Parse(Console.ReadLine());

            /*Pegar essas informações e escrever dentro de um arquivo*/
            /*Primeiro vamos criar o arquivo com StreamWriter*/

            StreamWriter arquivo = new StreamWriter ("dados.csv", true);

            /*Vamos escrever um cadastro por linha com Writeline, e aplicando ; para adicionar o próximo dado em outra célula da mesma linha*/

            arquivo.WriteLine(nome+";"+email+";"+idade+" anos"+";"+DateTime.Now.ToShortDateString());


            arquivo.Close();




        }
    }
}
