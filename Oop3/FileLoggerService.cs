﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    internal class FileLoggerService : ILoogerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");

        }

    }
}
