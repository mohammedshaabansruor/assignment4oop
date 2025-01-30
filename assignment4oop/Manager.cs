using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4oop
{
    internal class Manager : Employee
    {
        public override void Work()
        {
         
            base.Work();
           
            Console.WriteLine("Manager is managing");
        }
    }
}
