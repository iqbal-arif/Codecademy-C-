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


        char[] encryptedMessage = new char [secretMessage.Length];
            string finalMessage;

        for (int i = 0; i < secretMessage.Length; i++)
        {
            //  char message = secretMessage[i] + ",";
            char messageAlphabet = secretMessage[i];
            int index = Array.IndexOf(alphabet, secretMessage[i]);
            int shiftIndex = index + 3;
            encryptedMessage[i] = alphabet[shiftIndex];
            //encryptedMessage[index] = message;
           // Console.WriteLine(messageAlphabet);
            //Console.WriteLine(alphabet[shiftIndex]);
            Console.WriteLine(encryptedMessage);
            finalMessage = String.Join(" ", encryptedMessage[i]);
        }
            Console.WriteLine("Encrypted Message: " + finalMessage);

            for (int i = 0;i < secretMessage.Length; i++)
        {

        }
           // Console.WriteLine("Original Message" + finalMessage);
    }
}