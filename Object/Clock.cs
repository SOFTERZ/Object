using System;
using System.Collections.Generic;
using System.Text;

namespace Object
{
    class Clock
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }
    }
}
