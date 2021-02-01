using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList;

namespace MyListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList.MyList list = new MyList.MyList();

            Console.WriteLine("Ввдите кол-во добовляемых значений: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                list.MyAdd(int.Parse(Console.ReadLine()));
            }

            list.MyOutput();

            Console.WriteLine($"Максимальное значение: {list.MyMax()}");

            int[] mas = list.GetElements((x) => x % 2 == 0);
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
