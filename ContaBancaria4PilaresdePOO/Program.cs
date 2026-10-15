using ContaBancaria4PilaresdePOO;

using ContaBancaria4PilaresdePOO;

List<ContaBancaria> listaDeContas = new List<ContaBancaria>();
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
            Console.WriteLine("Criando uma conta, qual o tipo?");
            Console.WriteLine("[1] - Poupança");
            Console.WriteLine("[2] - Conta Corrente");
            int tipo = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Criando uma conta, qual o numero?");
            int num = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Criando uma conta, qual o nome do Titular?");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Criando uma conta, qual o saldo?");
            int saldo = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Criando uma conta, qual o pin?");
            int pin = int.Parse(Console.ReadLine());
            
            // 2. Preencher a variável que criámos lá fora
            if (tipo == 1)
            {
                novaContaBancaria = new ContaPoupanca(num, nome, saldo, "Poupança", pin);
                Console.WriteLine("Conta Poupança criada com sucesso!");
            }
            else if (tipo == 2)
            {
                novaContaBancaria = new ContaCorrente(num, nome, saldo, "Corrente", pin);
                Console.WriteLine("Conta Corrente criada com sucesso!");
            }
            else
            {
                Console.WriteLine("Tipo de conta inválido!");
            }
        }
        else if (choice == 2)
        {
            // 3. Verificar se a conta já foi criada antes de tentar ver os dados
            if (novaContaBancaria != null)
            {
                novaContaBancaria.ObterDados();
            }
            else
            {
                Console.WriteLine("Por favor, crie uma conta primeiro (Opção 1).");
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
            break; // Sai do loop infinito
        }
    }