using Microsoft.VisualBasic.FileIO;

namespace SavingInterface
{
    internal class TodoList : IDisplayable , IResetable
    {
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        public string HeaderSymbol { get; private set; }


        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        public void Add(string todo)
        {
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
        }

        public void Display()
        {
            Console.WriteLine("Todos");
            Console.WriteLine("--------");
            foreach (var item in Todos) 
            {
                if (String.IsNullOrEmpty(item))
                {
                    Console.WriteLine("[]");
                }
                else
                { Console.WriteLine(item); } 
            }
        }

        public void Reset() 
        {
            Array.Clear(Todos, 0, Todos.Length);
            nextOpenIndex = 0;
        }
        /*
        public void HeaderSymbol()
        {
            Console.WriteLine("Todos");
            if (Symbol == "-") Console.WriteLine("--------");
            else Console.WriteLine("****");

        }
        */
    }
}