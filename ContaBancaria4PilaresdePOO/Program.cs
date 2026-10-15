using ContaBancaria4PilaresdePOO;

using ContaBancaria4PilaresdePOO;

List<ContaBancaria> accountList = new List<ContaBancaria>();
    // 1. Declarar a variável FORA do loop para não a perdermos
    ContaBancaria novaContaBancaria = null;

    Console.Title = "Bank Accounts Manager";

    while (true)
    {
        Console.WriteLine("\nWelcome, What would you like to do?");
        Console.WriteLine("[1] Create an Account");
        Console.WriteLine("[2] See Account Details");
        Console.WriteLine("[3] See Account Balance");
        Console.WriteLine("[4] Deposit");
        Console.WriteLine("[5] Withdraw");
        Console.WriteLine("[6] Exit");
        
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("Creating an account, choose a type: ");
            Console.WriteLine("[1] - Savings Account");
            Console.WriteLine("[2] - Checking Account");
            int type = int.Parse(Console.ReadLine());
            
            Console.WriteLine("ID: ");
            int num = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Full Name: ");
            string name = Console.ReadLine();
            
            Console.WriteLine("First Deposit: ");
            int balance = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Pin Number:");
            int pin = int.Parse(Console.ReadLine());
            
            if (type == 1)
            {
                string choosedtype = "Savings Account";
                novaContaBancaria = new ContaPoupanca(num, choosedtype, name, balance, pin);
                Console.WriteLine("Savings Account Successfully Created!");
            }
            else if (type == 2)
            {
                string choosedtype = "Checking Account";
                novaContaBancaria = new ContaCorrente(num, choosedtype, name, balance, pin);
                Console.WriteLine("Checking Account Successfully Created!");
            }
            else
            {
                Console.WriteLine("Account Type Invalid!");
            }
        }
        else if (choice == 2)
        {
            Console.WriteLine("Account Number: ");
            int numProcurado = int.Parse(Console.ReadLine());
            ContaBancaria AccountFound = null;
            foreach (ContaBancaria Account in accountList)
            {
                if (Account.Number == numProcurado)
                {
                    AccountFound = Account;
                    break;
                }
            }
            
            if (AccountFound != null)
            {
                Console.WriteLine("\n--- Account Found ---");
                AccountFound.GetAccData();
            }
            else
            {
                Console.WriteLine("\nError: No Account Found.");
            }
        }
        else if (choice == 3)
        {
            if (novaContaBancaria != null)
            {
                Console.WriteLine("Quer ver o seu saldo? Digite seu pin:");
                int pin_test = int.Parse(Console.ReadLine());
                novaContaBancaria.ShowTheMoney(pin_test);
            }
            else
            {
                Console.WriteLine("Por favor, crie uma conta primeiro (Opção 1).");
            }
        }
        else if (choice == 6)
        {
            Console.WriteLine("A sair do sistema...");
            break;
        }
    }