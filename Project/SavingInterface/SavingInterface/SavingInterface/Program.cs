namespace SavingInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saving Interface :  App Interface!\n");

            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");

            PasswordManager pm = new PasswordManager("iluvpie", true);
        }
    }
}
