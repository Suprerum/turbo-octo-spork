using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkApp
{
    public class Set
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReleaseDate { get; set; }
        public List<Card> Cards { get; set; }
    }
}
