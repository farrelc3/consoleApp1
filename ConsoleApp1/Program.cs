using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyExamples me = new MyExamples("test", 4);
            me.CallDictionary();
            Console.WriteLine(me.GenerateTupleTotal());
            me.GenerateTotal(TestDelegate, Calc);                
        }
        private static void TestDelegate(int subTotal, int Total)
        {
            Console.WriteLine($"The subTtoal from delagte is {subTotal} and totoal is {Total}");
        }

        private static int Calc(int myValue)
        {
            Console.WriteLine($"2. The subTtoal from delagte is {myValue}");
            return myValue;
        }
    }

    public class MyExamples
    {
        public delegate void MentionTotals(int subTotal, int Total);

        readonly string myString = "";
        readonly int myInt = 0;

        public MyExamples(string names, int dictCount)
        {
            myString = names;
            myInt = 99;
        }

        public void CallDictionary()
        {
            Dictionary<string, int> bb = new Dictionary<string, int>()
            {
                { "test1",1},
                { "test2",2},
                { "test3",3}
            };
            Console.WriteLine(bb.Count);            

            foreach (var item in bb)
                Console.WriteLine($"{item.Key} : {item.Value}");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public int GenerateTotal(MentionTotals mentionTotals, Func<int, int> myFunc)
        {
            double d = 0.1;
            mentionTotals(89, 90);
            List<int> ll = new List<int> { 1, 2, 3 };
            myFunc(79);
            return 1;
          //  return 89;
        }

        public Tuple<int, string> GenerateTupleTotal()
        {            
            return Tuple.Create(99, "Tuple");
        }


    }
}
