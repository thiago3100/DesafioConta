using System.Globalization;
namespace Desafio
{
    public class Program
    {
        static void Main()
        {
            Account account = new Account();
            Console.Write("Entre com o número da conta: ");
            int numAccount = int.Parse(Console.ReadLine());
            
            Console.Write("Entre com o nome do titular: ");
            account.Name = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char choice = char.Parse(Console.ReadLine());

            double Amount= 0.0;

            while(choice != 's' && choice != 'n')
            {
                Console.WriteLine("Digito inválido, por favor digitar novamente: ");
                Console.WriteLine();
                Console.Write("Haverá depósito inicial (s/n)? ");
                Console.WriteLine();
                choice = char.Parse(Console.ReadLine());

                if(choice == 's')
                {
                    Console.WriteLine();
                    Console.Write("Entre o valor de depósito inicial: ");
                    Amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                else
                {
                    Console.WriteLine();
                }
            }

            Account readAccount = new Account(numAccount, account.Name, Amount );

            Console.WriteLine();

            Console.WriteLine("Entre com os dados da Conta: ");
            Console.WriteLine(readAccount);

            Console.WriteLine();
            
            Console.Write("Entre um valor para depósito: ");
            double valueDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            readAccount.Deposite(valueDep);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(readAccount);
            
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            readAccount.Balance(value);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(readAccount);
        }
    }
}
