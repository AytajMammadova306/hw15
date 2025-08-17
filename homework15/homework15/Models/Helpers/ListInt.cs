using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace homework15.Models.Helpers
{
    internal class ListInt
    {
        private int[] arr = {0,1,2,3,4,5};
        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
        public void Add(int num)
        {
            int[] newarr = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newarr[i] = arr[i];
            }
            newarr[newarr.Length -1] = num;
            arr = newarr;
        }
        public bool Contains(int num)
        {
            foreach (int i in arr)
            {
                if (i == num)
                    return true;
            }
            return false;
        }
        public void AddRange(params int[] nums)
        {
            int[] newarr = new int[nums.Length + arr.Length];
            for(int i=0; i < arr.Length; i++)
            {
                newarr[i] = arr[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                newarr[i + arr.Length] = nums[i];
            }
            arr = newarr;
        }
        public int Sum()
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }
        public void Remove(int num)
        {
            int[] newarr = new int[arr.Length - 1];
            int j = 0;
            for (int i = 0;i < arr.Length;i++)
            {
                if (arr[i] != num)
                {
                    newarr[j]=arr[i];
                    j++;
                }
            }
            arr = newarr;
        }
        public void RemoveRange(params int[] nums)
        {
            int[] newarr = new int[arr.Length - nums.Length];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                foreach (int k in nums)
                {
                    if (arr[i] !=k)
                        count++;
                }
                if (count==nums.Length)
                {
                    newarr[j] = arr[i];
                    j++;
                }
            }
            arr = newarr;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                sb.Append($"{arr[i].ToString()}, ");
            }
            sb.Append(arr[arr.Length - 1]);
            return sb.ToString();
        }
    }
}
