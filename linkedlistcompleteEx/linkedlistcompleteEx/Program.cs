using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlistcompleteEx
{
    internal class Program
    {
        public static void Printlinkedlist(LinkedList<string>list)
        {
            Console.WriteLine("**All elements**");
            Console.WriteLine("linked list contains:{0} \nelements as follows!!", list.Count);
            var enumerator = list.GetEnumerator();
            while (enumerator.MoveNext()) 
            {
                var element = enumerator.Current;
                Console.WriteLine(element);
            }
         }
        static void Main(string[] args)
        {
            LinkedList<string> linkedlist = new LinkedList<string>();
            linkedlist.AddLast("RAM");
            linkedlist.AddLast("ROM");
            linkedlist.AddLast("CD");
            linkedlist.AddLast("Printer");

            Printlinkedlist(linkedlist);
            
            linkedlist.RemoveFirst();
            Console.WriteLine(" ");
            Console.WriteLine("**After removing first item**");

            Printlinkedlist(linkedlist);

            linkedlist.AddFirst("Keyboard");
            Console.WriteLine(" ");
            Console.WriteLine("**After adding one item keyboard at first**");

            Printlinkedlist(linkedlist);

            Console.WriteLine(" ");
            Console.WriteLine("**Enter Hardware**");
            string hdName = Console.ReadLine(); 
            if(linkedlist.Contains(hdName))
            {
                Console.WriteLine("hardware found!!");
            }
            else
            {
                Console.WriteLine("no such hardware exist!!");
            }
            Console.ReadKey();



        }
    }
}
