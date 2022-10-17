using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Jung_
{
    ///<summary>
    ///This is sort class that contains BubbleSort and InsertionSort
    ///swap method exists for sort methods
    ///</summary>
    internal class Sort
    {
        ///<summary>
        ///Swap method for two sort algorithms
        ///</summary>
        public static int[] swap(int[] array, int beforeIndex, int afterIndex)
        {
            int beforeValue = array[beforeIndex];
            //store beforevalue in beforevalue variable
            array[beforeIndex] = array[afterIndex];
            //assign aftervalue in beforevalue
            array[afterIndex] = beforeValue;
            //assign beforevalue in aftervalue
            //swapping process all done

            return array;
        }

        ///<summary>
        ///Instruction 3. BubbleSort method
        ///</summary>
        public static int[] BubbleSort(int[] array)
            //complexity of bubbleSort is O(n^2)
            //best case to sort is n
            //worst case to sort is n^2
        {   
            for(int i = 0; i < array.Length; i++)
                //starting from i
                //i is outer
                //one iteration is n times
            {
                for(int j = 0; j < array.Length -1; j++)
                    //when i is set
                    //checking size between two values from 0 to the end
                {
                    if (array[j] > array[j + 1])
                        //when before value is bigger than after value
                    {
                        swap(array, j, j + 1);
                        //swap the two values to order in ascending
                    }
                }
            }
            return array;
            //return sorted array
        }

        ///<summary>
        ///Instruction 4. InsertionSort method
        ///</summary>
        public static int[] InsertionSort(int[] array)
            //complexity of insertionSort is O(n^2)
            //best case to sort is n
            //worst case to sort is n^2
        {
            for(int i = 1; i < array.Length; i++)
                //starting from 1, because this method will sort backwards values
                //it will be every single time i number goes up
            {
                int j = i;
                while(j > 0 && array[j] < array[j - 1])
                    //when j is still bigger than 0
                    //and before value is bigger than after value
                {
                    swap(array, j - 1, j);
                    j--;
                    //swap the values and check one step back values
                }
            }
            return array;
        }
    }
}
