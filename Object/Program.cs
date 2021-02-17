using System;
using System.Runtime.CompilerServices;

namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            Console.WriteLine(a.ToString());
            Person p1 = new Person { Name = "Tom" };
            Person p2 = new Person { Name = "Tom" };
            Console.WriteLine(p1.ToString());
            Clock clock = new Clock { Hours = 13, Minutes = 44, Seconds = 44 };
            Console.WriteLine(clock.ToString());
            Console.WriteLine(clock.GetHashCode());
            Console.WriteLine(clock.GetType());
            if(clock.GetType()==typeof(Clock))
                Console.WriteLine("Это реально класс ОК!");
            if (p1.Equals(p2)) Console.WriteLine("Равны");
            else Console.WriteLine("Неравны");
            Account<int> account1 = new Account<int>() { Id=200,Sum=500};
            Console.WriteLine(account1.Id);
            Account<string> account2 = new Account<string> { Id = "Vasia", Sum = 900 };
            Console.WriteLine(account2.Id + account2.Sum);
            Account<string>.session = "228";
            Account<int> acc1 = new Account<int> { Id = 45, Sum = 2241 };
            Account<int> acc2 = new Account<int> { Id = 45, Sum = 2818 };
            Transactions<Account<int>, string> tran1 = new Transactions<Account<int>, string>
            {
                FormAccount = acc1,
                ToAccount = acc2,
                Code = "VzlomJopi",
                Sum = 5000
            };
            int x = 7;
            int y = 9;
            Console.WriteLine(x+" "+y);
            Swap<int>(ref x, ref y);
            Console.WriteLine(x + " "+y);

            string s1 = "hello";
            string s2 = "Niggaaa";
            Console.WriteLine(s1 +" "+ s2);
            Swap<string>(ref s1, ref s2);
            Console.WriteLine(s1 + " "+s2);
        }
        public static void Swap<T>(ref T x,ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
