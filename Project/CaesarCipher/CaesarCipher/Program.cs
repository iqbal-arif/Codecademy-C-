using System.Net.Security;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Caesar Cipher!\n");

        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        //char[] symbol = new char[] { '~', "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", ":", ";", "<", "<", "?", ",", "|", "\\", "/", "-" };
        Console.WriteLine("Write your Secret message to Encrypt");



        //String UpperCase to LowerCase
        string secretInput = Console.ReadLine().ToLower();

        //Removine empyt space with Replace method
        secretInput = secretInput.Replace(" ", "");



        //Separating each word to a char-array
        char[] secretMessage = secretInput.ToCharArray();


        //Encrypt Method
        //string encrypt =  Encrypt(secretMessage, alphabet);
        Encrypt(secretMessage, alphabet);


        //UserInput To Decrypt Secret Note
        string encryptedInput = Console.ReadLine().ToLower();

        //Separating each word to a char-array
        char[] encryptedNote = encryptedInput.ToCharArray();



        //Decrypt Method
        Decrypt(encryptedNote, alphabet);

        Console.ReadLine();


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


            //Finding the char value at index and displaying it :Testin Purpos
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

            //Shifting each character 3 index
            shiftIndex = (index + 3) % letters.Length;
            encryptedMessage[i] = letters[shiftIndex];
        }

        Console.WriteLine();
        Console.WriteLine(encryptedMessage);

        Console.WriteLine("Write your Secret message to Decrypt");


        //string[] animals = new string[3];
        //string encryptedUserString = encryptedMessage.ToString;
        /*
                for (int i = 0; i < encryptedUserString.Length; i++)
                {

               // Console.WriteLine($"'{encryptedUserString[i]}'" + ",");
                Console.WriteLine(encryptedUserString[i]);
                    //Concatnating the String
                    // encryptedUserString[i] = ;
                }
                   // Console.WriteLine(encryptedUserString.Join(",", encryptedUserString));
        */

    }
    static void Decrypt(char[] userString, char[] letters)
    {
        //Declaring decryptedMessage Array
        char[] decryptedMessage = new char[userString.Length];


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


            //Finding the char value at index and displaying it :Testin Purpos
            /*char messageAlphabet = userString[i];
            Console.WriteLine(messageAlphabet);*/

            //Getting the index of message letter through alphabet char-array
            int index = Array.IndexOf(letters, userString[i]);
            
            if (index < 3)
            {
                shiftIndex = index + 23;
           // Console.WriteLine($"{userString[i]} <3: {shiftIndex}");

                decryptedMessage[i] = letters[shiftIndex];
            }
            else
            {
                shiftIndex = index - 3;
            //Console.WriteLine($"{userString[i]} : {shiftIndex}");
                decryptedMessage[i] = letters[shiftIndex];
                // }
            

                //Shifting each character 3 index
                /*shiftIndex = (index - 3) % letters.Length;
                decryptedMessage[i] = letters[shiftIndex];*/

            }


        }
            Console.WriteLine();
            Console.WriteLine(decryptedMessage);
    }
}