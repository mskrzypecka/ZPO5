using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO5.Interfaces;

namespace ZPO5
{
    public class Logger : LoggerStore
    {
        public virtual void DEBUG(string message) => Console.WriteLine("DEBUG: " + message);
        public virtual void INFO(string message) => Console.WriteLine("INFO: " + message);
    }
}
