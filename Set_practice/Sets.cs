using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_practice
{
    internal class Sets
    {
        static bool[] onOrOff = new bool[1001];
        private int[] setArr;
        public Sets() { }

        public Sets(params int[] intArr)
        {
           this.setArr = fixDuplicationInArr(intArr);
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
               if(!numsResultList.Contains(arrInput[i]) && arrInput[i] < 1000 && arrInput[i] >= 0)
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
            if (exsistArrInSet(this)) 
                for (int i = 0; i < setArr.Length; i++)
                    Console.WriteLine(setArr[i]);
        }

        public void Union(Sets sets)
        {
            List<int> intResult = new List<int>();
            if (exsistArrInSet(sets))
            {
                intResult = setArr.ToList();
                
                for (int i = 0; i < sets.setArr.Length; i++)
                    intResult.Add(sets.setArr[i]);

                this.setArr = fixDuplicationInArr(intResult.ToArray());
            }
            
        }

        public void Intersect(Sets sets)
        {
            List<int> intResult = new List<int>();
            if (exsistArrInSet(sets))
            {
                for (int i = 0; i < setArr.Length; i++)
                    for (int j = 0; j < sets.setArr.Length; j++)
                        if (setArr[i] == sets.setArr[j])
                            intResult.Add(sets.setArr[j]);

                setArr = intResult.ToArray();
            }
        }

        bool exsistArrInSet(Sets sets)
        {
            if(sets.setArr != null || this.setArr != null)
                return true;
            else
                Console.WriteLine("your object not contain array.");
            return false;
        } 

        public bool SubSet(Sets sets)
        {
            bool duplication = false;
            if (exsistArrInSet(sets))
            {
                for (int i = 0; i < sets.setArr.Length; i++)
                {
                    for (int j = 0; j < setArr.Length; j++)
                        if (sets.setArr[i] == setArr[j])
                            duplication = true;

                    if (!duplication) 
                        return false;
                    duplication = false;
                }
                return true;
            }
            else return false;
        }

        public bool IsMember(int number)
        {
            if(exsistArrInSet(this))
            for (int i = 0; i < setArr.Length; i++)
                if (setArr[i] == number) 
                    return true;
            
            return false;
        }

        public void Inseret(int number)
        {
            if (exsistArrInSet(this))
            {
                for (int i = 0; i < setArr.Length; i++)
                    if (setArr[i] == number)
                        return;

                Array.Resize(ref setArr, setArr.Length + 1);
                setArr[setArr.GetUpperBound(0)] = number;
            }
                
        }

        public void Delet(int number)
        {
            if(exsistArrInSet(this))
            setArr = setArr.Where(val => val != number).ToArray();
        }

        public override string ToString()
        {
            string result = null;
            if (exsistArrInSet(this))
                for (int i = 0; i < setArr.Length; i++)
                    result += setArr.Length -1 > i ? $"{setArr[i]}," : $"{setArr[i]}";

            return result;
        }

        public override bool Equals(object obj)
        {
            Sets sets = obj as Sets;
            bool canContinueCheck = false;
            if (exsistArrInSet(sets))
            {
                for (int i = 0; i < sets.setArr.Length; i++)
                {
                    for (int j = 0; j < setArr.Length; j++)
                        if (sets.setArr[i] == setArr[j]) 
                            canContinueCheck = true;

                    if (!canContinueCheck) 
                        return false;
                    canContinueCheck = false;
                }
                return true;
            }
            else 
                return false;
        }

        public static int[] MakeRandomArr()
        {
            Random rnd = new Random();
            int[] arrResult = new int[12];

            for (int i = 0; i < arrResult.Length; i++)
                arrResult[i] = rnd.Next(0, 1000);

            return arrResult;
        }


    }
}
