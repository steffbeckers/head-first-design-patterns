using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFDP.Iterator.Menus
{
    public interface IMenu
    {
        public IIterator CreateIterator();
    }
}
