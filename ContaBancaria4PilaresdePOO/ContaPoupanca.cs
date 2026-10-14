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
}