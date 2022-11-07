using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_practice
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // Unoin = () => 
            Sets sets1 = new Sets(Sets.MakeRandomArr());
            Sets sets2 = new Sets(2,3,5,56,2);
            sets1.Union(sets2);
            Console.WriteLine($"Unoin: {sets1}  \n");

            // intersect = () => 
            Sets sets3 = new Sets(88,6,4,3,564,3,4);
            Sets sets4 = new Sets(2,4,6,678,3,47,7);
            sets3.Intersect(sets4);
            Console.WriteLine($"Intersect: {sets3}  \n");

            // SubSet = () => 
            Sets sets5 = new Sets(4,6,6,4,5,564,765,345,675,3,454);
            Sets sets6 = new Sets(45,46,564,345,676,345,67);
            sets5.SubSet(sets6);
            Console.WriteLine($"SubSet: {sets5.SubSet(sets6)} \n");

            // IsMember = () =>
            Sets sets7 = new Sets(Sets.MakeRandomArr());
            Console.WriteLine($"IsMember: {sets7.IsMember(123)}  \n");

            // Inseret = () => 
            Sets sets8 = new Sets(1,2,3,4,5);
            Console.WriteLine($"Before inseret: {sets8}");
            sets8.Inseret(6);
            Console.WriteLine($"After inseret: {sets8} \n");

            // Delete = () => 
            Sets sets9 = new Sets(99,77,66,55,4,3,345,23,23,33,4,5,6,7,4);
            Console.WriteLine($"Before Delete: {sets9}");
            sets9.Delet(99);
            Console.WriteLine($"After Delete: {sets9} \n");

            // Equals = () => 
            Sets sets10 = new Sets(234,34,45,34,5,6,7,6,4,4,4,4,4,4);
            Sets sets11 = new Sets(1,2,3,4,65,6,6,634,55,7,75,4,56);
            Console.WriteLine($"Equals: {sets10.Equals(sets11)} ");
        }

    }
}
