using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace staticders
{
    public class Listİnt
    {
        static int count;
        private int[] ints;
        public int Id {get;}
        public Listİnt()
        {
            Id = ++count;
            ints = new int[0];
        }
        public void Add(int value) 
        {
            Array.Resize(ref ints, ints.Length + 1);
            ints[ints.Length - 1] = value;
        }

        public void Add(params int[] nums)
        {
            Array.Resize(ref ints, ints.Length + nums.Length);
            for (int i = 0; i < nums.Length; i++) 
            {
                ints[ints.Length - nums.Length + i] = nums[i];
            }
        }
        public bool Contains(int value)
        {
            for (int i = 0; i < ints.Length; i++)
                if (ints[i] == value) return true;
            return false;
        }
        public void Pop() 
        {
            if (ints.Length > 0)
            {
                Array.Resize(ref ints, ints.Length - 1);
            }
        }
        public int Sum()
        {
            int cem = 0;
            for (int i = 0; i < ints.Length; i++) cem += ints[i];
            return cem;
        }
        public override string ToString() 
        {
            StringBuilder sb = new StringBuilder();
            foreach (int value in ints) sb.Append(value.ToString() + " ");
            return sb.ToString().Trim();
        }
//      Insert(int num, int index) - Göndərilən elementi daxil olunan indeksə əlavə edib sonrakı elementləri 1 indeks sağa sürüşdürür.

        public int IndexOf(int num) 
        {
            for (int i = 0; i < ints.Length; i++)
                if (ints[i]== num)
                    return i;
            return -1;
        }
        public int LastIndexOf(int num)
        {
            for (int i = ints.Length-1; i >= 0; i--)
                if (ints[i] == num)
                    return i;
            return -1;
        }
        
        public void Insert(int index, int value) 
        {
            Array.Resize(ref ints, ints.Length + 1);

            // Shift elements to the right
            for (int i = ints.Length - 1; i > index; i--)
            {
                ints[i] = ints[i - 1];
            }
            ints[index] = value;
        }
    }
}
