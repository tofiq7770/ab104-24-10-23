using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_24_10_23
{
    public class Question
    {
        public int _id = 1;

        public int Id { get; set; }
        public string Text { get; set; }
        public List<string> Variants { get; set; }
        public int CorrectVariant { get; set; }
        public Question()
        {
            Id = _id++;
        }
    }

}
