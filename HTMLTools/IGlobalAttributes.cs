using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLTools
{
    public interface IGlobalAttributes
    {
        HTMLFieldAttribute ID
        {
            get;
            set;
        }

        HTMLFieldAttribute Class
        {
            get;
            set;
        }

        HTMLFieldAttribute Style
        {
            get;
            set;
        }

        HTMLFieldAttribute AccessKey
        {
            get;
            set;
        }

        HTMLFieldAttribute ContentEditable
        {
            get;
            set;
        }

        HTMLFieldAttribute Dir
        {
            get;
            set;
        }

        HTMLFieldAttribute Draggable
        {
            get;
            set;
        }

        HTMLFieldAttribute DropZone
        {
            get;
            set;
        }

        HTMLFieldAttribute Lang
        {
            get;
            set;
        }

        HTMLFieldAttribute SpellCheck
        {
            get;
            set;
        }

        HTMLFieldAttribute TabIndex
        {
            get;
            set;
        }

        HTMLFieldAttribute Title
        {
            get;
            set;
        }

        HTMLFieldAttribute Translate
        {
            get;
            set;
        }

        HTMLBooleanAttribute Hidden
        {
            get;
            set;
        }

    }
}
