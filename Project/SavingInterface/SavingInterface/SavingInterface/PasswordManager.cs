namespace SavingInterface
{
    internal class PasswordManager : IDisplayable , IResetable
    {
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        public string HeaderSymbol { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        public void  Display() 
        {
            Console.WriteLine("Password");
            Console.WriteLine("--------");
            if (Hidden)
                Console.WriteLine(Password);
            else Console.WriteLine("**********");
        }

        public void Reset()
        {
            Hidden = false;
            Password = String.Empty;
        }
    }
}