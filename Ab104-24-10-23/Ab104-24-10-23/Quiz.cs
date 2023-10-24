using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab104_24_10_23
{
    public class Quiz
    {
        public int _id = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Question> Questions { get; set; }

        public Quiz()
        {
            Id = _id++;
            Questions = new List<Question>();
        }
    }

}
