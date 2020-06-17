using System.Collections.Generic;

namespace HTMLTools
{
    //@qdclass(Should be implemented by any object that can be converted to a list of strings. Note that an object that implements IStringLinesConvertable is required to provide an implementation for <a href="#class-IStringLineConvertable">IStringLineConvertable</a>)
    interface IStringLinesConvertable : IStringLineConvertable
    {
        //@qdmfunction(Returns the object converted to a list of lines.*List<string>)
        List<string> GetLines();
    }
    //@qdend
}
