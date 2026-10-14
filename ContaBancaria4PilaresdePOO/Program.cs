using ContaBancaria4PilaresdePOO;

Console.WriteLine("Criando uma conta poupança, qual o numero?");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Criando uma conta poupança, qual o nome do dono?");
string nome = Console.ReadLine();
Console.WriteLine("Criando uma conta poupança, qual o saldo?");
int saldo = int.Parse(Console.ReadLine());
Console.WriteLine("Criando uma conta poupança, qual o pin?");
int pin = int.Parse(Console.ReadLine());
var novaconta = new ContaPoupanca(num, nome, saldo, "tipo", pin);
novaconta.ObterDados();
Console.WriteLine("Quer ver o seu saldo? Digite seu pin:");
int pin_test =  int.Parse(Console.ReadLine());
novaconta.ShowTheMoney(pin_test);