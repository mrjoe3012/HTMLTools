using System.Collections.Generic;

namespace HTMLTools
{
    interface IStringLinesConvertable : IStringLineConvertable
    {
        List<string> GetLines();
    }
}
