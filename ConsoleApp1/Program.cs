using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = null;
            int idade = 0;


            //Solicitando nome do Usuário 
            Console.WriteLine("Digite seu nome: ");


            //Adicionando nome da variável 
            nome = Console.ReadLine();

            //Solicitando idade do Usuário
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            // usando .Parse para converter INT em STRING




            // usando IF para dizer se é maior ou menor de idade 
            if (idade >= 18){
                Console.WriteLine("Voce é maior de idade ");
            } 
            if (idade <= 18)
            {
                Console.WriteLine("Voce é menor de idade ");
            }
                  
               
            // resposta do cadastro
            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Sua idade é: " + idade);



        }
    }
}
