using System.Collections.Generic;

namespace HTMLTools
{
    //@qdclass(An interface that prototypes nesting of other elements within an element.)
    public interface INest
    {

        List<HTMLElement> NestedElements
        {
            get;
            set;
        }

    }
    //@qdend
}
