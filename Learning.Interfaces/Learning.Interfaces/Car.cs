using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Interfaces
{
    internal class Car : IMove
    {

        public int Move(int distance)
        {
            return distance / 60;
        }
    }
}
