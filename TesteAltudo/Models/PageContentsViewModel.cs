using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteAltudo.Models
{
    public class PageContentsViewModel
    {
        public List<string> Images { get; set; }

        public List<WordCount> Words { get; set; }

        public string ErrorMsg { get; set; }
    }

    public class WordCount
    {
        public string Word { get; set; }
        public int Count { get; set; }
    }
}
