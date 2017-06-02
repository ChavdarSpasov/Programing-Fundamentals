using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Stateless
{
    class Stateless
    {
        static void Main(string[] args)
        {
            var state = Console.ReadLine();
            var fiction = Console.ReadLine();

            while (state != "collapse")
            {
                while (fiction.Length != 0 )
                {
                    state = state.Replace(fiction,"");
                    state = state.Trim();

                    fiction = fiction.Remove(0, 1);
                    if (fiction.Length >0)
                    {
                        fiction = fiction.Remove(fiction.Length-1, 1);
                    }
                }

                if (state == "")
                {
                    Console.WriteLine("(void)");
                }
                else
                {
                    Console.WriteLine(state);
                }


                state = Console.ReadLine();
                fiction = Console.ReadLine();
            }

        }
    }
}
