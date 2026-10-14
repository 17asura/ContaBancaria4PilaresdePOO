using ContaBancaria4PilaresdePOO;
Console.WriteLine("Criando uma conta, qual o tipo?");
Console.WriteLine("1 - Poupança\n");
Console.WriteLine("2 - Conta Corrente\n");
int tipo = int.Parse(Console.ReadLine());
Console.WriteLine("Criando uma conta, qual o numero?");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Criando uma conta, qual o nome do dono?");
string nome = Console.ReadLine();
Console.WriteLine("Criando uma conta, qual o saldo?");
int saldo = int.Parse(Console.ReadLine());
Console.WriteLine("Criando uma conta, qual o pin?");
int pin = int.Parse(Console.ReadLine());
ContaBancaria novaContaBancaria;
if (tipo == 1 || tipo == 2)
{
    if (tipo == 1)
    {
        novaContaBancaria = new ContaPoupanca(num, nome, saldo,"tipo", pin);
        novaContaBancaria.ObterDados();
        Console.WriteLine("Quer ver o seu saldo? Digite seu pin:");
        int pin_test =  int.Parse(Console.ReadLine());
        novaContaBancaria.ShowTheMoney(pin_test);
    }
    else if (tipo == 2)
    {
        novaContaBancaria = new ContaCorrente(num, nome, saldo,"tipo", pin);
        novaContaBancaria.ObterDados();
        Console.WriteLine("Quer ver o seu saldo? Digite seu pin:");
        int pin_test =  int.Parse(Console.ReadLine());
        novaContaBancaria.ShowTheMoney(pin_test);
    }
}
