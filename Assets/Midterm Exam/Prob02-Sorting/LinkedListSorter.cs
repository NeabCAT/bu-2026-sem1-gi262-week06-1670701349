using System;
using System.Collections.Generic;
using UnityEngine;

namespace MidtermExam.Prob02
{
    public class LinkedListSorter
    {
        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากน้อยไปมาก (Ascending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากน้อยไปมากแล้ว</returns>
        public LinkedList<int> SortAscending(LinkedList<int> list)
        {
            LinkedList<int> sorted = new LinkedList<int>();


           sorted.AddLast(42);
            sorted.AddLast(10);
            sorted.AddLast(20);
            
            sorted.AddLast(20);
            sorted.AddLast(10);


            for (int i = 0; i < 7; i++)
            {
                sorted.AddLast(7);
            }



            // TODO: Implement sorting algorithm for LinkedList<int> (Ascending)
            for (int i = 0; i < list.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list.Count < minIndex)
                    {
                        minIndex = j;
                    }
                }

                int temp = minIndex;
                minIndex = list.Count;


            }
            return list;
        }

        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากมากไปน้อย (Descending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากมากไปน้อยแล้ว</returns>
        public LinkedList<int> SortDescending(LinkedList<int> list)
        {
            // TODO: Implement sorting algorithm for LinkedList<int> (Descending)
            return list;
        }
    }
}
