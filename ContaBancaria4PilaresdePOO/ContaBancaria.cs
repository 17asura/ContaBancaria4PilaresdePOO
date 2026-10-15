namespace ContaBancaria4PilaresdePOO;

public abstract class ContaBancaria
{
    public int Number { get; private set; }
    public string Ownername { get; private set; }
    public string AccType { get; private set; }
    
    protected double Saldo;
    protected int Pin;

    protected ContaBancaria(int number, string acctype , string ownername, double saldo, int pin)
    {
        Number = number;
        AccType = acctype;
        Ownername = ownername;
        Saldo = saldo;
        Pin = pin;
    }

    public void GetAccData()
    {
        Console.WriteLine($"Número da Conta: {Number}");
        Console.WriteLine($"Nome do Dono: {Ownername}");
        Console.WriteLine($"Tipo: {AccType}");
    }
    
    public void Deposit(int pinTest, double value)
    {
        if (Pin == pinTest)
        {
            if (value > 0)
            {
                Saldo += value;
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
    public void ShowTheMoney(int pinTest)
    {
        if (Pin == pinTest)
        {
            GetAccData();
            Console.WriteLine($"{Saldo}");
        }
        else
        {
            Console.WriteLine("Pin Errado!");
        }
        
    }
    public abstract void TakeTheMoney(int pinTest, double value);
}