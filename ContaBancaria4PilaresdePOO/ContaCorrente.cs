namespace ContaBancaria4PilaresdePOO;

public class ContaCorrente : ContaBancaria
{
    
    public ContaCorrente(int number, string acctype, string ownername, double saldo, int pin) : base(number, acctype, ownername, saldo, pin)
    {}

    
    public override void TakeTheMoney(int pinTest, double value)
    {
        if (Pin == pinTest)
        {
            if (value > 0)
            {
                    Saldo -= value;
                    Console.WriteLine($"Saldo Retirado Com Sucesso!\n Saldo Atual: {Saldo}");
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