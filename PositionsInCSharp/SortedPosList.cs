using System;
using System.Collections.Generic;

namespace PositionsInCSharp
{
    public class SortedPosList
    {
        List<Position> sortedPosList = new List<Position>();

        public int Count()
        {
            return sortedPosList.Count;
        }

        // Adds a Position object to the list. Sorted Length from origo.
        public void Add(Position pos)
        {
            sortedPosList.Add(pos);

            for (int i = 0; i < Count(); i++)
            {
                for (int j = i + 1; j < Count(); j++)
                {
                    if (sortedPosList[i] > sortedPosList[j])
                    {
                        Position holder = sortedPosList[i];
                        sortedPosList[i] = sortedPosList[j];
                        sortedPosList[j] = holder;
                    }
                }
            }
        }

        // Returns a string containing all positions, separated with commas
        public override string ToString()
        {
            return String.Join(",", sortedPosList);
        }


        // Remove
        public bool Remove(Position position)
        {
            foreach (Position posInList in sortedPosList)
            {
                if (position.Equals(posInList))
                {
                    sortedPosList.Remove(posInList);
                    return true;
                }
            }
            return false;
        }

        // Returns a clone of positions in lsit
        public SortedPosList Clone()
        {
            SortedPosList clonedList = new SortedPosList();

            foreach (Position pos in sortedPosList)
            {
                clonedList.Add(pos.Clone());
            }
            return clonedList;
        }


        public SortedPosList circleContent(Position centerPos, double radius)
        {
            SortedPosList withInCircleList = new SortedPosList();

            foreach (var item in sortedPosList)
            {
                var dist = Math.Sqrt(Math.Pow(centerPos.X - item.X, 2) + Math.Pow(centerPos.Y - item.Y, 2));
                if (dist < radius)
                {
                    withInCircleList.Add(item);
                }
            }
            return withInCircleList;
        }


        public static SortedPosList operator +(SortedPosList sp1, SortedPosList sp2)
        {
            SortedPosList joinedList = new SortedPosList();
            joinedList = sp1.Clone();

            foreach (var item in sp2.sortedPosList)
            {
                joinedList.Add(item);
            }
            return joinedList;
        }


        public static SortedPosList operator -(SortedPosList sp1, SortedPosList sp2)
        {
            SortedPosList reducedList = new SortedPosList();
            reducedList = sp1.Clone();

            foreach (var pos in sp2.sortedPosList)
            {
                reducedList.sortedPosList.RemoveAll(item => item.X == pos.X && item.Y == pos.Y);
            }

            return reducedList;
        }


        public Position this[int index]
        {
            // GET - Returns Position at given index
            get { return sortedPosList[index]; }
        }



        // Returns a list containing all positions within the given circle
        // centerPos - center of the circle
        public SortedPosList CircleContent(Position centerPos, double radius)
        {
            SortedPosList posWithinCircle = new SortedPosList();

            foreach (Position pos in sortedPosList)
            {
                if (Math.Pow(pos.X - centerPos.X, 2) + Math.Pow(pos.Y - centerPos.Y, 2) < Math.Pow(radius, 2))
                {
                    posWithinCircle.Add(pos);
                    //Console.WriteLine(pos);
                }
            }
            return posWithinCircle;
        }



    }
}