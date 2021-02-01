using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    public class MyList
    {
        public List<int> myList;

        public MyList()
        {
            myList = new List<int>();
        }

        public void MyAdd(int num)
        {
            myList.Add(num);
        }

        public void MyOutput()
        {
            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public int MyMax()
        {
            return myList.Max();
        }

        public int[] GetElements(Func<int, bool> areEven)
        {
            int[] evenElements = new int[myList.FindAll((x) => x % 2 == 0).Count];
            int i = 0;
            foreach (var item in myList)
            {
                if (areEven(item))
                {
                    evenElements[i] = item;
                    i++;
                }
            }
            return evenElements;
        }
    }
}
