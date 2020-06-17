using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTools
{
    //@qdclass(An interface for objects that can be converted to a single string.)
    interface IStringLineConvertable
    {
        //@qdmfunction(Returns the object converted to a string.*string)
        string GetLine();
    }
    //@qdend
}
