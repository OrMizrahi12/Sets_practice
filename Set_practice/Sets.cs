using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_practice
{
    internal class Sets
    {
        bool[] onOrOff = new bool[1000];
        private int[] setArr;
        public Sets()
        {

        }

        public Sets(params int[] intArr)
        {
            setArr = arrController(intArr);
        }

        int[] arrController(int[] intArr)
        {
            List<int> intResult = new List<int>();
            for (int i = 0; i < intArr.Length; i++)
            {
                for (int j = 0; j < onOrOff.Length; j++)
                {
                    if (onOrOff[i] == false && i == intArr[i])
                    {
                        onOrOff[i] = true;
                        intResult.Add(i);
                    }
                }
            }
            return intResult.ToArray();
        }

        void printArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}
