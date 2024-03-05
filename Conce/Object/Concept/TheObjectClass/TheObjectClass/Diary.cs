using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObjectClass
{
    internal class Diary
    {
        public int CurrentPage
        { get; set; }

        public Diary(int page = 0) : base()
        {
            CurrentPage = page;
        }

        public Diary(int page, string author, string title) : base(author, title)
        {
            CurrentPage = page;
        }

        public void Flip()
        {
            CurrentPage++;
        }

        public string SpillSecret()
        {
            return "OMG kerry loves kris <3";
        }

        public virtual string Stringify()
        {
            return "This is a Diary object!";
        }

        public override string ToString()
        {
            return "Surprise!";
        }
    }
}
}
