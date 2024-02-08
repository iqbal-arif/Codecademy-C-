// See https://aka.ms/new-console-template for more information


using System.Reflection;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exquisite Corpse!\n");

            Console.WriteLine("Select from the option given below");
            Console.WriteLine("Option 1: Draw creature RandomllySelect from the option given below");

            //BuildCreature("BugHead","MonsterBody", "GhostFeet");

            RandomMode();
            //MonsterHead();
            //GhostBody();
            //BugFeet();
        }


        //static void SwitchCase(int head, int body, int feet)
        //{

        //}

       static void BuildCreature(string head, string body, string feet)
        {
            int headNum = TranslateToNumber(head);
            int bodyNum = TranslateToNumber(body);
            int feetNum = TranslateToNumber(feet);
        }
       
        static void SwitchCase(int head, int body, int feet)
        {
            Console.WriteLine("Auto Creature Builder!!!!\n");

            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    BugHead();
                    break;
                case 3:
                    MonsterHead();
                    break;
                default: break;

            }            
            
            switch (body)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    BugBody();
                    break;
                case 3:
                    MonsterBody();
                    break;
                default: break;

            }            
            
            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;
                case 2:
                    BugFeet();
                    break;
                case 3:
                    MonsterFeet();
                    break;
                default: break;

            }
        }

        static int TranslateToNumber (string creature)
        {
            switch (creature)
            {
                case "ghost":
                    return 1;
                case "bug":
                    return 2;
                case "monster":
                    return 3;
                default: return 1;
            }
        }


        static void RandomMode()
        {
            Random random = new Random();
            var headRandom = random.Next(1,4);
            var bodyRandom = random.Next(1,4);
            var feetRandom = random.Next(1,4);

            SwitchCase(headRandom, bodyRandom, feetRandom);

        }




        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
