using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Class_exercise
{
    public class CreateArray
    {
        private int[] arr;
        private int LeftPointer;
        private int RightPointer;
        public CreateArray()
        {
            arr = new int[10];
            LeftPointer = 0;
            RightPointer = 0;
        }
        public void Add(int value)
        {
            if (RightPointer == arr.Length)
            {
                Array.Resize(ref arr, arr.Length * 2);
            }

            arr[RightPointer] = value;
            RightPointer++;
        }
        public void RemoveFromStart()
        {
            LeftPointer++;
        }
        public void RemoveFromEnd()
        {
            if(RightPointer > LeftPointer) 
            {
                RightPointer--;
            }
        }
        public void GetAllItems()
        {
            for (int i = LeftPointer; i < RightPointer; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}