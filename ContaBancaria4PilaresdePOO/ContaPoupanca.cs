namespace ContaBancaria4PilaresdePOO;

public class ContaPoupanca : ContaBancaria
{
    private string AccType;

    public ContaPoupanca(int number, string acctype, string ownername, double saldo, int pin) : base(number, acctype,
        ownername, saldo, pin){}

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