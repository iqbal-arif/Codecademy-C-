class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Caesar Cipher!\n");

        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        Console.WriteLine("Write you Secret message here");

        string secretInput = Console.ReadLine().ToLower();

        secretInput = secretInput.Replace(" ", "");

        // Console.WriteLine(secretInput);

        char[] secretMessage = secretInput.ToCharArray();


        char[] encryptedMessage = new char[secretMessage.Length];

        for (int i = 0; i < secretMessage.Length; i++)
        {
            //  char message = secretMessage[i] + ",";
            char message = secretMessage[i];
            int index = Array.IndexOf(alphabet, secretMessage[i]);
            Console.WriteLine(index);
            Console.WriteLine(message);
        }
            Console.WriteLine(secretMessage);
    }
}