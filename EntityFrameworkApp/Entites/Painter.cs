using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkApp
{
    public class Painter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Card> Cards { get; set; }
    }
}
