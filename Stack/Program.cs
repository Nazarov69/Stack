using System;
using Stack.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t simple stack");
            Random random = new Random();
            ClassStack<int> st = new ClassStack<int>();

            int length = random.Next(5, 17);

            Console.WriteLine($"length stack : {length}. index = [0 .. {length - 1}]");

            for (int i = 0; i < length; i++)
            {
                st.Push(i);
            }

            Console.Write($"index for peek?... ");
            int.TryParse(Console.ReadLine(), out int indexcheck);


            if (length - indexcheck - 1 >= 0)
            {
                for (int i = 0; i < (length - indexcheck - 1); i++)
                {
                    st.Pop();
                }
                Console.WriteLine($"index {indexcheck} : {st.Peek()}");
            }
            else
            {
                throw new NullReferenceException("error index");
            }



            Console.ReadLine();

            Console.WriteLine("\t linked stack");

            var linkst = new LinkedStack<int>();

            length = random.Next(5, 17);

            Console.WriteLine($"length linked stack : {length}. index = [0 .. {length - 1}]");

            for (int i = 0; i < length; i++)
            {
                linkst.Push(i);
            }

            Console.Write($"index for peek?... ");
            int.TryParse(Console.ReadLine(), out indexcheck);


            if (length - indexcheck - 1 >= 0)
            {
                for (int i = 0; i < (length - indexcheck - 1); i++)
                {
                    linkst.Pop();
                }
                Console.WriteLine($"index {indexcheck} : {linkst.Peek()}");
            }
            else
            {
                throw new NullReferenceException("error index");
            }


            Console.ReadLine();

            Console.WriteLine("\t array stack");

            length = random.Next(5, 17);

            var arrst = new ArrayStack<int>(length);

            Console.WriteLine($"length array stack : {length}. index = [0 .. {length - 1}]");

            for (int i = 0; i < length; i++)
            {
                arrst.Push(i);
            }

            Console.Write($"index for peek?... ");
            int.TryParse(Console.ReadLine(), out indexcheck);


            if (length - indexcheck - 1 >= 0)
            {
                for (int i = 0; i < (length - indexcheck - 1); i++)
                {
                    arrst.Pop();
                }
                Console.WriteLine($"index {indexcheck} : {arrst.Peek()}");
            }
            else
            {
                throw new NullReferenceException("error index");
            }
        }
    }
}
