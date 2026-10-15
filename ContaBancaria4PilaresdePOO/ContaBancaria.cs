namespace ContaBancaria4PilaresdePOO;

public abstract class ContaBancaria
{
    public int Number { get; private set; }
    public string Ownername { get; private set; }
    public string AccType { get; private set; }
    
    protected double Saldo;
    protected int Pin;
    //Objeto
    protected ContaBancaria(int number, string acctype , string ownername, double saldo, int pin)
    {
        Number = number;
        AccType = acctype;
        Ownername = ownername;
        Saldo = saldo;
        Pin = pin;
    }
    // Dados da Conta
    public void GetAccData(int pinTest)
    {
        if (Pin == pinTest)
        {
            Console.WriteLine($"Account Number: {Number}");
            Console.WriteLine($"Owner Name: {Ownername}");
            Console.WriteLine($"Type: {AccType}");
        }
        else
        {
            Console.WriteLine("Pin Errado!");
        }
    }
    //Método Depositar
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
    //Método Mostrar Saldo
    public void ShowTheMoney(int pinTest)
    {
        if (Pin == pinTest)
        {
            GetAccData(pinTest);
            Console.WriteLine($"{Saldo}");
        }
        else
        {
            Console.WriteLine("Pin Errado!");
        }
        
    }
    //Método Abstrato Levantamento
    public abstract void TakeTheMoney(int pinTest, double value);
}