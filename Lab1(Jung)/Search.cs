using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Jung_
{
    ///<summary>
    ///This is search class that contains LinearSearch and BinarySearch
    ///</summary>
    internal class Search
    {
        ///<summary>
        ///Instruction 1. LinearSearch method
        ///</summary>
        public static int LinearSearch(int[] array, int _value)
        //complexity of linearSearch is O(n)
        //best case to find _value is 1
        //worst case to find _value is n times until the end index of array
        {
            for (int i = 0; i < array.Length; i++)
            //iterate until finding _value
            {
                if (array[i] == _value)
                //when finds _value
                {
                    return ++i;
                    //return number of iterations
                    //number is added 1, because i starts from 0
                }
            }
            return -1;
            //when fail to find _value
            //return -1
        }

        ///<summary>
        ///Instruction 2. BinarySearch method
        ///</summary>
        public static int BinarySearch(int[] array, int _value)
            //BinarySearch is only working in specific condition
            //when array is sorted
            //complexity of binarySearch is O(logn)
            //best case to find _value is 1
            //worst case to find _value is logN
        {
            int min = 0;
            int max = array.Length - 1;
            int i = 1;
            //count number of iterations 

            while(min < max)
            {
                int mid = (max + min) / 2;
                //binarySearch split half until it finds _value

                if (array[mid] == _value)
                {
                    return i;
                    //when finds _value
                    //return i
                }else if (array[mid] < _value)
                {
                    min = mid + 1;
                    //when _value is bigger than middle value
                    //set minimum index is middle index +1
                }else if (array[mid] > _value)
                {
                    max = mid - 1;
                    //when _value is smaller than middle value
                    //set maximum index is middle index -1
                }
                i++;
                //when one iteration is done, could not find _value
                //count 1
            }
            return -1;
            //when fails to find _value
            //return -1
        }
    }
}
