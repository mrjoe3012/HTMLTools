using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTools
{
    static class Extensions
    {
        public static List<T> Add<T>(this List<T> thisList, List<T> otherList)
        {

            foreach(T t in otherList)
            {
                thisList.Add(t);
            }

            return thisList;
        }
    }
}
