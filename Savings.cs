namespace Inheritance
{
    class Savings : Account
    {
        public Savings(decimal balance)
        {
            Console.WriteLine("Inside the Savings constructor.");
            BankBalance = balance;
        }

        public void AddMonthlyInterest(decimal interest)
        {
            BankBalance *= (1.0m + interest);
        }
    }
}