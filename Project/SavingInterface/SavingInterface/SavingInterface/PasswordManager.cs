namespace SavingInterface
{
    internal class PasswordManager : IDisplayable , IResetable
    {
        private string Password
        { get; set; }

        private string newPassword { get; set; }

        public bool Hidden
        { get; private set; }

        public string HeaderSymbol { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        //METHOD

        public void  Display() 
        {
            Console.WriteLine("Password");
            Console.WriteLine("--------");
            if (Hidden)
                Console.WriteLine(Password);
            else Console.WriteLine("**********");
        }

        public string ChangePassword(string Password, string newPassword)
        {
           int existPassword = String.Compare(Password, newPassword, StringComparison.OrdinalIgnoreCase);

            if (existPassword == 0)
                Reset();

            return newPassword;
        }

        public void Reset()
        {
            Hidden = false;
            Password = String.Empty;
        }
    }
}