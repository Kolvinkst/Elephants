﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elephants
{
    internal class Elephant
    {
        public string Name;
        public int EarSize;
        
        public void WhoAmi()
        {
            Console.WriteLine("My name is " + Name + ".");
            Console.WriteLine("My ears are " + EarSize + " inches tall.");
        }
    }
}
