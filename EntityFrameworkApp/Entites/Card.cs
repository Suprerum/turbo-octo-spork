using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkApp
{
    class Card
    {
        public int Id { get; set; }
        public int SerialNumber { get; set; }
        public Set set { get; set; }
        public Painter painter { get; set; }

    }
}
