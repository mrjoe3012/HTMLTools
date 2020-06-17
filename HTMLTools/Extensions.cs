using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTools
{
    //@qdclass(A static helper class.)
    static class Extensions
    {
        //@qdmfunction(Appends the contents of the list to another list.*List<T>)
        //@qdparam(otherList*The list to append.*List<T>)
        public static List<T> Add<T>(this List<T> thisList, List<T> otherList)
        {

            foreach(T t in otherList)
            {
                thisList.Add(t);
            }

            return thisList;
        }
    }
    //@qdend
}
