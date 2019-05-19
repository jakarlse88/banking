interface IBankingAccount
{
    decimal ViewBalance();
    void DepositFunds(decimal fundsToBeDeposited);
    void WithdrawFunds(decimal fundsToBeWithdrawn);
}