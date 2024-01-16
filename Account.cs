namespace Inheritance
{
    class Account
    {
        protected decimal BankBalance { get; set; }

        protected Account()
        {
            Console.WriteLine();
            Console.WriteLine("Inside the Account constructor");
        }

        public void ShowBalance()
        {
            Console.WriteLine("The balance is " + BankBalance.ToString("C"));
        }
    }
}