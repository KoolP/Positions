using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositionsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test methods
            Console.WriteLine("First methods in assignment:");
            Position TestLengthMethod = new Position(5, 6);
            Console.WriteLine("Length from origo = " + TestLengthMethod.Length());
            Position TestEqual = new Position(5, 4);
            Position TestEqual2 = new Position(5, 4);
            Console.WriteLine("Are they equal positions = " + TestEqual.Equals(TestEqual, TestEqual2));
            //Console.WriteLine(new Position(2, 4) > new Position(1, 2) + "\n");
            ////GFunctionalityTest();

            Console.WriteLine("");


            Console.WriteLine("Operator manipulation:");
            Console.WriteLine(new Position(2, 4) + new Position(1, 2));
            Console.WriteLine(new Position(2, 4) - new Position(1, 2));
            Console.WriteLine(new Position(1, 2) - new Position(3, 6));
            Console.WriteLine(new Position(3, 5) % new Position(1, 3));


            Console.WriteLine("");


            Console.WriteLine("Position List manipulation:");
            SortedPosList list1 = new SortedPosList();
            SortedPosList list2 = new SortedPosList();
            list1.Add(new Position(1, 2));
            list1.Add(new Position(5, 9));
            list1.Add(new Position(2, 6));
            list1.Add(new Position(4, 3));
            Console.WriteLine("List1:" + list1);
            Console.WriteLine("Let's remove pos [2] = " + list1[2]);
            // Why is this not working?
            list1.Remove(new Position(2, 6));
            Console.WriteLine("New List looks like: " + list1 + "\n");


            Console.WriteLine("");


            Console.WriteLine("Testing clone: ");
            SortedPosList c1 = list1.Clone();
            Console.WriteLine("List1:\n" + list1);
            Console.WriteLine("Cloned list:\n" + c1);
            list1.Remove(new Position(2, 3));
            Console.WriteLine("List one after one position removed:\n" + list1);
            Console.WriteLine("Cloned list:\n" + c1);


            Console.WriteLine("");


            Console.WriteLine("Values within circle: ");
            SortedPosList list3 = new SortedPosList();
            list3.Add(new Position(1, 1));
            list3.Add(new Position(2, 2));
            list3.Add(new Position(3, 3));
            list3.CircleContent(new Position(5, 5), 4);
            Position centerPos = new Position(5, 5);
            var listOfPosInCircle = list3.circleContent(centerPos, 4);
            Console.WriteLine(listOfPosInCircle + "\n");


            Console.WriteLine("");


            Console.WriteLine("Join two lists: ");
            list2.Add(new Position(3, 7));
            list2.Add(new Position(1, 2));
            list2.Add(new Position(3, 6));
            list2.Add(new Position(2, 3));
            Console.WriteLine((list2 + list1) + "\n");


            Console.WriteLine("");


            Console.WriteLine("List1 - List2:");
            Console.WriteLine("Orginal list: " + list1);
            Console.WriteLine("Reducer list: " + list2);
            var reducedList = list1 - list2;
            Console.WriteLine("New reduced list: " + reducedList + "\n");

            Console.WriteLine("List2 - List1:");
            Console.WriteLine("Orginal list: " + list2);
            Console.WriteLine("Reducer list: " + list1);
            var reducedList2 = list2 - list1;
            Console.WriteLine("New reduced list: " + reducedList2 + "\n");

        }


    }
}
