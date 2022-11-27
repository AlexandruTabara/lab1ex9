using System;

namespace lab1ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex 9
                Scrieti un program care interschimba valoarea a doua variabile intregi */
            int a = 5;
            int b = 10;
            Console.WriteLine("Inainte de interschimbare a= " + a + " b= " + b);

            a= a+b;//a este 15
            b= a-b;//b este 5
            a= a-b;//a este 10 acum 

            Console.Write("Dupa interschimbare a= " + a + " b= " + b);

        }
    }
}
