using System.Net.Security;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Caesar Cipher!\n");

        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        //char[] symbol = new char[] { '~', "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", ":", ";", "<", "<", "?", ",", "|", "\\", "/", "-" };
        Console.WriteLine("Write you Secret message here");



        //String UpperCase to LowerCase
        string secretInput = Console.ReadLine().ToLower();

        //Removine empyt space with Replace method
        secretInput = secretInput.Replace(" ", "");


        // Console.WriteLine(secretInput);

        //Separating each word to a char-array
        char[] secretMessage = secretInput.ToCharArray();


        


        Encrypt(secretMessage, alphabet);


        

    }

    static void Encrypt(char[] userString, char[] letters)
    {

        //Declaring encryptedMessage Array
        char[] encryptedMessage = new char[userString.Length];


        for (int i = 0; i < userString.Length; i++)
        {
            int shiftIndex = 0;

            //Replacing Special Character with "x"
            if (Char.IsLetter(userString[i]))
            {
                userString[i] = userString[i];
            }
            else
            {
                userString[i] = 'x';
            }


            //Finding the char value at index and displaying it :TP
            /*char messageAlphabet = userString[i];
            Console.WriteLine(messageAlphabet);*/

            //Getting the index of message letter through alphabet char-array
            int index = Array.IndexOf(letters, userString[i]);
            /*
            if (index > 22)
            {
                shiftIndex = index - 23;
                encryptedMessage[i] = letters[shiftIndex];
            }
            else
            {
                shiftIndex = index + 3;
                encryptedMessage[i] = letters[shiftIndex];
            }
            */

            shiftIndex = (index + 3) % letters.Length;
            encryptedMessage[i] = letters[shiftIndex];
        }
        Console.WriteLine(encryptedMessage);
        Console.ReadLine();

        /*for (int i = 0; i < userString.Length; i++)
        {
            Console.WriteLine("Method Encrypt: " + userString[i]);
        }*/


    }
}