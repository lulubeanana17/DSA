using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Jung_
{
    internal class CreateArray
    {
        ///<summary>
        ///Instruction 5.b) generating array of random numbers
        ///This is a method of generating array
        ///</summary>
        public static int[] CreateUnsortedArray(int _size)
        //_size defines the size of array(e.g. 50)
        {
            int[] array = new int[_size];
            //create array with size, its all values are 0 at this moment

            Random rnd = new Random();
            //generate random numbers

            for (int i = 0; i < _size; i++)
            {
                array[i] = rnd.Next(0, _size * 2);
                //select random number between 0 and _size * 2
                //assign number to the index of array
            }

            return array;
        }
    }
}
