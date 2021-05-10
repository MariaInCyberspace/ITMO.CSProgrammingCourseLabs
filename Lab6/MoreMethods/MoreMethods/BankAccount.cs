
class BankAccount
{
    public decimal Deposit(decimal amount)
    {
        if (amount > 0) 
        {
            accBal += amount;
            return accBal;
        } 
        return accBal;
    }
    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds)
        {
            accBal -= amount;
        }
        return sufficientFunds;
    }
    public void Populate(decimal balance)
    {
        accNo = NextNumber();
        accBal = balance;
        accType = AccountType.Checking;
    }

    public long Number()
    {
        return accNo;
    }

    public decimal Balance()
    {
        return accBal;
    }

    public string Type()
    {
        return accType.ToString();
    }

    private long accNo;
    private decimal accBal;
    private AccountType accType;

    private static long nextNumber = 123;

    private static long NextNumber()
    {
        return nextNumber++;
    }
}
