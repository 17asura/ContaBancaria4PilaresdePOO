namespace ContaBancaria4PilaresdePOO;

public class ContaPoupanca : ContaBancaria
{
    private string Tipo;
    public ContaPoupanca(int number, string ownername, double saldo, string tipo, int pin) : base(number, ownername, saldo, pin)
    {
        Tipo = tipo;
    }
    public override void ObterDados()
    {
        Tipo = "Poupança";
        Console.WriteLine($"Número da Conta: {Number}");
        Console.WriteLine($"Nome do Dono: {Ownername}");
        Console.WriteLine($"Tipo: {Tipo}");
    }
    public override void ShowTheMoney(int pinTest)
    {
        if (Pin == pinTest)
        {
            ObterDados();
            Console.WriteLine($"{Saldo}");
        }
        else
        {
            Console.WriteLine("Pin Errado!");
        }
        
    }

    public override void Deposit(int pinTest, double valor)
    {
        if (Pin == pinTest)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
            else
            {
                Console.WriteLine("Valor a depositar insuficiente!");
            }
        }
        else if (Pin != pinTest)
        {
            Console.WriteLine("Pin Errado!");
        }
    }

    public override void TakeTheMoney(int pinTest, double value)
    {
        if (Pin == pinTest)
        {
            if (value > 0)
            {
                if (Saldo - value > 0)
                {
                    Saldo -= value;
                    Console.WriteLine($"Saldo Retirado Com Sucesso!\n Saldo Atual: {Saldo}");
                }
                else
                {
                    Console.WriteLine("Valor a depositar ultrapassa o montante na conta!");
                }
            }
            else
            {
                Console.WriteLine("Valor a depositar tem de ser maior que zero!");
            }
        }
        else
        {
            Console.WriteLine("Pin Errado!");
        }
    }
}