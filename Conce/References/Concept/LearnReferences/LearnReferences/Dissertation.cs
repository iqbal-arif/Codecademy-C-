using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnReferences
{
    internal class Dissertation : Book, IFlippable
    {
        public int CurrentPage
        { get; set; }

        public Dissertation(int page = 0) : base()
        {
            CurrentPage = page;
        }

        public void Flip()
        {
            CurrentPage++;
        }

        public string Define()
        {
            return "dissertation - a long essay on a particular subject";
        }

        public override string Stringify()
        {
            return "This is a Dissertation object!";
        }
    }
}
