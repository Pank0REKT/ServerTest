using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTest
{
    static class Server
    {
        private static int _count;

        public static int GetCount()
        {
            return _count;
        }

        public static void AddToCount(int value)
        {
            _count += value;
        }
    }
}
