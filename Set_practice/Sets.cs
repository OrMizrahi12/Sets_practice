using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_practice
{
    internal class Sets
    {
        static bool[] onOrOff = new bool[1000];
        private int[] setArr;
        public Sets() { }

        public Sets(params int[] intArr)
        {
            setArr = fixDuplicationInArr(intArr);
            addToGlobalArr(setArr);
        }

        void addToGlobalArr(int[] intArr)
        {
            for (int i = 0; i < onOrOff.Length; i++)         
                for (int j = 0; j < intArr.Length; j++)              
                    if (!onOrOff[i] && i == intArr[j])                    
                        onOrOff[i] = true;    
        }

        int[] fixDuplicationInArr(int[] arrInput)
        {
            List<int> numsResultList = new List<int>();

            for (int i = 0; i < arrInput.Length; i++)
               if(!numsResultList.Contains(arrInput[i]))
                    numsResultList.Add(arrInput[i]);

            return numsResultList.ToArray();
        }

        public static void ShowGlobalArr()
        {
            for (int i = 0; i < onOrOff.Length; i++)
                if (onOrOff[i]) 
                    Console.WriteLine(i);
        }
        public void PrintThisSetArr()
        {
            for (int i = 0; i < setArr.Length; i++)
                Console.WriteLine(setArr[i]);         
        }

        public void Union(Sets sets)
        {
            List<int> intResult = new List<int>();
            intResult = setArr.ToList();

            for (int i = 0; i < sets.setArr.Length; i++)            
                intResult.Add(sets.setArr[i]);
            
            this.setArr = intResult.ToArray();
        }

        

    }
}
