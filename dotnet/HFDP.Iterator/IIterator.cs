using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFDP.Iterator
{
    public interface IIterator
    {
        public bool HasNext();
        public object Next();
    }
}
