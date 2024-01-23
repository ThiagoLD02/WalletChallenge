namespace WalletActivity;

public class Wallet<T> where T : Currency
{
    private Dollar dollar = new Dollar(0d);
    private Euro euro = new Euro(0d);
    public Wallet(T currency)
    {
        AddToWallet(currency);
    }
    
    private void AddToWallet(T currency)
    {
        if (currency.Name == "Dollar")
        {
            dollar.Amount += currency.Amount;
            
        }
        else
        {
            euro.Amount += currency.Amount;
        }
    }

    public void AddFounds(T currency)
    {
        AddToWallet(currency);
    }

    public double GetFounds(string currency)
    {
        return currency == "Dollar" ? dollar.Amount : euro.Amount;
    }

    public double ExchangeToDollar()
    {
        var amount = euro.Convert();
        dollar.Amount += amount;
        euro.Amount = 0d;
        return dollar.Amount;
    }
    public double ExchangeToEuro()
    {
        var euroAmount = dollar.Convert();
        euro.Amount += euroAmount;
        dollar.Amount = 0d;
        return euro.Amount;
    }

    
    
    
}
