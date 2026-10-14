namespace ContaBancaria4PilaresdePOO;

public abstract class ContaBancaria
{
    public int Number { get; private set; }
    public string Ownername { get; private set; }
    protected double Saldo;
    protected int Pin;

    public ContaBancaria(int number, string ownername, double saldo, int pin)
    {
        Number = number;
        Ownername = ownername;
        Saldo = saldo;
        Pin = pin;
    }

    public abstract void ObterDados();
    public abstract void Depositar(int pinTest, double valor);
    public abstract void ShowTheMoney( int pinTest );

}