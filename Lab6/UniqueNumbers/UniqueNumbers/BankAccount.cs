
class BankAccount
{
    private static long NextNumber()
    {
        return nextAccNo++;
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

    private static long nextAccNo = 123;
}
