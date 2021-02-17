using System;
using System.Collections.Generic;
using System.Text;

namespace Object
{
    class Transactions<U,V>
    {
        public U FormAccount { get; set; }
        public U ToAccount { get; set; }
        public V Code { get; set; }
        public int Sum { get; set; }
    }
}
