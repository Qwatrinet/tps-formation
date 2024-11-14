using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.ListBox;

namespace UtilsForms
{
    public static class ListExtension
    {
        public static ObjectCollection Swap(this ObjectCollection list, int indexA, int indexB)
        {
            object tmp = list[indexA];
            list.RemoveAt(indexA);
            list.Insert(indexB, tmp);

            return list;
        }
    }
}
