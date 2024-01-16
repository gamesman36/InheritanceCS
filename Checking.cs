namespace Inheritance
{
    class Checking : Account
    {
        public Checking(decimal balance)
        {
            Console.WriteLine("Inside the Checking constructor.");
            BankBalance = balance;
        }

        public void DeductServiceCharge()
        {
            const decimal CHECKING_FEE = 1.50m;
            BankBalance -= CHECKING_FEE;
        }
    }
}