﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingWithAbstructFactory.Pattern;

namespace WorkingWithAbstructFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = null;
            client = new Client(new CocaColaFactory());
            client.Run();

            client = new Client(new PepsiFactory());
            client.Run();
        }
    }
}
