namespace ContaBancaria4PilaresdePOO;

public class ContaCorrente : ContaBancaria
{
    private string Tipo;
    public ContaCorrente(int number, string ownername, double saldo, string tipo, int pin) : base(number, ownername, saldo, pin)
    {
        Tipo = tipo;
    }
    public override void ObterDados()
    {
        Tipo = "Corrente";
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
    public override void Depositar(int pinTest, double valor)
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
}