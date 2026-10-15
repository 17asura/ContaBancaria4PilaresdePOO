namespace ContaBancaria4PilaresdePOO;

public class ContaCorrente : ContaBancaria
{
    
    public ContaCorrente(int number, string acctype, string ownername, double saldo, int pin) : base(number, acctype, ownername, saldo, pin)
    {}
    //Método Abstrato Levantamento Com Condições Privadas
    public override void TakeTheMoney(int pinTest, double value)
    {
        if (Pin == pinTest)
        {
            if (value > 0 && Saldo - value >= -500)
            {
                    Saldo -= value;
                    Console.WriteLine($"Successful Withdrawal!\n New Balance: {Saldo}");
            }
            else
            {
                Console.WriteLine("Withdrawal Value Exceeds Limit!");
            }
        }
        else
        {
            Console.WriteLine("Wrong Credentials!");
        }
    }
}