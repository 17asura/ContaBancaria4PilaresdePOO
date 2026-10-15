using System;
using System.Collections.Generic;
using ContaBancaria4PilaresdePOO;

List<ContaBancaria> accountList = new List<ContaBancaria>();
ContaBancaria novaContaBancaria = null;

while (true)
{
    Console.WriteLine("\n=== Bank Accounts Manager ===");
    Console.WriteLine("Welcome, What would you like to do?");
    Console.WriteLine("[1] Create an Account");
    Console.WriteLine("[2] See Account Details");
    Console.WriteLine("[3] See Account Balance");
    Console.WriteLine("[4] Deposit");
    Console.WriteLine("[5] Withdraw");
    Console.WriteLine("[6] Exit");
    Console.Write("Escolha: ");

    int choice = int.Parse(Console.ReadLine());

    // OPÇÃO 1: CRIAR CONTA
    if (choice == 1)
    {
        Console.WriteLine("\nCreating an account, choose a type: ");
        Console.WriteLine("[1] - Savings Account");
        Console.WriteLine("[2] - Checking Account");
        int type = int.Parse(Console.ReadLine());

        Console.WriteLine("ID: ");
        int num = int.Parse(Console.ReadLine());
        
        // O método .Find() percorre a lista automaticamente e devolve a conta se o ID bater certo.
        ContaBancaria accountFound = accountList.Find(c => c.Number == num);
        
        if (accountFound != null)
        {
            Console.WriteLine("Error: Account ID already exists!");
            continue;
        }

        Console.WriteLine("Full Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("First Deposit: ");
        int balance = int.Parse(Console.ReadLine());

        Console.WriteLine("Pin Number:");
        int pin = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            novaContaBancaria = new ContaPoupanca(num, "Savings Account", name, balance, pin);
            accountList.Add(novaContaBancaria);
            Console.WriteLine($"{novaContaBancaria.Ownername}, The Savings Account was Successfully Created!");
        }
        else if (type == 2)
        {
            novaContaBancaria = new ContaCorrente(num, "Checking Account", name, balance, pin);
            accountList.Add(novaContaBancaria);
            Console.WriteLine($"{novaContaBancaria.Ownername}, The Checking Account was Successfully Created!");
        }
        else
        {
            Console.WriteLine("Error: Account Type Invalid!");
        }
    }
    // OPÇÃO 2: VER DETALHES
    else if (choice == 2)
    {
        Console.WriteLine("\nAccount Number: ");
        int numProcurado = int.Parse(Console.ReadLine());
        Console.WriteLine("Pin: ");
        int pinTest = int.Parse(Console.ReadLine());
        ContaBancaria accountFound = accountList.Find(c => c.Number == numProcurado);
        
        if (accountFound != null)
        {
            Console.WriteLine("\n--- Account Found ---");
            accountFound.GetAccData(pinTest);
        }
        else
        {
            Console.WriteLine("\nError: No Account Found.");
        }
    }
    // OPÇÃO 3: VER SALDO
    else if (choice == 3)
    {
        Console.WriteLine("\nAccount Number: ");
        int searchedNum = int.Parse(Console.ReadLine());
        
        ContaBancaria accountFound = accountList.Find(c => c.Number == searchedNum);

        if (accountFound != null)
        {
            Console.WriteLine("Pin Number: ");
            int pinTest = int.Parse(Console.ReadLine());
            accountFound.ShowTheMoney(pinTest);
        }
        else
        {
            Console.WriteLine("\nError: No Account Found.");
        }
    }
    // OPÇÃO 4: DEPOSITAR
    else if (choice == 4)
    {
        Console.WriteLine("\nAccount Number: ");
        int searchedNum = int.Parse(Console.ReadLine());
        
        ContaBancaria accountFound = accountList.Find(c => c.Number == searchedNum);

        if (accountFound != null)
        {
            Console.WriteLine("Pin Number: ");
            int pinTest = int.Parse(Console.ReadLine());
            Console.WriteLine("Value to Deposit: ");
            double value = double.Parse(Console.ReadLine());
            
            accountFound.Deposit(pinTest, value);
        }
        else
        {
            Console.WriteLine("\nError: No Account Found.");
        }
    }
    // OPÇÃO 5: LEVANTAR
    else if (choice == 5)
    {
        Console.WriteLine("\nAccount Number: ");
        int searchedNum = int.Parse(Console.ReadLine());
        
        ContaBancaria accountFound = accountList.Find(c => c.Number == searchedNum);

        if (accountFound != null)
        {
            Console.WriteLine("Pin Number: ");
            int pinTest = int.Parse(Console.ReadLine());
            Console.WriteLine("Value to Withdraw: ");
            double value = double.Parse(Console.ReadLine());
            
            accountFound.TakeTheMoney(pinTest, value);
        }
        else
        {
            Console.WriteLine("\nError: No Account Found.");
        }
    }
    // OPÇÃO 6: SAIR
    else if (choice == 6)
    {
        Console.WriteLine("\nA sair do sistema...");
        break;
    }
    else
    {
        Console.WriteLine("\nError: Invalid menu choice.");
    }
}