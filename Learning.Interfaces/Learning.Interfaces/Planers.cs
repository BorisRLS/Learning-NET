using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Interfaces
{
    internal class Planers : IFly, IMove
    {

        public double Fly(double distance)
        {
            return distance / 600;
        }

        public int Move(int distance)
        {
            return distance / 60;
        }
    }
}
