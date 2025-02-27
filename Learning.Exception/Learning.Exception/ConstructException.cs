using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Exception
{
    using System;
    internal class ConstructException : Exception
    {
        public ConstructException() : base("Ошибка при вводе данных")
        { }
    }
}
