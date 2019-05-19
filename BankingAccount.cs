using System;
using System.IO;

internal class BankingAccount : IBankingAccount
{
    private decimal accountBalance;
    private string accountType;

    public BankingAccount(decimal initialBalance, string accountType)
    {
        if (accountType != "checking" && accountType != "savings")
        {
            throw new Exception($"{accountType} is not a valid account type");
        }

        this.accountType = accountType;
        this.accountBalance = initialBalance;
    }

    public decimal ViewBalance()
    {
        return accountBalance;
    }

    /// <summary>
    /// Deposits funds to the account.
    /// <param name="fundsToBeDeposited">The amount of money to be withdrawn.</param>
    /// </summary>
    public void DepositFunds(decimal fundsToBeDeposited)
    {
        if (fundsToBeDeposited > 0)
        {
            accountBalance += fundsToBeDeposited;
            Console.WriteLine($"${fundsToBeDeposited} were successfully deposited to the account");
        }
        else
        {
            Console.WriteLine("Please specify an amount greater than 0");
        }
    }

    /// <summary>
    /// Withdraws funds from the account.
    /// <param name="fundsToBeWithdrawn">The amount of money to be withdrawn.</param>
    /// </summary>
    public void WithdrawFunds(decimal fundsToBeWithdrawn)
    {
        if (fundsToBeWithdrawn < accountBalance)
        {
            accountBalance -= fundsToBeWithdrawn;
            Console.WriteLine($"${fundsToBeWithdrawn} were successfully withdrawn from the account.");
        }
        else
        {
            Console.WriteLine("The amount to be withdrawn cannot exceed the account balance.");
        }
    }
}
