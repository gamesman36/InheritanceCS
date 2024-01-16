namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal OPENING_BALANCE = 55m;
            const decimal MONTHLY_INTEREST = 0.0033m;

            Savings savings = new Savings(OPENING_BALANCE);
            savings.AddMonthlyInterest(MONTHLY_INTEREST);
            savings.ShowBalance();

            Checking checking = new Checking(OPENING_BALANCE);
            checking.DeductServiceCharge();
            checking.ShowBalance();

            Console.ReadLine();
        }
    }
}