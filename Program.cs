
//test bank program

Console.WriteLine("Welcome to Bank Boca Code");

BankAccount account = new BankAccount();
account.AccountNumber = "12345";

account.MakeDeposit(100);

BankAccount account2 = new SavingAccount(500);

try{
decimal newBalance = account2.MakeDepositGetDeposit(100);
}catch(Exception ex){
    Console.WriteLine($"we got an error when running MakeDepositGetDeposit(-1) or any other negative number {ex.ToString()} ");
}



Console.WriteLine($"the balance of account is {account.Balance}"); 
Console.WriteLine($"the account number of account is {account.AccountNumber}"); 
Console.WriteLine($"the account number of account is {account2.Balance}"); 
