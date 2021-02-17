using System;
using System.Collections.Generic;
using System.Text;

namespace Object
{
    class Account<T>//Любой параметр
    {
        T id = default(T);//По умолчанию
        public static T session;//Обабщенный
        public T Id { get; set; }
        public int Sum { get; set; }
    }
}
