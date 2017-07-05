using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Sub
    {

        public int Min { get; }
        public int PlayerUp { get; }
        public int PlayerSub { get; }

        public Sub( int min, int playerup, int playersub)
        {
            Min = min;
            PlayerUp = playerup;
            PlayerSub = playersub;
        }
    }
}
