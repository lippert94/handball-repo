﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Sub
    {

        public int Min { get; set; }
        public int PlayerUp { get; set; }
        public int PlayerDown { get; set; }

        public Sub( int min, int playerup, int playersub)
        {
            Min = min;
            PlayerUp = playerup;
            PlayerDown = playersub;
        }
    }
}
