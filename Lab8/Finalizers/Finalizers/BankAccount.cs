using System;
using System.IO;
using System.Collections;

sealed class BankAccount: IDisposable // Class BankAccount inherits from IDisposable interface
{
    private long accNo;
    private decimal accBal;
    private AccountType accType;
    private Queue tranQueue = new Queue();

    private static long nextNumber = 123;

    bool disposed = false;

    // Constructors
    public BankAccount()
    {
        accNo = NextNumber();
        accType = AccountType.Checking;
        accBal = 0;
    }

    public BankAccount(AccountType aType)
    {
        accNo = NextNumber();
        accType = aType;
        accBal = 0;
    }

    public BankAccount(decimal aBal)
    {
        accNo = NextNumber();
        accType = AccountType.Checking;
        accBal = aBal;
    }

    public BankAccount(AccountType aType, decimal aBal)
    {
        accNo = NextNumber();
        accType = aType;
        accBal = aBal;
    }

    public void Dispose() // Dispose method to call inside the destructor method later
    {
        if (!disposed)
        {
            StreamWriter swFile = File.AppendText("Transactions.Dat");
            swFile.WriteLine("Account number is {0}", accNo);
            swFile.WriteLine("Account balance is {0}", accBal);
            swFile.WriteLine("Account type is {0}", accType);
            foreach (BankTransaction tran in tranQueue)
            {
                swFile.WriteLine("Date/Time: {0}\tAmount:{1}", tran.When(), tran.Amount());
            }
            swFile.Close();
            disposed = true;
            GC.SuppressFinalize(this);
        }
    }

    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds)
        {
            accBal -= amount;
            BankTransaction tran = new BankTransaction(-amount);
            tranQueue.Enqueue(tran);
        }
        return sufficientFunds;
    }

    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        BankTransaction tran = new BankTransaction(amount);
        tranQueue.Enqueue(tran);
        return accBal;
    }

    public Queue Transactions()
    {
        return tranQueue;
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

    private static long NextNumber()
    {
        return nextNumber++;
    }

    // Destructor that calls Dispose() method
    ~BankAccount()
    {
        Dispose();
    } 
    /* Note to self about destructor methods in C#:
       * Destructors are methods inside the class that are used to destroy instances of that class when they're no longer needed. 
        The Destructor is called implicitly by the .NET Framework's Garbage collector and a programmer has no control over when to invoke the destructor.
        Destructor is unique to its class: there can't be more than one in a class
        It doesn't have a return type
        It has exactly the same name as the class
        '~' symbol prefixed to its name distinguishes the destructor
        It doesn't accept any parameters
        It's called when the program exits */ 
    
}

