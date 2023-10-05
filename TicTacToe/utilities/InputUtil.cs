using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.utilities
{
    public static class InputUtil
    {
        public static String inputStr(String s)
        {
            Console.Write(s + ": ");
            String str = Console.ReadLine();
            return str;
        }

        public static int inputInt(String s) {

            while (true)
            {
                try
                {
                    Console.Write(s + ": ");
                    int e = int.Parse(Console.ReadLine());
                    return e;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Input " + s + " yang anda masukan bukan angka, silahkan masukan ulang!");
                }
            }
        }
    }


}
