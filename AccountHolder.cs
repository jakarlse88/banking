using System;

/// <summary>
/// The AccountHolder class contains information about an account holder,
/// including name, account number, and references to his/her savings and checking accounts. 
/// </summary>
internal class AccountHolder
{
    private int accountNumber;
    private string firstName;
    private string lastName;
    private BankingAccount checkingAccount;
    private BankingAccount savingsAccount;

    /// <summary>
    /// Class constructor.
    /// <param name="accountNumber">Used to assign an account number.</param>
    /// <param name="firstName">Used to assign a first name.</param>
    /// <param name="lastName">Used to assign a last name.</param>
    /// <remarks>
    /// In the current implementation, the savings/checking accounts are accessed via 
    /// objects instantiated from this
    /// </remarks>
    /// </summary>
    internal AccountHolder(int accountNumber, string firstName, string lastName)
    {
        this.accountNumber = accountNumber;
        this.firstName = firstName.ToUpper();
        this.lastName = lastName.ToUpper();
        this.checkingAccount = new BankingAccount(0, "checking");
        this.savingsAccount = new BankingAccount(0, "savings");
    }

    internal int AccountNumber
    {
        get { return accountNumber; }
    }

    internal string FirstName
    {
        get { return firstName; }
    }

    internal string LastName
    {
        get { return lastName; }
    }

    internal BankingAccount CheckingAccount
    {
        get { return checkingAccount; }
    }

    internal BankingAccount SavingsAccount
    {
        get { return savingsAccount; }
    }
}
