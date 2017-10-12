using System;

namespace SecureStringServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start SecureString Test Client");
            var serviceClient = new StringInsertServiceRef.StringInsertClient();
            
            Console.WriteLine("Insert text for normal unsecure string and presss enter");
            var unsecureString = Console.ReadLine();
            var result = serviceClient.GetText(unsecureString);
            Console.WriteLine($"\t\t{result} {Environment.NewLine}{Environment.NewLine}");
            
            Console.WriteLine("Insert text for secure string and presss enter");
            unsecureString = Console.ReadLine();
            var secureString = SecureStringBuilder.ConvertToSecureString(unsecureString);
            result = serviceClient.GetTextForSecureString(secureString);
            Console.WriteLine($"\t\t{result} (SecureString){Environment.NewLine}{Environment.NewLine}");

            Console.WriteLine("Press any key for exit");
            Console.ReadLine();
        }
    }
}
