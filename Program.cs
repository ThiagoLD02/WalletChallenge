// See https://aka.ms/new-console-template for more information

using WalletActivity;

var someDollars = new Dollar(10.00d); 

var wallet = new Wallet<Currency>(someDollars);

Console.WriteLine($"The wallet has {wallet.GetFounds("Dollar")} dollars.");

var someEuros = new Euro(20.00d);

wallet.AddFounds(someEuros);

Console.WriteLine($"The wallet has {wallet.GetFounds("Euro")} euros.");

Console.WriteLine($"Exchanging {wallet.GetFounds("Euro")} Euros to Dollar.");

wallet.ExchangeToDollar();

Console.WriteLine($"The wallet has {wallet.GetFounds("Dollar")} dollars.");

Console.WriteLine($"The wallet has {wallet.GetFounds("Euro")} euros.");

Console.WriteLine($"Exchanging {wallet.GetFounds("Dollar")} Dollars to Euro.");

wallet.ExchangeToEuro();



Console.WriteLine($"The wallet has {wallet.GetFounds("Euro")} Euros.");

Console.WriteLine($"The wallet has {wallet.GetFounds("Dollar")} dollars.");