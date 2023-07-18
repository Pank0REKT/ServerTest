using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTest
{
    static class Server
    {
        private static int _count = 0;
        private static object _locker = new object();

        public static async ValueTask<int> GetCount()
        {
            await Task.Delay(0);
            return _count;
        }

        public static void AddToCount(int value)
        {
            lock (_locker) 
            {
                _count += value;
            }
            
        }
    }
}
