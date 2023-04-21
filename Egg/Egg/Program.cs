using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egg
{
    public class Program
    {
        static void Main(string[] args)
        {
            Egg egg = new Egg(EggType.NOTWELLDONE);
            FrontTuyok front = new FrontTuyok();
            BackTuyok back = new BackTuyok();

            egg.DisplayInfo();
            front.Tuyok();
            back.Tuyok();

        }
    }
}
