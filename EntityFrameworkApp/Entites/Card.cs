using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkApp
{
    public class Card
    {
        public int Id { get; set; }
        public int SerialNumber { get; set; }
        public Set Set { get; set; }
        public Painter Painter { get; set; }

    }
}
