using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class SwapItemsCollection
    {
        public static void Swap<T>(IList<T> list,int index1,int index2)
        {
            T tmp= list[index2];
            list[index2] = list[index1];
            list[index1] = tmp;
        }
    }
}
