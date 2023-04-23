using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOutOfRangeException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<char> characters = new List<char>();
                characters.InsertRange(0, new Char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
                int value = characters[6];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                System.Console.WriteLine("Index was out of range\n" + ex);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Something was wrong\n" + ex);
            }
            finally
            {
                System.Console.WriteLine("Try again");
            }
        }
    }
}
